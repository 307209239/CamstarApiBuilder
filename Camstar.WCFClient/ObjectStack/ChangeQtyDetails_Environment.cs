// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeQtyDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (SellDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (BuyDetails_Environment))]
  [KnownType(typeof (AdjustDetails_Environment))]
  [KnownType(typeof (LossDetails_Environment))]
  [KnownType(typeof (BonusDetails_Environment))]
  [Serializable]
  public class ChangeQtyDetails_Environment : ServiceDetails_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_Qty2")]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_Container")]
    protected Environment _Container;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049354, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_AdjustThruput")]
    protected Environment _AdjustThruput;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052571, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_TypeSortOrder")]
    protected Environment _TypeSortOrder;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_RecordAllQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052572, false, false, false, "0")]
    protected Environment _RecordAllQty;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_ChangeQtyType")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1049353, false, false, true, "1")]
    protected Environment _ChangeQtyType;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049728, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_QtyMultiplier")]
    protected Environment _QtyMultiplier;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049368, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_CountsAgainstProduction")]
    protected Environment _CountsAgainstProduction;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_Qty")]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_ChargeToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    protected Environment _ChargeToStep;
    [Metadata("User codes are most often used to define loss reasons through selection lists for data entry fields. InSite provides several user codes such as Bonus Reason and Loss Reason. User Defined Codes are used to allow each customer to specify a list of allowable values for a specific field. In many cases a User Defined Code will merely consist of a Name and Description with no additional attributes. They may also include additional attributes, typically used for additional validations.\r\n\r\nThe name for each Code must be unique within its type. This value is used as an alternate key for lookup-up, data entry and validation.\r\n", "UserCode", false, true, false, "NamedObjectRef", 1049349, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeQtyDetails_Environment_ReasonCode")]
    protected Environment _ReasonCode;

    public Environment Qty2
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

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment Container
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

    public Environment AdjustThruput
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

    public Environment TypeSortOrder
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

    public Environment RecordAllQty
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

    public Environment ChangeQtyType
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

    public Environment QtyMultiplier
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

    public Environment CountsAgainstProduction
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

    public Environment Qty
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

    public Environment ChargeToStep
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

    public Environment ReasonCode
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
  }
}
