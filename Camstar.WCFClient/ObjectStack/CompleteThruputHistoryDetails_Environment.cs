// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteThruputHistoryDetails_Environment
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
  public class CompleteThruputHistoryDetails_Environment : CompleteMaintHistoryDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050757, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_LastThruputQty2Limit")]
    protected Environment _LastThruputQty2Limit;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050758, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_LastThruputQty2Warning")]
    protected Environment _LastThruputQty2Warning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_ThruputQty2")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050724, false, false, false, null)]
    protected Environment _ThruputQty2;
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050756, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_LastThruputQty2Due")]
    protected Environment _LastThruputQty2Due;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_UOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048630, false, false, false, null)]
    protected Environment _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_LastThruputQtyLimit")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050760, false, false, false, null)]
    protected Environment _LastThruputQtyLimit;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050723, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_ThruputQty")]
    protected Environment _ThruputQty;
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050761, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_LastThruputQtyWarning")]
    protected Environment _LastThruputQtyWarning;
    [DataMember(EmitDefaultValue = false, Name = "CompleteThruputHistoryDetails_Environment_LastThruputQtyDue")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1050759, false, false, false, null)]
    protected Environment _LastThruputQtyDue;

    public Environment LastThruputQty2Limit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Limit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastThruputQty2Limit));
      }
    }

    public Environment LastThruputQty2Warning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Warning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastThruputQty2Warning));
      }
    }

    public Environment ThruputQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputQty2));
      }
    }

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment LastThruputQty2Due
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQty2Due), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastThruputQty2Due));
      }
    }

    public Environment UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM2));
      }
    }

    public Environment LastThruputQtyLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastThruputQtyLimit));
      }
    }

    public Environment ThruputQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThruputQty));
      }
    }

    public Environment LastThruputQtyWarning
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyWarning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastThruputQtyWarning));
      }
    }

    public Environment LastThruputQtyDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastThruputQtyDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastThruputQtyDue));
      }
    }
  }
}
