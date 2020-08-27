// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDispositionHistoryDetail
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
  public class EventDispositionHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_EventFailureHistoryDetails")]
    protected EventFailureHistoryDetail[] _EventFailureHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionHistoryDetail_Lot")]
    protected Primitive<string> _Lot;

    public override bool Equals(object obj)
    {
      return obj is EventDispositionHistoryDetail && object.Equals((object) this._Comments, (object) ((EventDispositionHistoryDetail) obj)._Comments) && (object.Equals((object) this._ExportImportKey, (object) ((EventDispositionHistoryDetail) obj)._ExportImportKey) && this.CompareArrays((Array) this._EventFailureHistoryDetails, (Array) ((EventDispositionHistoryDetail) obj)._EventFailureHistoryDetails)) && (object.Equals((object) this._Disposition, (object) ((EventDispositionHistoryDetail) obj)._Disposition) && object.Equals((object) this._HistoryId, (object) ((EventDispositionHistoryDetail) obj)._HistoryId) && (object.Equals((object) this._Qty, (object) ((EventDispositionHistoryDetail) obj)._Qty) && object.Equals((object) this._Lot, (object) ((EventDispositionHistoryDetail) obj)._Lot))) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
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

    public EventFailureHistoryDetail[] EventFailureHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureHistoryDetail[]) this.PropertyGet(nameof (EventFailureHistoryDetails));
      }
    }

    public NamedObjectRef Disposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Disposition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Disposition));
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

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }

    public Primitive<string> Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Lot));
      }
    }
  }
}
