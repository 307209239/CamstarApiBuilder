// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DispositionData_Environment
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
  public class DispositionData_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_EventFailures")]
    [Metadata("Identifies a failure for an Event.  The failure is the outward symptom of the event, not necessarily the root cause.", "EventFailure", false, false, true, "SubentityRef", 1052084, false, true, false, null)]
    protected Environment _EventFailures;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_EventLot")]
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, true, "SubentityRef", 1051083, false, false, false, null)]
    protected Environment _EventLot;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052027, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_QuantityConforming")]
    protected Environment _QuantityConforming;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_QuantityRemaining")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052030, false, false, false, null)]
    protected Environment _QuantityRemaining;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_QuantityDispositioned")]
    protected Environment _QuantityDispositioned;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_QuantityAssigned")]
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1052022, false, false, false, null)]
    protected Environment _QuantityAssigned;
    [Metadata("A Quantity field that is not subject to the approximations found in the float \"Qty\" type.\r\nThis Quantity is used in the Quality CDOs", "", false, false, true, "String", 1048712, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_LotQty")]
    protected Environment _LotQty;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052028, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_LotHoldRecommended")]
    protected Environment _LotHoldRecommended;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_UOMName")]
    protected Environment _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "DispositionData_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
