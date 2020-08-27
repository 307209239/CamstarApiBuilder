// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SellDetails_Environment
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
  public class SellDetails_Environment : ChangeQtyDetails_Environment
  {
    [Metadata("The user code for sell reason", "SellReason", false, true, false, "NamedObjectRef", 1049506, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_ReasonCode")]
    protected new Environment _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052584, false, false, false, null)]
    protected new Environment _Qty2;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049728, false, false, false, "-1")]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_QtyMultiplier")]
    protected new Environment _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_TypeSortOrder")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052571, false, false, false, "30")]
    protected new Environment _TypeSortOrder;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049354, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_AdjustThruput")]
    protected new Environment _AdjustThruput;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1049353, false, false, true, "3")]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_ChangeQtyType")]
    protected new Environment _ChangeQtyType;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_Container")]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_RecordAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052572, false, false, false, "0")]
    protected new Environment _RecordAllQty;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_ChargeToStep")]
    protected new Environment _ChargeToStep;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1052583, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SellDetails_Environment_Qty")]
    protected new Environment _Qty;

    public new Environment ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public new Environment Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2));
      }
    }

    public new Environment QtyMultiplier
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyMultiplier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyMultiplier));
      }
    }

    public new Environment TypeSortOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (TypeSortOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TypeSortOrder));
      }
    }

    public new Environment AdjustThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdjustThruput), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdjustThruput));
      }
    }

    public new Environment ChangeQtyType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQtyType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangeQtyType));
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

    public new Environment RecordAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordAllQty));
      }
    }

    public new Environment ChargeToStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChargeToStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChargeToStep));
      }
    }

    public new Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
