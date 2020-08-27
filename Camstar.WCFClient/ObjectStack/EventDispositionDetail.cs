// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDispositionDetail
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
  public class EventDispositionDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_EventFailureDetails")]
    protected EventFailureDetail[] _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_EventDisposition")]
    protected SubentityRef _EventDisposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Disposition")]
    protected NamedObjectRef _Disposition;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_ApplyEntireQty")]
    protected Primitive<bool> _ApplyEntireQty;
    [DataMember(EmitDefaultValue = false, Name = "EventDispositionDetail_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is EventDispositionDetail && object.Equals((object) this._Comments, (object) ((EventDispositionDetail) obj)._Comments) && (this.CompareArrays((Array) this._EventFailureDetails, (Array) ((EventDispositionDetail) obj)._EventFailureDetails) && object.Equals((object) this._EventDisposition, (object) ((EventDispositionDetail) obj)._EventDisposition)) && (object.Equals((object) this._Disposition, (object) ((EventDispositionDetail) obj)._Disposition) && object.Equals((object) this._ApplyEntireQty, (object) ((EventDispositionDetail) obj)._ApplyEntireQty) && object.Equals((object) this._Qty, (object) ((EventDispositionDetail) obj)._Qty)) && base.Equals(obj);
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

    public EventFailureDetail[] EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail[]) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public SubentityRef EventDisposition
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDisposition), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventDisposition));
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

    public Primitive<bool> ApplyEntireQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplyEntireQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApplyEntireQty));
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
  }
}
