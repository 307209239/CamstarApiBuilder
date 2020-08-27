// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionDataChanges_Environment
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
  public class DispositionDataChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_EventFailures")]
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, false, "SubentityRef", 1052084, false, true, false, null)]
    protected Environment _EventFailures;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_AvailableFailures")]
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, true, "EventFailure", 1052049, false, true, false, null)]
    protected EventFailure_Environment _AvailableFailures;
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, false, "SubentityRef", 1051083, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_EventLot")]
    protected Environment _EventLot;
    [Metadata("DispositionDataChanges", "DispositionDataChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_QuantityAssigned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1052022, false, false, false, null)]
    protected Environment _QuantityAssigned;
    [Metadata("ActivityDispositionChanges", "ActivityDispositionChanges", false, false, false, "NamedSubentityRef", 1048825, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_Parent")]
    protected new Environment _Parent;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_QtySampled")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1051598, false, false, false, null)]
    protected Environment _QtySampled;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_QtyAffected")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1051594, false, false, false, null)]
    protected Environment _QtyAffected;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_LotQty")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1048712, false, false, false, null)]
    protected Environment _LotQty;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_QuantityConforming")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052027, false, false, false, null)]
    protected Environment _QuantityConforming;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, false, "String", 1048712, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_Quantity")]
    protected Environment _Quantity;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_QuantityRemaining")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052030, false, false, false, null)]
    protected Environment _QuantityRemaining;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_ObjectToChange")]
    [Metadata("Disposition Data", "DispositionData", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_QuantityDispositioned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052033, false, false, false, null)]
    protected Environment _QuantityDispositioned;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052034, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_Selected")]
    protected Environment _Selected;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052028, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_LotHoldRecommended")]
    protected Environment _LotHoldRecommended;
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    protected Environment _ProductName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_Lot")]
    protected Environment _Lot;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionDataChanges_Environment_UOMName")]
    protected Environment _UOMName;

    public Environment EventFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventFailures));
      }
    }

    public EventFailure_Environment AvailableFailures
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableFailures), (object) value);
      }
      get
      {
        return (EventFailure_Environment) this.PropertyGet(nameof (AvailableFailures));
      }
    }

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment QtySampled
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtySampled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtySampled));
      }
    }

    public Environment QtyAffected
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAffected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyAffected));
      }
    }

    public Environment LotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotQty));
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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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

    public Environment Selected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Selected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Selected));
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
  }
}
