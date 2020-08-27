// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyHistoryDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (QtySellHistoryDetails_Environment))]
  [KnownType(typeof (QtyAdjustHistoryDetails_Environment))]
  [KnownType(typeof (QtyBuyHistoryDetails_Environment))]
  [KnownType(typeof (QtyLossHistoryDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (QtyBonusHistoryDetails_Environment))]
  [Serializable]
  public class QtyHistoryDetails_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048853, false, false, false, null)]
    protected Environment _UOM;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048854, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_UOM2")]
    protected Environment _UOM2;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049351, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ChildrenLost")]
    protected Environment _ChildrenLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ChangeQtyType")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049353, false, false, false, null)]
    protected Environment _ChangeQtyType;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_UnitsLost")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049375, false, false, false, null)]
    protected Environment _UnitsLost;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049664, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ThisContainerDisassociated")]
    protected Environment _ThisContainerDisassociated;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048848, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ThisContainerClosed")]
    protected Environment _ThisContainerClosed;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_UnitContainer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049374, false, false, false, "0")]
    protected Environment _UnitContainer;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_RecordAllQty")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052572, false, false, false, "0")]
    protected Environment _RecordAllQty;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049368, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_CountsAgainstProduction")]
    protected Environment _CountsAgainstProduction;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_QtyMultiplier")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049728, false, false, false, "1")]
    protected Environment _QtyMultiplier;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049350, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_IsRollup")]
    protected Environment _IsRollup;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049367, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_CloseWhenZero")]
    protected Environment _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_AdjustThruput")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049369, false, false, false, "0")]
    protected Environment _AdjustThruput;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ReasonCode")]
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 1049349, false, false, false, null)]
    protected Environment _ReasonCode;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_Operation")]
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, false, null)]
    protected Environment _Operation;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_Qty2")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048837, false, false, false, null)]
    protected Environment _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_ChargeToStep")]
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1049822, false, false, false, null)]
    protected Environment _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistoryDetails_Environment_Comments")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;

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

    public Environment ChildrenLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildrenLost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildrenLost));
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

    public Environment UnitsLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsLost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitsLost));
      }
    }

    public Environment ThisContainerDisassociated
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerDisassociated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThisContainerDisassociated));
      }
    }

    public Environment ThisContainerClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThisContainerClosed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ThisContainerClosed));
      }
    }

    public Environment UnitContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UnitContainer));
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

    public Environment IsRollup
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRollup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRollup));
      }
    }

    public Environment CloseWhenZero
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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

    public Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }

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
  }
}
