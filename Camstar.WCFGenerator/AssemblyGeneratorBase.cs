// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.AssemblyGeneratorBase
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace Camstar.WCF.Generator
{
  internal abstract class AssemblyGeneratorBase
  {
    protected string nameSpacePrefix;
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
    protected ModuleBuilder moduleBuilder;
    protected DCTypeStore dCTypeStore;
    protected bool _IsSilverlight;

    public AssemblyGeneratorBase(
      string nameSpace,
      ModuleBuilder moduleBuilder,
      DCTypeStore dCTypeStore)
    {
      this.nameSpacePrefix = nameSpace + ".";
      this.moduleBuilder = moduleBuilder;
      this.dCTypeStore = dCTypeStore;
    }

    public virtual void AddDC(DCType dCType)
    {
      this.dCTypeStore.Add(dCType.Name, typeof (string), (TypeBuilder) null);
    }

    protected TypeBuilder DefineType(string name, Type parentType)
    {
      TypeBuilder typeBuilder = this.moduleBuilder.DefineType(name, TypeAttributes.Public | TypeAttributes.BeforeFieldInit, parentType);
      this.AddDataContractAttribute(typeBuilder);
      return typeBuilder;
    }

    protected ConstructorBuilder DefineTypeConstructor(
      TypeBuilder typeBuilder,
      Type parentType)
    {
      ConstructorBuilder constructorBuilder = typeBuilder.DefineConstructor(MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName, CallingConventions.Standard, (Type[]) null);
      if (parentType == (Type) null)
        parentType = typeof (object);
      ILGenerator ilGenerator = constructorBuilder.GetILGenerator();
      ilGenerator.Emit(OpCodes.Ldarg_0);
      ilGenerator.Emit(OpCodes.Call, parentType.GetConstructor(Type.EmptyTypes));
      ilGenerator.Emit(OpCodes.Ret);
      return constructorBuilder;
    }

    private void AddDataContractAttribute(TypeBuilder typeBuilder)
    {
      CustomAttributeBuilder customBuilder1 = new CustomAttributeBuilder(typeof (DataContractAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[1]
      {
        typeof (DataContractAttribute).GetProperty("Namespace")
      }, new object[1]{ (object) "Camstar.WCF.ObjectStack" });
      typeBuilder.SetCustomAttribute(customBuilder1);
      CustomAttributeBuilder customBuilder2 = new CustomAttributeBuilder(typeof (SerializableAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
      typeBuilder.SetCustomAttribute(customBuilder2);
    }

    protected FieldBuilder DefineField(
      TypeBuilder typeBuilder,
      string name,
      Type type,
      DCField field,
      bool isPrivate)
    {
      FieldBuilder fieldBuilder = typeBuilder.DefineField((isPrivate ? "_" : "") + name, type, !isPrivate || this._IsSilverlight ? FieldAttributes.Public : FieldAttributes.Family);
      if (this._IsSilverlight)
      {
        CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(typeof (EditorBrowsableAttribute).GetConstructor(new Type[1]
        {
          typeof (EditorBrowsableState)
        }), new object[1]
        {
          (object) EditorBrowsableState.Never
        });
        fieldBuilder.SetCustomAttribute(customBuilder);
      }
      this.AddMetadataAttribute(fieldBuilder, field);
      this.AddDataMemberAttribute(typeBuilder.Name, fieldBuilder, name);
      return fieldBuilder;
    }

    protected FieldBuilder DefineField(
      TypeBuilder typeBuilder,
      string name,
      Type type,
      bool isPrivate)
    {
      return this.DefineField(typeBuilder, name, type, (DCField) null, isPrivate);
    }

    protected PropertyBuilder DefineProperty(
      TypeBuilder typeBuilder,
      string name,
      Type type)
    {
      Type type1 = this.dCTypeStore.GetDCBuilderType("DCObject").Type;
      PropertyBuilder propertyBuilder = typeBuilder.DefineProperty(name, PropertyAttributes.HasDefault, CallingConventions.HasThis, type, (Type[]) null, (Type[]) null, (Type[]) null, (Type[][]) null, (Type[][]) null);
      MethodAttributes attributes = MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName;
      MethodBuilder mdBuilder1 = typeBuilder.DefineMethod("set_" + name, attributes, (Type) null, new Type[1]
      {
        type
      });
      ILGenerator ilGenerator1 = mdBuilder1.GetILGenerator();
      ilGenerator1.Emit(OpCodes.Ldarg_0);
      ilGenerator1.Emit(OpCodes.Ldstr, name);
      ilGenerator1.Emit(OpCodes.Ldarg_1);
      ilGenerator1.Emit(OpCodes.Call, type1.GetMethod("PropertySet", BindingFlags.Instance | BindingFlags.NonPublic));
      ilGenerator1.Emit(OpCodes.Ret);
      propertyBuilder.SetSetMethod(mdBuilder1);
      MethodBuilder mdBuilder2 = typeBuilder.DefineMethod("get_" + name, attributes, type, (Type[]) null);
      ILGenerator ilGenerator2 = mdBuilder2.GetILGenerator();
      ilGenerator2.DeclareLocal(type);
      ilGenerator2.Emit(OpCodes.Ldarg_0);
      ilGenerator2.Emit(OpCodes.Ldstr, name);
      ilGenerator2.Emit(OpCodes.Call, type1.GetMethod("PropertyGet", BindingFlags.Instance | BindingFlags.NonPublic));
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
      return this.DefineProperty(typeBuilder, name, type);
    }

    protected FieldBuilder DefineUniqueField(
      TypeBuilder typeBuilder,
      string name,
      Type type,
      bool isPrivate)
    {
      FieldBuilder fieldBuilder = typeBuilder.DefineField((isPrivate ? "_" : "") + name, type, !isPrivate || this._IsSilverlight ? FieldAttributes.Public : FieldAttributes.Family);
      CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(typeof (DataMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[1]
      {
        typeof (DataMemberAttribute).GetProperty("EmitDefaultValue")
      }, new object[1]{ (object) false });
      if (isPrivate)
        customBuilder = new CustomAttributeBuilder(typeof (DataMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[2]
        {
          typeof (DataMemberAttribute).GetProperty("Name"),
          typeof (DataMemberAttribute).GetProperty("EmitDefaultValue")
        }, new object[2]{ (object) name, (object) false });
      fieldBuilder.SetCustomAttribute(customBuilder);
      return fieldBuilder;
    }

    protected void AddDataMemberAttribute(string typeName, FieldBuilder fieldBuilder, string name)
    {
      CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(typeof (DataMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[2]
      {
        typeof (DataMemberAttribute).GetProperty("Name"),
        typeof (DataMemberAttribute).GetProperty("EmitDefaultValue")
      }, new object[2]
      {
        (object) (typeName + "_" + name),
        (object) false
      });
      fieldBuilder.SetCustomAttribute(customBuilder);
    }

    protected EnumBuilder DefineEnum(string name)
    {
      EnumBuilder enumBuilder = this.moduleBuilder.DefineEnum(name, TypeAttributes.Public, typeof (int));
      this.AddDataContractEnumAttribute(enumBuilder);
      return enumBuilder;
    }

    private void AddDataContractEnumAttribute(EnumBuilder enumBuilder)
    {
      CustomAttributeBuilder customBuilder1 = new CustomAttributeBuilder(typeof (DataContractAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[1]
      {
        typeof (DataContractAttribute).GetProperty("Namespace")
      }, new object[1]{ (object) "Camstar.WCF.ObjectStack" });
      enumBuilder.SetCustomAttribute(customBuilder1);
      CustomAttributeBuilder customBuilder2 = new CustomAttributeBuilder(typeof (SerializableAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
      enumBuilder.SetCustomAttribute(customBuilder2);
    }

    protected void DefineLiteral(
      EnumBuilder enumBuilder,
      string name,
      int number,
      string defaultValue,
      DCField field)
    {
      FieldBuilder fieldBuilder = enumBuilder.DefineLiteral(name, (object) number);
      CustomAttributeBuilder customBuilder1 = new CustomAttributeBuilder(typeof (EnumMemberAttribute).GetConstructor(Type.EmptyTypes), new object[0]);
      fieldBuilder.SetCustomAttribute(customBuilder1);
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType("EnumerationAttribute");
      if (dcBuilderType != null)
      {
        CustomAttributeBuilder customBuilder2 = new CustomAttributeBuilder(dcBuilderType.Type.GetConstructor(new Type[1]
        {
          typeof (string)
        }), new object[1]{ (object) defaultValue });
        fieldBuilder.SetCustomAttribute(customBuilder2);
      }
      if (field == null)
        return;
      this.AddMetadataAttribute(fieldBuilder, field);
    }

    private void AddMetadataAttribute(FieldBuilder fieldBuilder, DCField field)
    {
      DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType("MetadataAttribute");
      if (dcBuilderType == null || field == null)
        return;
      CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(dcBuilderType.Type.GetConstructor(new Type[11]
      {
        typeof (string),
        typeof (string),
        typeof (bool),
        typeof (bool),
        typeof (bool),
        typeof (string),
        typeof (int),
        typeof (bool),
        typeof (bool),
        typeof (bool),
        typeof (string)
      }), new object[11]
      {
        (object) field.Description,
        (object) field.FieldTypeName,
        (object) field.IsUserDefinedField,
        (object) field.IsRequired,
        (object) field.IsReadOnly,
        field.IsEnum ? (object) field.EnumFieldTypeName : (object) field.TypeName,
        (object) field.Label,
        (object) field.CreateOnInitialize,
        (object) field.IsList,
        (object) field.HasSelVal,
        string.IsNullOrEmpty(field.DefaultValue) ? (object) (string) null : (object) field.DefaultValue
      });
      fieldBuilder.SetCustomAttribute(customBuilder);
    }
  }
}
