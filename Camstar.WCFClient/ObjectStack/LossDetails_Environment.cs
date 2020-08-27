// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LossDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmptyCarrierDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class LossDetails_Environment : ChangeQtyDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_ReasonCode")]
    [Metadata("The user code for loss reason.", "LossReason", false, true, false, "NamedObjectRef", 1048639, false, false, true, null)]
    protected new Environment _ReasonCode;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049209, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_Qty2")]
    protected new Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_RecordAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052572, false, false, false, "0")]
    protected new Environment _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_CountsAgainstProduction")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049368, false, false, false, "1")]
    protected new Environment _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_AdjustThruput")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049354, false, false, false, "1")]
    protected new Environment _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_ChangeQtyType")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1049353, false, false, true, "2")]
    protected new Environment _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_TypeSortOrder")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052571, false, false, false, "10")]
    protected new Environment _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_QtyMultiplier")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049728, false, false, false, "-1")]
    protected new Environment _QtyMultiplier;
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_ChargeToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    protected new Environment _ChargeToStep;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049208, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LossDetails_Environment_Qty")]
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

    public new Environment CountsAgainstProduction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountsAgainstProduction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CountsAgainstProduction));
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
