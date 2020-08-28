using System;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;

namespace Camstar.Api.Builder
{
    internal abstract class AssemblyGeneratorBase
    {
        protected const string baseObjectTypeName = "DCObject";
        protected const string servicePrefix = "I";
        protected const string servicePostfix = "Service";
        protected const string resultName = "result";
        protected const string resultPostfix = "_Result";
        protected const string requestName = "request";
        protected const string resultTypeName = "Result";
        protected const string requestTypeName = "Request";
        protected const string requestPostfix = "_Request";
        protected const string valueName = "Value";
        protected const string statusName = "Status";
        protected const string statusTypeName = "ResultStatus";
        protected const string environmentName = "Environment";
        protected const string environmentTypeName = "Environment";
        protected const string environmentPostfix = "_Environment";
        protected const string infoName = "Info";
        protected const string infoTypeName = "Info";
        protected const string infoPostfix = "_Info";
        protected const string parametersName = "parameters";
        protected const string parametersTypeName = "Parameters";
        protected const string parametersPostfix = "_Parameters";
        protected const string userProfileName = "userProfile";
        protected const string userProfileTypeName = "UserProfile";
        protected bool _IsSilverlight;
        protected DCTypeStore dCTypeStore;
        protected ModuleBuilder moduleBuilder;
        protected string nameSpacePrefix;

        public AssemblyGeneratorBase(
            string nameSpace,
            ModuleBuilder moduleBuilder,
            DCTypeStore dCTypeStore)
        {
            nameSpacePrefix = nameSpace + ".";
            this.moduleBuilder = moduleBuilder;
            this.dCTypeStore = dCTypeStore;
        }

        public virtual void AddDC(DCType dCType)
        {
            dCTypeStore.Add(dCType.Name, typeof(string), (TypeBuilder) null);
        }

        protected TypeBuilder DefineType(string name, Type parentType)
        {
            var typeBuilder = moduleBuilder.DefineType(name,
                TypeAttributes.Public | TypeAttributes.BeforeFieldInit, parentType);
            AddDataContractAttribute(typeBuilder);
            return typeBuilder;
        }

        protected ConstructorBuilder DefineTypeConstructor(
            TypeBuilder typeBuilder,
            Type parentType)
        {
            var constructorBuilder = typeBuilder.DefineConstructor(
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName,
                CallingConventions.Standard, null);
            if (parentType == null)
                parentType = typeof(object);
            var ilGenerator = constructorBuilder.GetILGenerator();
            ilGenerator.Emit(OpCodes.Ldarg_0);
            ilGenerator.Emit(OpCodes.Call, parentType.GetConstructor(Type.EmptyTypes));
            ilGenerator.Emit(OpCodes.Ret);
            return constructorBuilder;
        }

        private void AddDataContractAttribute(TypeBuilder typeBuilder)
        {
            var customBuilder1 = new CustomAttributeBuilder(
                typeof(DataContractAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[1]
                {
                    typeof(DataContractAttribute).GetProperty("Namespace")
                }, new object[1] {"Camstar.WCF.ObjectStack"});
            typeBuilder.SetCustomAttribute(customBuilder1);
            var customBuilder2 =
                new CustomAttributeBuilder(typeof(SerializableAttribute).GetConstructor(Type.EmptyTypes),
                    new object[0]);
            typeBuilder.SetCustomAttribute(customBuilder2);
        }

        protected FieldBuilder DefineField(
            TypeBuilder typeBuilder,
            string name,
            Type type,
            DCField field,
            bool isPrivate)
        {
            var fieldBuilder = typeBuilder.DefineField((isPrivate ? "_" : "") + name, type,
                !isPrivate || _IsSilverlight ? FieldAttributes.Public : FieldAttributes.Family);
            if (_IsSilverlight)
            {
                var customBuilder = new CustomAttributeBuilder(
                    typeof(EditorBrowsableAttribute).GetConstructor(new Type[1]
                    {
                        typeof(EditorBrowsableState)
                    }), new object[1]
                    {
                        EditorBrowsableState.Never
                    });
                fieldBuilder.SetCustomAttribute(customBuilder);
            }

            AddMetadataAttribute(fieldBuilder, field);
            AddDataMemberAttribute(typeBuilder.Name, fieldBuilder, name);
            return fieldBuilder;
        }

        protected FieldBuilder DefineField(
            TypeBuilder typeBuilder,
            string name,
            Type type,
            bool isPrivate)
        {
            return DefineField(typeBuilder, name, type, null, isPrivate);
        }

        protected PropertyBuilder DefineProperty(
            TypeBuilder typeBuilder,
            string name,
            Type type)
        {
            Type type1 = dCTypeStore.GetDCBuilderType("DCObject").Type;
            var propertyBuilder = typeBuilder.DefineProperty(name, PropertyAttributes.HasDefault,
                CallingConventions.HasThis, type, null, null, null, null,
                null);
            var attributes =
                MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName;
            var mdBuilder1 = typeBuilder.DefineMethod("set_" + name, attributes, null, new Type[1]
            {
                type
            });
            var ilGenerator1 = mdBuilder1.GetILGenerator();
            ilGenerator1.Emit(OpCodes.Ldarg_0);
            ilGenerator1.Emit(OpCodes.Ldstr, name);
            ilGenerator1.Emit(OpCodes.Ldarg_1);
            ilGenerator1.Emit(OpCodes.Call,
                type1.GetMethod("PropertySet", BindingFlags.Instance | BindingFlags.NonPublic));
            ilGenerator1.Emit(OpCodes.Ret);
            propertyBuilder.SetSetMethod(mdBuilder1);
            var mdBuilder2 = typeBuilder.DefineMethod("get_" + name, attributes, type, null);
            var ilGenerator2 = mdBuilder2.GetILGenerator();
            ilGenerator2.DeclareLocal(type);
            ilGenerator2.Emit(OpCodes.Ldarg_0);
            ilGenerator2.Emit(OpCodes.Ldstr, name);
            ilGenerator2.Emit(OpCodes.Call,
                type1.GetMethod("PropertyGet", BindingFlags.Instance | BindingFlags.NonPublic));
            ilGenerator2.Emit(OpCodes.Castclass, type);
            ilGenerator2.Emit(OpCodes.Ret);
            propertyBuilder.SetGetMethod(mdBuilder2);
            return propertyBuilder;
        }

        protected PropertyBuilder DefineProperty(
            TypeBuilder typeBuilder,
            string name,
            Type type,
            DCField field)
        {
            return DefineProperty(typeBuilder, name, type);
        }

        protected FieldBuilder DefineUniqueField(
            TypeBuilder typeBuilder,
            string name,
            Type type,
            bool isPrivate)
        {
            var fieldBuilder = typeBuilder.DefineField((isPrivate ? "_" : "") + name, type,
                !isPrivate || _IsSilverlight ? FieldAttributes.Public : FieldAttributes.Family);
            var customBuilder = new CustomAttributeBuilder(
                typeof(DataMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[1]
                {
                    typeof(DataMemberAttribute).GetProperty("EmitDefaultValue")
                }, new object[1] {false});
            if (isPrivate)
                customBuilder = new CustomAttributeBuilder(typeof(DataMemberAttribute).GetConstructor(Type.EmptyTypes),
                    new object[0], new PropertyInfo[2]
                    {
                        typeof(DataMemberAttribute).GetProperty("Name"),
                        typeof(DataMemberAttribute).GetProperty("EmitDefaultValue")
                    }, new object[2] {name, false});
            fieldBuilder.SetCustomAttribute(customBuilder);
            return fieldBuilder;
        }

        protected void AddDataMemberAttribute(string typeName, FieldBuilder fieldBuilder, string name)
        {
            var customBuilder = new CustomAttributeBuilder(
                typeof(DataMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[2]
                {
                    typeof(DataMemberAttribute).GetProperty("Name"),
                    typeof(DataMemberAttribute).GetProperty("EmitDefaultValue")
                }, new object[2]
                {
                    typeName + "_" + name,
                    false
                });
            fieldBuilder.SetCustomAttribute(customBuilder);
        }

        protected EnumBuilder DefineEnum(string name)
        {
            var enumBuilder = moduleBuilder.DefineEnum(name, TypeAttributes.Public, typeof(int));
            AddDataContractEnumAttribute(enumBuilder);
            return enumBuilder;
        }

        private void AddDataContractEnumAttribute(EnumBuilder enumBuilder)
        {
            var customBuilder1 = new CustomAttributeBuilder(
                typeof(DataContractAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[1]
                {
                    typeof(DataContractAttribute).GetProperty("Namespace")
                }, new object[1] {"Camstar.WCF.ObjectStack"});
            enumBuilder.SetCustomAttribute(customBuilder1);
            var customBuilder2 =
                new CustomAttributeBuilder(typeof(SerializableAttribute).GetConstructor(Type.EmptyTypes),
                    new object[0]);
            enumBuilder.SetCustomAttribute(customBuilder2);
        }

        protected void DefineLiteral(
            EnumBuilder enumBuilder,
            string name,
            int number,
            string defaultValue,
            DCField field)
        {
            var fieldBuilder = enumBuilder.DefineLiteral(name, number);
            var customBuilder1 =
                new CustomAttributeBuilder(typeof(EnumMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
            fieldBuilder.SetCustomAttribute(customBuilder1);
            DCBuilderType dcBuilderType = dCTypeStore.GetDCBuilderType("EnumerationAttribute");
            if (dcBuilderType != null)
            {
                var customBuilder2 = new CustomAttributeBuilder(dcBuilderType.Type.GetConstructor(
                    new Type[1]
                    {
                        typeof(string)
                    }), new object[1] {defaultValue});
                fieldBuilder.SetCustomAttribute(customBuilder2);
            }

            if (field == null)
                return;
            AddMetadataAttribute(fieldBuilder, field);
        }

        private void AddMetadataAttribute(FieldBuilder fieldBuilder, DCField field)
        {
            DCBuilderType dcBuilderType = dCTypeStore.GetDCBuilderType("MetadataAttribute");
            if (dcBuilderType == null || field == null)
                return;
            var customBuilder = new CustomAttributeBuilder(dcBuilderType.Type.GetConstructor(
                new Type[11]
                {
                    typeof(string),
                    typeof(string),
                    typeof(bool),
                    typeof(bool),
                    typeof(bool),
                    typeof(string),
                    typeof(int),
                    typeof(bool),
                    typeof(bool),
                    typeof(bool),
                    typeof(string)
                }), new object[11]
            {
                field.Description,
                field.FieldTypeName,
                field.IsUserDefinedField,
                field.IsRequired,
                field.IsReadOnly,
                field.IsEnum ? field.EnumFieldTypeName : (object) field.TypeName,
                field.Label,
                field.CreateOnInitialize,
                field.IsList,
                field.HasSelVal,
                string.IsNullOrEmpty(field.DefaultValue) ? null : (object) field.DefaultValue
            });
            fieldBuilder.SetCustomAttribute(customBuilder);
        }
    }
}