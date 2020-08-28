using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Camstar.Api.Builder
{
    internal class AssemblyGenerator : AssemblyGeneratorBase
    {
        private readonly string _BaseNamespace;
        private readonly Assembly baseAssembly;

        public AssemblyGenerator(
            ModuleBuilder moduleBuilder,
            DCTypeStore dCTypeStore,
            string rootNamespace,
            Assembly baseAssembly,
            string baseNamespace)
            : base(rootNamespace, moduleBuilder, dCTypeStore)
        {
            this.baseAssembly = baseAssembly;
            _BaseNamespace = baseNamespace;
        }

        public void GenerateWorkspaceSet()
        {
            var enumBuilder =
                moduleBuilder.DefineEnum(nameSpacePrefix + "WorkspaceType", TypeAttributes.Public, typeof(int));
            foreach (ModelDataSet.WCFWorkspacesRow workspace in CDORequestor.CurrentRequestor.GetWorkspaces())
            {
                string str = workspace.Code;
                if (string.IsNullOrWhiteSpace(str))
                    str = workspace.Id.ToString();
                if (char.IsDigit(str.ToCharArray()[0]))
                    str = "_" + str;
                enumBuilder.DefineLiteral(str.ToUpper(), (object) workspace.Id).SetCustomAttribute(
                    CreateWorkspaceAttribute(workspace.Sequence, workspace.SupportedBy, workspace.Description,
                        workspace.Color));
            }

            enumBuilder.CreateType();
        }

        private CustomAttributeBuilder CreateWorkspaceAttribute(
            int sequence,
            string supportedBy,
            string description,
            string color)
        {
            return new CustomAttributeBuilder(typeof(WorkspaceAttribute).GetConstructor(Type.EmptyTypes), new object[0],
                new PropertyInfo[4]
                {
                    typeof(WorkspaceAttribute).GetProperty("Sequence"),
                    typeof(WorkspaceAttribute).GetProperty("SupportedBy"),
                    typeof(WorkspaceAttribute).GetProperty("Description"),
                    typeof(WorkspaceAttribute).GetProperty("Color")
                }, new object[4]
                {
                    sequence,
                    supportedBy,
                    description,
                    color
                });
        }

        public void GenerateSiteUserData()
        {
            List<ModelDataSet.UserRow> users = SiteInfoRequestor.CurrentRequestor.GetUsers();
            var enumBuilder =
                moduleBuilder.DefineEnum(nameSpacePrefix + "SiteUserType", TypeAttributes.Public, typeof(int));
            for (var index = 0; index < users.Count; ++index)
                enumBuilder.DefineLiteral("user_" + index, index).SetCustomAttribute(new CustomAttributeBuilder(
                    typeof(SiteUserAttribute).GetConstructor(new Type[3]
                    {
                        typeof(string),
                        typeof(bool),
                        typeof(bool)
                    }), new object[3]
                    {
                        (object) users[index].UserName,
                        (object) users[index].AllowUserMode,
                        (object) users[index].AllowSystemMode
                    }));
            enumBuilder.CreateType();
        }

        public void GenerateCommonTypes()
        {
            var type = baseAssembly.GetType(nameSpacePrefix + "Primitive`1");
            dCTypeStore.Add("DCObject", baseAssembly.GetType(nameSpacePrefix + "DCObject"), (TypeBuilder) null, true);
            dCTypeStore.Add("CDOObject", baseAssembly.GetType(nameSpacePrefix + "CDOObject"), (TypeBuilder) null, true);
            dCTypeStore.Add("BaseObjectRef", baseAssembly.GetType(nameSpacePrefix + "BaseObjectRef"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("ContainerRef", baseAssembly.GetType(nameSpacePrefix + "ContainerRef"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("NamedObjectRef", baseAssembly.GetType(nameSpacePrefix + "NamedObjectRef"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("RevisionedObjectRef", baseAssembly.GetType(nameSpacePrefix + "RevisionedObjectRef"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("SubentityRef", baseAssembly.GetType(nameSpacePrefix + "SubentityRef"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("NamedSubentityRef", baseAssembly.GetType(nameSpacePrefix + "NamedSubentityRef"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("QueryParameters", baseAssembly.GetType(nameSpacePrefix + "QueryParameters"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("QueryOptions", baseAssembly.GetType(nameSpacePrefix + "QueryOptions"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("ResultStatus", baseAssembly.GetType(nameSpacePrefix + "ResultStatus"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("RecordSet", baseAssembly.GetType(nameSpacePrefix + "RecordSet"), (TypeBuilder) null, true);
            dCTypeStore.Add("UserProfile", baseAssembly.GetType(nameSpacePrefix + "UserProfile"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("Info", baseAssembly.GetType(nameSpacePrefix + "Info"), (TypeBuilder) null, true);
            dCTypeStore.Add("Environment", baseAssembly.GetType(nameSpacePrefix + "Environment"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("EncryptedField", baseAssembly.GetType(nameSpacePrefix + "EncryptedField"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("PasswordFieldType", baseAssembly.GetType(nameSpacePrefix + "PasswordFieldType"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("MetadataAttribute", baseAssembly.GetType(nameSpacePrefix + "MetadataAttribute"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("EnumerationAttribute", baseAssembly.GetType(nameSpacePrefix + "EnumerationAttribute"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("WorkspaceAttribute", baseAssembly.GetType(nameSpacePrefix + "WorkspaceAttribute"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("Request", baseAssembly.GetType(_BaseNamespace + ".Request"), (TypeBuilder) null, true);
            dCTypeStore.Add("Result", baseAssembly.GetType(_BaseNamespace + ".Result"), (TypeBuilder) null, true);
            dCTypeStore.Add("Parameters", baseAssembly.GetType(_BaseNamespace + ".Parameters"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("Method", baseAssembly.GetType(_BaseNamespace + ".Method"), (TypeBuilder) null, true);
            dCTypeStore.Add("Integer", type.MakeGenericType(typeof(int)), (TypeBuilder) null, true);
            dCTypeStore.Add("Float", type.MakeGenericType(typeof(double)), (TypeBuilder) null, true);
            dCTypeStore.Add("Fixed", type.MakeGenericType(typeof(double)), (TypeBuilder) null, true);
            dCTypeStore.Add("String", type.MakeGenericType(typeof(string)), (TypeBuilder) null, true);
            dCTypeStore.Add("TimeStamp", type.MakeGenericType(typeof(DateTime)), (TypeBuilder) null, true);
            dCTypeStore.Add("Boolean", type.MakeGenericType(typeof(bool)), (TypeBuilder) null, true);
            dCTypeStore.Add("Decimal", type.MakeGenericType(typeof(decimal)), (TypeBuilder) null, true);
            dCTypeStore.Add("WCFServiceBase", baseAssembly.GetType("Camstar.WCF.Services.WCFServiceBase"),
                (TypeBuilder) null, true);
            dCTypeStore.Add("WCFService", baseAssembly.GetType("Camstar.WCF.Services.WCFService"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("IWCFService", baseAssembly.GetType("Camstar.WCF.Services.IWCFService"), (TypeBuilder) null,
                true);
            dCTypeStore.Add("ServiceBase", baseAssembly.GetType("Camstar.WCF.Service.ServiceBase"), (TypeBuilder) null,
                true);
        }

        public override void AddDC(DCType dCType)
        {
            if (dCType.IsEnum)
            {
                AddEnumeration(dCType);
            }
            else
            {
                DCBuilderType dcBuilderType = dCTypeStore.GetDCBuilderType(dCType.ParentName);
                if (dcBuilderType == null)
                {
                    dcBuilderType = dCTypeStore.GetDCBuilderType("CDOObject");
                    dCType.ParentName = "CDOObject";
                }

                var typeBuilder1 = DefineType(nameSpacePrefix + dCType.Name, dcBuilderType.Type);
                dCTypeStore.Add(dCType.Name, typeBuilder1.UnderlyingSystemType, typeBuilder1);
                AddKnownTypeAttribute(dCType, typeBuilder1, dcBuilderType);
                DCBuilderType dCBuilderType1 = dCTypeStore.GetDCBuilderType(dCType.ParentName + "_Info") ??
                                               dCTypeStore.GetDCBuilderType("Info");
                var typeBuilder2 = DefineType(nameSpacePrefix + dCType.Name + "_Info", dCBuilderType1.Type);
                dCTypeStore.Add(dCType.Name + "_Info", typeBuilder2.UnderlyingSystemType, typeBuilder2);
                AddKnownTypeAttribute(dCType, typeBuilder2, dCBuilderType1);
                DCBuilderType dCBuilderType2 = dCTypeStore.GetDCBuilderType(dCType.ParentName + "_Environment") ??
                                               dCTypeStore.GetDCBuilderType("Environment");
                var typeBuilder3 = DefineType(nameSpacePrefix + dCType.Name + "_Environment", dCBuilderType2.Type);
                dCTypeStore.Add(dCType.Name + "_Environment", typeBuilder3.UnderlyingSystemType, typeBuilder3);
                AddKnownTypeAttribute(dCType, typeBuilder3, dCBuilderType2);
            }
        }

        private void AddEnumeration(DCType dCType)
        {
            var type1 = baseAssembly.GetType(nameSpacePrefix + "Enumeration`2");
            var enumBuilder = DefineEnum(nameSpacePrefix + dCType.Name);
            var isEmptyEnum = true;
            List<DCField> fields = dCType.GetFields();
            var type2 = typeof(string);
            foreach (var field in fields)
            {
                type2 = dCTypeStore.GetDCBuilderType(field.EnumFieldTypeName).Type.GetGenericArguments()[0];
                int result;
                DefineLiteral(enumBuilder, field.Name,
                    int.TryParse(field.DefaultValue, out result) ? result : field.Name.GetHashCode(),
                    field.DefaultValue, field);
                isEmptyEnum = false;
            }

            var type3 = enumBuilder.CreateType();
            var type4 = type1.MakeGenericType(type3, type2);
            dCTypeStore.Add(dCType.Name, type4, (TypeBuilder) null, true, isEmptyEnum);
        }

        private void AddKnownTypeAttribute(
            DCType dCType,
            TypeBuilder typeBuilder,
            DCBuilderType dCBuilderType)
        {
            if (!dCType.IsSubentity || !(dCType.ParentName != "Subentity"))
                return;
            var customBuilder = new CustomAttributeBuilder(typeof(KnownTypeAttribute).GetConstructor(new Type[1]
            {
                typeof(Type)
            }), new object[1]
            {
                typeBuilder.UnderlyingSystemType
            });
            dCBuilderType.TypeBuilder.SetCustomAttribute(customBuilder);
        }
    }
}