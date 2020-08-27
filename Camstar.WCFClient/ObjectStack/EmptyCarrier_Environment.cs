// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrier_Environment
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
  public class EmptyCarrier_Environment : ChangeQty_Environment
  {
    [Metadata("The user code for loss reason.", "LossReason", false, true, false, "NamedObjectRef", 1051927, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Environment_LossReason")]
    protected Environment _LossReason;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Environment_Carrier")]
    protected new Environment _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Environment_ServiceDetails")]
    [Metadata("Details of the EmptyCarrier.", "EmptyCarrierDetails", false, false, true, "EmptyCarrierDetails", 1049662, false, true, false, null)]
    protected EmptyCarrierDetails_Environment _ServiceDetails;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049342, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Environment_CloseWhenZero")]
    protected new Environment _CloseWhenZero;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrier_Environment_Container")]
    protected new Environment _Container;

    public Environment LossReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (LossReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LossReason));
      }
    }

    public new Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public EmptyCarrierDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (EmptyCarrierDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Environment CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }
  }
}
