// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectAlternateKey_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ExportImportItem_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ImportContent_Environment))]
  [KnownType(typeof (ObjectReferencesInfo_Environment))]
  [Serializable]
  public class ObjectAlternateKey_Environment : ServiceData_Environment
  {
    [Metadata("CDOType", "", false, false, true, "Integer", 1050797, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Environment_ObjectType")]
    protected Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Environment_ObjectName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, true, "String", 1050774, false, false, false, null)]
    protected Environment _ObjectName;
    [Metadata("Generic String", "", false, false, true, "String", 1050799, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1050800, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Environment_Revision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1048710, false, false, false, null)]
    protected Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "ObjectAlternateKey_Environment_IsROR")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, true, "Boolean", 1048708, false, false, false, "0")]
    protected Environment _IsROR;

    public Environment ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Environment ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Environment ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public Environment IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsROR));
      }
    }
  }
}
