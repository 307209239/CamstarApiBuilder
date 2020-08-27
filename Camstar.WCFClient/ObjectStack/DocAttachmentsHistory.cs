// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DocAttachmentsHistory
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
  public class DocAttachmentsHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_ParentDisplayName")]
    protected Primitive<string> _ParentDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_HistoryDetails")]
    protected DocAttachmentsHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_AttachmentsOwner")]
    protected BaseObjectRef _AttachmentsOwner;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_ObjectRev")]
    protected Primitive<string> _ObjectRev;
    [DataMember(EmitDefaultValue = false, Name = "DocAttachmentsHistory_ObjectName")]
    protected Primitive<string> _ObjectName;

    public override bool Equals(object obj)
    {
      return obj is DocAttachmentsHistory && object.Equals((object) this._ParentDisplayName, (object) ((DocAttachmentsHistory) obj)._ParentDisplayName) && (object.Equals((object) this._ObjectType, (object) ((DocAttachmentsHistory) obj)._ObjectType) && object.Equals((object) this._ExportImportKey, (object) ((DocAttachmentsHistory) obj)._ExportImportKey)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((DocAttachmentsHistory) obj)._HistoryDetails) && object.Equals((object) this._HistoryId, (object) ((DocAttachmentsHistory) obj)._HistoryId) && (object.Equals((object) this._AttachmentsOwner, (object) ((DocAttachmentsHistory) obj)._AttachmentsOwner) && object.Equals((object) this._ObjectRev, (object) ((DocAttachmentsHistory) obj)._ObjectRev))) && object.Equals((object) this._ObjectName, (object) ((DocAttachmentsHistory) obj)._ObjectName) && base.Equals(obj);
    }

    public Primitive<string> ParentDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentDisplayName));
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

    public DocAttachmentsHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public BaseObjectRef AttachmentsOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsOwner), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (AttachmentsOwner));
      }
    }

    public Primitive<string> ObjectRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectRev));
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
