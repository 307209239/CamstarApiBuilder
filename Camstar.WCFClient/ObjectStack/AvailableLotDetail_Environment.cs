// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AvailableLotDetail_Environment
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
  public class AvailableLotDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_EventLot")]
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, false, "SubentityRef", 1051083, false, false, false, null)]
    protected Environment _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_Quantity")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1048712, false, false, false, null)]
    protected Environment _Quantity;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_QuantityAssigned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052022, false, false, false, null)]
    protected Environment _QuantityAssigned;
    [Metadata("LotDispositionStatus", "LotDispositionStatusEnum", false, false, false, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_Status")]
    protected Environment _Status;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052030, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_QuantityRemaining")]
    protected Environment _QuantityRemaining;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052029, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_QuantityReconciled")]
    protected Environment _QuantityReconciled;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_LotHoldRecommended")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052028, false, false, false, "0")]
    protected Environment _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048625, false, false, false, null)]
    protected Environment _ProductName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_UOMName")]
    protected Environment _UOMName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049481, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_Lot")]
    protected Environment _Lot;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AvailableLotDetail_Environment_StatusName")]
    protected Environment _StatusName;

    public Environment EventLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventLot));
      }
    }

    public Environment Quantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Quantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Quantity));
      }
    }

    public Environment QuantityAssigned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityAssigned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityAssigned));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment QuantityRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityRemaining), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityRemaining));
      }
    }

    public Environment QuantityReconciled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityReconciled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityReconciled));
      }
    }

    public Environment LotHoldRecommended
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotHoldRecommended), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotHoldRecommended));
      }
    }

    public Environment ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductName));
      }
    }

    public Environment UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOMName));
      }
    }

    public Environment Lot
    {
      [param: In] set
      {
        this.PropertySet(nameof (Lot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Lot));
      }
    }

    public Environment StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusName));
      }
    }
  }
}
