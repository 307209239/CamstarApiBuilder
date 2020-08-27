// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrier
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
  public class EmptyCarrier : ChangeQty
  {
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_LossReason")]
    protected NamedObjectRef _LossReason;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_ServiceDetails")]
    protected EmptyCarrierDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_CloseWhenZero")]
    protected new Primitive<bool> _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Container")]
    protected new ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is EmptyCarrier && object.Equals((object) this._LossReason, (object) ((EmptyCarrier) obj)._LossReason) && (object.Equals((object) this._Carrier, (object) ((EmptyCarrier) obj)._Carrier) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((EmptyCarrier) obj)._ServiceDetails)) && (object.Equals((object) this._CloseWhenZero, (object) ((EmptyCarrier) obj)._CloseWhenZero) && object.Equals((object) this._Container, (object) ((EmptyCarrier) obj)._Container)) && base.Equals(obj);
    }

    public NamedObjectRef LossReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LossReason));
      }
    }

    public new NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public EmptyCarrierDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (EmptyCarrierDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Primitive<bool> CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }
  }
}
