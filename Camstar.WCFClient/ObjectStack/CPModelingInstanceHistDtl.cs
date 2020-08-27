// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CPModelingInstanceHistDtl
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
  public class CPModelingInstanceHistDtl : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_ObjectTypeName")]
    protected Enumeration<MaintainableObjectEnum, string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_IsROR")]
    protected Primitive<bool> _IsROR;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_IsReference")]
    protected Primitive<bool> _IsReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_AddedToPackageGMT")]
    protected Primitive<DateTime> _AddedToPackageGMT;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceHistDtl_ObjectName")]
    protected Primitive<string> _ObjectName;

    public override bool Equals(object obj)
    {
      return obj is CPModelingInstanceHistDtl && object.Equals((object) this._ObjectTypeName, (object) ((CPModelingInstanceHistDtl) obj)._ObjectTypeName) && (object.Equals((object) this._ExportImportKey, (object) ((CPModelingInstanceHistDtl) obj)._ExportImportKey) && object.Equals((object) this._Sequence, (object) ((CPModelingInstanceHistDtl) obj)._Sequence)) && (object.Equals((object) this._IsROR, (object) ((CPModelingInstanceHistDtl) obj)._IsROR) && object.Equals((object) this._IsReference, (object) ((CPModelingInstanceHistDtl) obj)._IsReference) && (object.Equals((object) this._HistoryId, (object) ((CPModelingInstanceHistDtl) obj)._HistoryId) && object.Equals((object) this._ObjectType, (object) ((CPModelingInstanceHistDtl) obj)._ObjectType))) && (object.Equals((object) this._ObjectInstanceId, (object) ((CPModelingInstanceHistDtl) obj)._ObjectInstanceId) && object.Equals((object) this._AddedToPackageGMT, (object) ((CPModelingInstanceHistDtl) obj)._AddedToPackageGMT) && (object.Equals((object) this._Revision, (object) ((CPModelingInstanceHistDtl) obj)._Revision) && object.Equals((object) this._ObjectName, (object) ((CPModelingInstanceHistDtl) obj)._ObjectName))) && base.Equals(obj);
    }

    public Enumeration<MaintainableObjectEnum, string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Enumeration<MaintainableObjectEnum, string>) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public Primitive<bool> IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsROR));
      }
    }

    public Primitive<bool> IsReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsReference));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Primitive<DateTime> AddedToPackageGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddedToPackageGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (AddedToPackageGMT));
      }
    }

    public Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
      }
    }
  }
}
