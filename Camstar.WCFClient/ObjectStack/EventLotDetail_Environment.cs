// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotDetail_Environment
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
  public class EventLotDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_EventLot")]
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, false, "SubentityRef", 1051083, false, false, false, null)]
    protected Environment _EventLot;
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, false, "NamedSubentityRef", 1050503, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_Task")]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_NCRDefectDetails")]
    [Metadata("This ServiceDetails object records failure defect data for a Nonconformance.  This information is recorded historically.  If an ActualComponentIssue value is assigned, then the Container, Lot, Product and ReferenceDesignator all default to the values in that history.  These values can be overridden by the client.", "NCRDefectDetails", false, false, false, "NCRDefectDetails", 1050451, false, true, false, null)]
    protected NCRDefectDetails_Environment _NCRDefectDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_FailureModes")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1051077, false, true, true, null)]
    protected Environment _FailureModes;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_Components")]
    [Metadata("Identifies a suspect Component for an Event.", "EventComponentDetail", false, false, false, "EventComponentDetail", 1051082, false, true, false, null)]
    protected EventComponentDetail_Environment _Components;
    [Metadata("Service Details to assign the Disposition information to an Event.", "EventDispositionDetail", false, false, false, "EventDispositionDetail", 1052985, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_EventDispositionDetails")]
    protected EventDispositionDetail_Environment _EventDispositionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_LotDispositionStatus")]
    [Metadata("LotDispositionStatus", "LotDispositionStatusEnum", false, false, true, "Integer", 1052047, false, false, false, null)]
    protected Environment _LotDispositionStatus;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_OriginalStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049313, false, false, false, null)]
    protected Environment _OriginalStartDate;
    [Metadata("Generic String", "", false, false, false, "String", 1049418, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_ReferenceDesignator")]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_IsContainer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052480, false, false, false, "0")]
    protected Environment _IsContainer;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051084, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_PlaceOnHold")]
    protected Environment _PlaceOnHold;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, true, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_ProductDescription")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1049279, false, false, false, null)]
    protected Environment _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_WorkcenterName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049672, false, false, false, null)]
    protected Environment _WorkcenterName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048815, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_OperationName")]
    protected Environment _OperationName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_UOMName")]
    protected Environment _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_FactoryName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048659, false, false, false, null)]
    protected Environment _FactoryName;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, false, "NamedSubentityRef", 1049822, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048625, false, false, true, null)]
    protected Environment _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049481, false, false, true, null)]
    protected Environment _Lot;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_ProductRev")]
    protected Environment _ProductRev;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1053011, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_QtyPendingDisp")]
    protected Environment _QtyPendingDisp;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1051085, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_QtyDefective")]
    protected Environment _QtyDefective;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [DataMember(EmitDefaultValue = false, Name = "EventLotDetail_Environment_QtySampled")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1051086, false, false, false, null)]
    protected Environment _QtySampled;

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

    public Environment Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Task));
      }
    }

    public NCRDefectDetails_Environment NCRDefectDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectDetails), (object) value);
      }
      get
      {
        return (NCRDefectDetails_Environment) this.PropertyGet(nameof (NCRDefectDetails));
      }
    }

    public Environment FailureModes
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureModes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureModes));
      }
    }

    public EventComponentDetail_Environment Components
    {
      [param: In] set
      {
        this.PropertySet(nameof (Components), (object) value);
      }
      get
      {
        return (EventComponentDetail_Environment) this.PropertyGet(nameof (Components));
      }
    }

    public EventDispositionDetail_Environment EventDispositionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDispositionDetails), (object) value);
      }
      get
      {
        return (EventDispositionDetail_Environment) this.PropertyGet(nameof (EventDispositionDetails));
      }
    }

    public Environment LotDispositionStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotDispositionStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotDispositionStatus));
      }
    }

    public Environment OriginalStartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalStartDate));
      }
    }

    public Environment ReferenceDesignator
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReferenceDesignator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReferenceDesignator));
      }
    }

    public Environment IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Environment PlaceOnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlaceOnHold), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlaceOnHold));
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

    public Environment ProductDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductDescription));
      }
    }

    public Environment WorkcenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkcenterName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkcenterName));
      }
    }

    public Environment OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OperationName));
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

    public Environment FactoryName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FactoryName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FactoryName));
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

    public Environment ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Environment QtyPendingDisp
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyPendingDisp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyPendingDisp));
      }
    }

    public Environment QtyDefective
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyDefective), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyDefective));
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
  }
}
