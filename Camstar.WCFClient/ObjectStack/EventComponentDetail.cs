// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventComponentDetail
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
  public class EventComponentDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_EventComponent")]
    protected SubentityRef _EventComponent;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_Lot")]
    protected Primitive<string> _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventComponentDetail_ProductRev")]
    protected Primitive<string> _ProductRev;

    public override bool Equals(object obj)
    {
      return obj is EventComponentDetail && object.Equals((object) this._EventComponent, (object) ((EventComponentDetail) obj)._EventComponent) && (object.Equals((object) this._Lot, (object) ((EventComponentDetail) obj)._Lot) && object.Equals((object) this._ProductName, (object) ((EventComponentDetail) obj)._ProductName)) && object.Equals((object) this._ProductRev, (object) ((EventComponentDetail) obj)._ProductRev) && base.Equals(obj);
    }

    public SubentityRef EventComponent
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventComponent), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventComponent));
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

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }
  }
}
