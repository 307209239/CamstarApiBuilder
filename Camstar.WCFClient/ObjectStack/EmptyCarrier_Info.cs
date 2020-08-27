// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrier_Info
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
  public class EmptyCarrier_Info : ChangeQty_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Info_LossReason")]
    protected Info _LossReason;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Info_ServiceDetails")]
    protected EmptyCarrierDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Info_CloseWhenZero")]
    protected new Info _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Info_Container")]
    protected new Info _Container;

    public Info LossReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LossReason));
      }
    }

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public EmptyCarrierDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (EmptyCarrierDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Info CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }
  }
}
