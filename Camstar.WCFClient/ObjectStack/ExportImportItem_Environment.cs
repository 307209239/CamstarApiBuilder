// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExportImportItem_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ExportImportItem_Environment : ObjectAlternateKey_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Environment_ObjectType")]
    [Metadata("ExportableObject", "ExportableObjectEnum", false, false, false, "Integer", 1050797, false, false, true, null)]
    protected new Environment _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Environment_ObjectTypeName")]
    [Metadata("ExportableObjectName", "ExportableObjectEnum", false, false, false, "String", 1050800, false, false, true, null)]
    protected new Environment _ObjectTypeName;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1050774, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Environment_ObjectName")]
    protected new Environment _ObjectName;
    [Metadata("Generic String", "", false, false, false, "String", 1050799, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Environment_ObjectInstanceId")]
    protected new Environment _ObjectInstanceId;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Environment_Revision")]
    protected new Environment _Revision;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExportImportItem_Environment_IsROR")]
    protected new Environment _IsROR;

    public new Environment ObjectType
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

    public new Environment ObjectTypeName
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

    public new Environment ObjectName
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

    public new Environment ObjectInstanceId
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

    public new Environment Revision
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

    public new Environment IsROR
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
