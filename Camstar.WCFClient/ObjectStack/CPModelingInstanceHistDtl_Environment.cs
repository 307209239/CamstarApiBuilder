// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CPModelingInstanceHistDtl_Environment
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
  public class CPModelingInstanceHistDtl_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("MaintainableObjectName", "MaintainableObjectEnum", false, false, true, "String", 1050776, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_ObjectTypeName")]
    protected Environment _ObjectTypeName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_Sequence")]
    protected Environment _Sequence;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053259, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_IsROR")]
    protected Environment _IsROR;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053258, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_IsReference")]
    protected Environment _IsReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1050572, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_ObjectType")]
    protected Environment _ObjectType;
    [Metadata("Generic String", "", false, false, true, "String", 1050773, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 16778010, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_AddedToPackageGMT")]
    protected Environment _AddedToPackageGMT;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_Revision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1048710, false, false, false, null)]
    protected Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Environment_ObjectName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050774, false, false, false, null)]
    protected Environment _ObjectName;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
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

    public Environment IsReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsReference));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

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

    public Environment AddedToPackageGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddedToPackageGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AddedToPackageGMT));
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
  }
}
