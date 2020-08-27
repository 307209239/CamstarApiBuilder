// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventLotHistoryDetail_Environment
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
  public class EventLotHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("History for the EventComponentDetail.", "EventComponentHistoryDetail", false, false, true, "SubentityRef", 1051074, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_EventComponentHistoryDetails")]
    protected Environment _EventComponentHistoryDetails;
    [Metadata("NCR defect history details.", "NCRDefectHistoryDetails", false, false, true, "NCRDefectHistoryDetails", 1052536, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_NCRDefectHistoryDetails")]
    protected NCRDefectHistoryDetails_Environment _NCRDefectHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_Task")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, true, "NamedSubentityRef", 1050503, false, false, false, null)]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_FailureModes")]
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1051077, false, true, true, null)]
    protected Environment _FailureModes;
    [Metadata("History for Disposition", "EventDispositionHistoryDetail", false, false, true, "SubentityRef", 1052988, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_EventDispositionHistoryDetails")]
    protected Environment _EventDispositionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_OriginalStartDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049313, false, false, false, null)]
    protected Environment _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_ReferenceDesignator")]
    [Metadata("Generic String", "", false, false, true, "String", 1049418, false, false, false, null)]
    protected Environment _ReferenceDesignator;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_IsContainer")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052480, false, false, false, "0")]
    protected Environment _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_PlaceOnHold")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051067, false, false, false, "0")]
    protected Environment _PlaceOnHold;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_ProductName")]
    protected Environment _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_OperationName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048815, false, false, false, null)]
    protected Environment _OperationName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048659, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_FactoryName")]
    protected Environment _FactoryName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_UOMName")]
    protected Environment _UOMName;
    [Metadata("A step is an individual tracking point within a workflow.  The list of steps is the primary data structure within a workflow.  Paths control the allowable movements between steps.\r\nEach Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA Step normally represents an individual processing point in a workflow, where it references a Spec which in turn describes the work that is to be performed. A Step can reference another workflow, in which case the step represents a series of processing points.", "Step", false, false, true, "NamedSubentityRef", 1049822, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049672, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_WorkcenterName")]
    protected Environment _WorkcenterName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049481, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_Lot")]
    protected Environment _Lot;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_QtySampled")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1051069, false, false, false, null)]
    protected Environment _QtySampled;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1049279, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_ProductDescription")]
    protected Environment _ProductDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_ProductRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050390, false, false, false, null)]
    protected Environment _ProductRev;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1051068, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventLotHistoryDetail_Environment_QtyDefective")]
    protected Environment _QtyDefective;

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

    public Environment EventComponentHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventComponentHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventComponentHistoryDetails));
      }
    }

    public NCRDefectHistoryDetails_Environment NCRDefectHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRDefectHistoryDetails), (object) value);
      }
      get
      {
        return (NCRDefectHistoryDetails_Environment) this.PropertyGet(nameof (NCRDefectHistoryDetails));
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

    public Environment EventDispositionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDispositionHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventDispositionHistoryDetails));
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
  }
}
