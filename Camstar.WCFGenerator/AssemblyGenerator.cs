// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Generator.AssemblyGenerator
// Assembly: Camstar.WCFGenerator, Version=7.8.7004.31022, Culture=neutral, PublicKeyToken=null
// MVID: 91343708-C770-4337-A57D-62D505E9E44B
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFGenerator.dll

using Camstar.WCF.Generator.Helper;
using Camstar.WCF.Generator.ObjectModel;
using Camstar.WCF.ObjectStack;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.Serialization;

namespace Camstar.WCF.Generator
{
  internal class AssemblyGenerator : AssemblyGeneratorBase
  {
    private string _BaseNamespace;
    private Assembly baseAssembly;

    public AssemblyGenerator(
      ModuleBuilder moduleBuilder,
      DCTypeStore dCTypeStore,
      string rootNamespace,
      Assembly baseAssembly,
      string baseNamespace)
      : base(rootNamespace, moduleBuilder, dCTypeStore)
    {
      this.baseAssembly = baseAssembly;
      this._BaseNamespace = baseNamespace;
    }

    public void GenerateWorkspaceSet()
    {
      EnumBuilder enumBuilder = this.moduleBuilder.DefineEnum(this.nameSpacePrefix + "WorkspaceType", TypeAttributes.Public, typeof (int));
      foreach (ModelDataSet.WCFWorkspacesRow workspace in CDORequestor.CurrentRequestor.GetWorkspaces())
      {
        string str = workspace.Code;
        if (string.IsNullOrWhiteSpace(str))
          str = workspace.Id.ToString();
        if (char.IsDigit(str.ToCharArray()[0]))
          str = "_" + str;
        enumBuilder.DefineLiteral(str.ToUpper(), (object) workspace.Id).SetCustomAttribute(this.CreateWorkspaceAttribute(workspace.Sequence, workspace.SupportedBy, workspace.Description, workspace.Color));
      }
      enumBuilder.CreateType();
    }

    private CustomAttributeBuilder CreateWorkspaceAttribute(
      int sequence,
      string supportedBy,
      string description,
      string color)
    {
      return new CustomAttributeBuilder(typeof (WorkspaceAttribute).GetConstructor(Type.EmptyTypes), new object[0], new PropertyInfo[4]
      {
        typeof (WorkspaceAttribute).GetProperty("Sequence"),
        typeof (WorkspaceAttribute).GetProperty("SupportedBy"),
        typeof (WorkspaceAttribute).GetProperty("Description"),
        typeof (WorkspaceAttribute).GetProperty("Color")
      }, new object[4]
      {
        (object) sequence,
        (object) supportedBy,
        (object) description,
        (object) color
      });
    }

    public void GenerateSiteUserData()
    {
      List<ModelDataSet.UserRow> users = SiteInfoRequestor.CurrentRequestor.GetUsers();
      EnumBuilder enumBuilder = this.moduleBuilder.DefineEnum(this.nameSpacePrefix + "SiteUserType", TypeAttributes.Public, typeof (int));
      for (int index = 0; index < users.Count; ++index)
        enumBuilder.DefineLiteral("user_" + (object) index, (object) index).SetCustomAttribute(new CustomAttributeBuilder(typeof (SiteUserAttribute).GetConstructor(new Type[3]
        {
          typeof (string),
          typeof (bool),
          typeof (bool)
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
      Type type = this.baseAssembly.GetType(this.nameSpacePrefix + "Primitive`1");
      this.dCTypeStore.Add("DCObject", this.baseAssembly.GetType(this.nameSpacePrefix + "DCObject"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("CDOObject", this.baseAssembly.GetType(this.nameSpacePrefix + "CDOObject"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("BaseObjectRef", this.baseAssembly.GetType(this.nameSpacePrefix + "BaseObjectRef"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("ContainerRef", this.baseAssembly.GetType(this.nameSpacePrefix + "ContainerRef"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("NamedObjectRef", this.baseAssembly.GetType(this.nameSpacePrefix + "NamedObjectRef"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("RevisionedObjectRef", this.baseAssembly.GetType(this.nameSpacePrefix + "RevisionedObjectRef"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("SubentityRef", this.baseAssembly.GetType(this.nameSpacePrefix + "SubentityRef"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("NamedSubentityRef", this.baseAssembly.GetType(this.nameSpacePrefix + "NamedSubentityRef"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("QueryParameters", this.baseAssembly.GetType(this.nameSpacePrefix + "QueryParameters"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("QueryOptions", this.baseAssembly.GetType(this.nameSpacePrefix + "QueryOptions"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("ResultStatus", this.baseAssembly.GetType(this.nameSpacePrefix + "ResultStatus"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("RecordSet", this.baseAssembly.GetType(this.nameSpacePrefix + "RecordSet"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("UserProfile", this.baseAssembly.GetType(this.nameSpacePrefix + "UserProfile"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Info", this.baseAssembly.GetType(this.nameSpacePrefix + "Info"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Environment", this.baseAssembly.GetType(this.nameSpacePrefix + "Environment"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("EncryptedField", this.baseAssembly.GetType(this.nameSpacePrefix + "EncryptedField"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("PasswordFieldType", this.baseAssembly.GetType(this.nameSpacePrefix + "PasswordFieldType"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("MetadataAttribute", this.baseAssembly.GetType(this.nameSpacePrefix + "MetadataAttribute"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("EnumerationAttribute", this.baseAssembly.GetType(this.nameSpacePrefix + "EnumerationAttribute"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("WorkspaceAttribute", this.baseAssembly.GetType(this.nameSpacePrefix + "WorkspaceAttribute"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Request", this.baseAssembly.GetType(this._BaseNamespace + ".Request"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Result", this.baseAssembly.GetType(this._BaseNamespace + ".Result"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Parameters", this.baseAssembly.GetType(this._BaseNamespace + ".Parameters"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Method", this.baseAssembly.GetType(this._BaseNamespace + ".Method"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Integer", type.MakeGenericType(typeof (int)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Float", type.MakeGenericType(typeof (double)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Fixed", type.MakeGenericType(typeof (double)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("String", type.MakeGenericType(typeof (string)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("TimeStamp", type.MakeGenericType(typeof (DateTime)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Boolean", type.MakeGenericType(typeof (bool)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("Decimal", type.MakeGenericType(typeof (Decimal)), (TypeBuilder) null, true);
      this.dCTypeStore.Add("WCFServiceBase", this.baseAssembly.GetType("Camstar.WCF.Services.WCFServiceBase"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("WCFService", this.baseAssembly.GetType("Camstar.WCF.Services.WCFService"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("IWCFService", this.baseAssembly.GetType("Camstar.WCF.Services.IWCFService"), (TypeBuilder) null, true);
      this.dCTypeStore.Add("ServiceBase", this.baseAssembly.GetType("Camstar.WCF.Service.ServiceBase"), (TypeBuilder) null, true);
    }

    public override void AddDC(DCType dCType)
    {
      if (dCType.IsEnum)
      {
        this.AddEnumeration(dCType);
      }
      else
      {
        DCBuilderType dcBuilderType = this.dCTypeStore.GetDCBuilderType(dCType.ParentName);
        if (dcBuilderType == null)
        {
          dcBuilderType = this.dCTypeStore.GetDCBuilderType("CDOObject");
          dCType.ParentName = "CDOObject";
        }
        TypeBuilder typeBuilder1 = this.DefineType(this.nameSpacePrefix + dCType.Name, dcBuilderType.Type);
        this.dCTypeStore.Add(dCType.Name, typeBuilder1.UnderlyingSystemType, typeBuilder1);
        this.AddKnownTypeAttribute(dCType, typeBuilder1, dcBuilderType);
        DCBuilderType dCBuilderType1 = this.dCTypeStore.GetDCBuilderType(dCType.ParentName + "_Info") ?? this.dCTypeStore.GetDCBuilderType("Info");
        TypeBuilder typeBuilder2 = this.DefineType(this.nameSpacePrefix + dCType.Name + "_Info", dCBuilderType1.Type);
        this.dCTypeStore.Add(dCType.Name + "_Info", typeBuilder2.UnderlyingSystemType, typeBuilder2);
        this.AddKnownTypeAttribute(dCType, typeBuilder2, dCBuilderType1);
        DCBuilderType dCBuilderType2 = this.dCTypeStore.GetDCBuilderType(dCType.ParentName + "_Environment") ?? this.dCTypeStore.GetDCBuilderType("Environment");
        TypeBuilder typeBuilder3 = this.DefineType(this.nameSpacePrefix + dCType.Name + "_Environment", dCBuilderType2.Type);
        this.dCTypeStore.Add(dCType.Name + "_Environment", typeBuilder3.UnderlyingSystemType, typeBuilder3);
        this.AddKnownTypeAttribute(dCType, typeBuilder3, dCBuilderType2);
      }
    }

    private void AddEnumeration(DCType dCType)
    {
      Type type1 = this.baseAssembly.GetType(this.nameSpacePrefix + "Enumeration`2");
      EnumBuilder enumBuilder = this.DefineEnum(this.nameSpacePrefix + dCType.Name);
      bool isEmptyEnum = true;
      List<DCField> fields = dCType.GetFields();
      Type type2 = typeof (string);
      foreach (DCField field in fields)
      {
        type2 = this.dCTypeStore.GetDCBuilderType(field.EnumFieldTypeName).Type.GetGenericArguments()[0];
        int result;
        this.DefineLiteral(enumBuilder, field.Name, int.TryParse(field.DefaultValue, out result) ? result : field.Name.GetHashCode(), field.DefaultValue, field);
        isEmptyEnum = false;
      }
      Type type3 = enumBuilder.CreateType();
      Type type4 = type1.MakeGenericType(type3, type2);
      this.dCTypeStore.Add(dCType.Name, type4, (TypeBuilder) null, true, isEmptyEnum);
    }

    private void AddKnownTypeAttribute(
      DCType dCType,
      TypeBuilder typeBuilder,
      DCBuilderType dCBuilderType)
    {
      if (!dCType.IsSubentity || !(dCType.ParentName != "Subentity"))
        return;
      CustomAttributeBuilder customBuilder = new CustomAttributeBuilder(typeof (KnownTypeAttribute).GetConstructor(new Type[1]
      {
        typeof (Type)
      }), new object[1]
      {
        (object) typeBuilder.UnderlyingSystemType
      });
      dCBuilderType.TypeBuilder.SetCustomAttribute(customBuilder);
    }
  }
}
