// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCREscalate_Environment
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
  public class NCREscalate_Environment : NCRTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_CreateEvent")]
    [Metadata("Service to create a new Event in the system.", "CreateEvent", false, false, true, "CreateEvent", 1052258, true, false, false, null)]
    protected CreateEvent_Environment _CreateEvent;
    [Metadata("Steps are used to discretely define processing for a point (step) within a Workflow. A Workflow is a collection of Steps that are related using Paths. Each Step contains zero or more Paths, which link to another Step. One Path at each Step is identified as the default Path.\r\n\r\nA sequence of Steps and Paths is a Route. A Workflow can include multiple Routes. Only one Route is identified as the Standard Route. The Standard Route is determined by starting with the Step that is identified as the first Step and then iterating forward selecting the default path at each step.\r\n\r\nA Specification Step is a step within a Workflow that includes a reference to a Spec which in turn describes the work that is to be performed.\r\n\r\n", "SpecStep", false, false, false, "NamedSubentityRef", 1049822, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_ChargeToStep")]
    protected Environment _ChargeToStep;
    [Metadata("The EventDetail service detail is used for creating and updating events", "EventDetail", false, false, true, "EventDetail", 1051208, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_EventDetail")]
    protected EventDetail_Environment _EventDetail;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Failures")]
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, true, "NamedObjectRef", 1050449, false, true, false, null)]
    protected Environment _Failures;
    [Metadata("Comments", "", false, false, false, "String", 1052289, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Comments")]
    protected new Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_ResolutionCode")]
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, false, true, "NamedObjectRef", 1050494, false, false, false, null)]
    protected Environment _ResolutionCode;
    [Metadata("Identifies the Root Cause of why the material failed.", "NCRCauseCode", false, false, true, "NamedObjectRef", 1050492, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_CauseCode")]
    protected Environment _CauseCode;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_PriorityLevel")]
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, true, false, "NamedObjectRef", 1051051, false, false, true, null)]
    protected Environment _PriorityLevel;
    [Metadata("Used to classify QualityObjects", "Classification", false, true, false, "NamedObjectRef", 1051055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Classification")]
    protected Environment _Classification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_BriefDescription")]
    [Metadata("Brief Description", "", false, false, true, "String", 1051299, false, false, false, null)]
    protected Environment _BriefDescription;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, true, false, "NamedObjectRef", 1051146, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_SubClassification")]
    protected Environment _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, true, false, "NamedObjectRef", 1051060, false, false, false, null)]
    protected Environment _Organization;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051062, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Submit")]
    protected Environment _Submit;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051067, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_PlaceOnHold")]
    protected Environment _PlaceOnHold;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048821, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_OriginalStartDateGMT")]
    protected Environment _OriginalStartDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048820, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_OriginalStartDate")]
    protected Environment _OriginalStartDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_OccurrenceDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051344, false, false, false, null)]
    protected Environment _OccurrenceDateGMT;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Container")]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_OccurrenceDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051343, false, false, false, null)]
    protected Environment _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_WorkflowName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050233, false, false, false, null)]
    protected Environment _WorkflowName;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050432, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_PreventiveActionComments")]
    protected Environment _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1048836, false, false, false, null)]
    protected Environment _Qty;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050601, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_NonconformanceNumber")]
    protected Environment _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected new Environment _Factory;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050125, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_UOMName")]
    protected Environment _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_CauseCodeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051782, false, false, false, null)]
    protected Environment _CauseCodeName;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050434, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_FailureInvestigationComments")]
    protected Environment _FailureInvestigationComments;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_ProductName")]
    protected Environment _ProductName;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_WorkflowRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049581, false, false, false, null)]
    protected Environment _WorkflowRev;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048861, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Initiator")]
    protected Environment _Initiator;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049573, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_ProductRev")]
    protected Environment _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_OperationName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049568, false, false, false, null)]
    protected Environment _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_DiscoveryArea")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051043, false, false, false, null)]
    protected Environment _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_CorrectiveActionComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050433, false, false, false, null)]
    protected Environment _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "NCREscalate_Environment_Lot")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049481, false, false, false, null)]
    protected Environment _Lot;

    public CreateEvent_Environment CreateEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateEvent), (object) value);
      }
      get
      {
        return (CreateEvent_Environment) this.PropertyGet(nameof (CreateEvent));
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

    public EventDetail_Environment EventDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDetail), (object) value);
      }
      get
      {
        return (EventDetail_Environment) this.PropertyGet(nameof (EventDetail));
      }
    }

    public Environment Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Failures));
      }
    }

    public new Environment Comments
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

    public Environment ResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResolutionCode));
      }
    }

    public Environment CauseCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CauseCode));
      }
    }

    public Environment PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public Environment BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
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

    public Environment OriginalStartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalStartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalStartDateGMT));
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

    public Environment OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccurrenceDateGMT));
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

    public Environment OccurrenceDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccurrenceDate));
      }
    }

    public Environment WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public Environment PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PreventiveActionComments));
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

    public Environment NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceNumber));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
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

    public Environment CauseCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CauseCodeName));
      }
    }

    public Environment FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailureInvestigationComments));
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

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowRev));
      }
    }

    public Environment Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Initiator));
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

    public Environment DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public Environment CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CorrectiveActionComments));
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
  }
}
