// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionDetail_Environment
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
  public class DispositionDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, true, "SubentityRef", 1051083, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_EventLot")]
    protected Environment _EventLot;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_QuantityConforming")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052105, false, false, false, null)]
    protected Environment _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_HistorySummary")]
    [Metadata("Complete Activity Disposition History", "CompleteActivityDispHistory", false, false, true, "SubentityRef", 1049593, false, false, false, null)]
    protected Environment _HistorySummary;
    [Metadata("Disposition Data", "DispositionData", false, false, false, "SubentityRef", 1051588, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_DispositionData")]
    protected Environment _DispositionData;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052022, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_QuantityAssigned")]
    protected Environment _QuantityAssigned;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_QuantityDispositioned")]
    protected Environment _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_LotQuantity")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1048836, false, false, false, null)]
    protected Environment _LotQuantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_UOMName")]
    [Metadata("Generic String", "", false, false, true, "String", 1048629, false, false, false, null)]
    protected Environment _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDetail_Environment_Product")]
    protected Environment _Product;

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

    public Environment QuantityConforming
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityConforming), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityConforming));
      }
    }

    public Environment HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Environment DispositionData
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispositionData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DispositionData));
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

    public Environment QuantityDispositioned
    {
      [param: In] set
      {
        this.PropertySet(nameof (QuantityDispositioned), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QuantityDispositioned));
      }
    }

    public Environment LotQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotQuantity));
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

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
      }
    }
  }
}
