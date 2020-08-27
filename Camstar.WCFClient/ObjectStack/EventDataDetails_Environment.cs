// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDataDetails_Environment
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
  public class EventDataDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ResourceGroup")]
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    protected Environment _ResourceGroup;
    [Metadata("Identifies the Lots to assign to the Event.", "EventLotDetail", false, false, false, "EventLotDetail", 1051092, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventLotDetails")]
    protected EventLotDetail_Environment _EventLotDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventFailureDetails")]
    [Metadata("Service Details to assign the Failure information to an Event.", "EventFailureDetail", false, false, false, "EventFailureDetail", 1052479, false, true, false, null)]
    protected EventFailureDetail_Environment _EventFailureDetails;
    [Metadata("A Sub-Workflow Step is used to reference a Workflow from another Workfow. This allows, for example, the re-use of Workflows for Rework processing.\r\n\r\n", "SubWorkflowStep", false, false, false, "NamedSubentityRef", 1049067, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_WorkflowStack")]
    protected Environment _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventLogDetails")]
    [Metadata("Identifies a Log for an Event.", "EventLogDetail", false, false, false, "EventLogDetail", 1052959, false, true, false, null)]
    protected EventLogDetail_Environment _EventLogDetails;
    [Metadata("Identifies a failure action for an Event or Cause.", "EventFailureActionDetail", false, false, false, "EventFailureActionDetail", 1052955, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventFailureActionDetails")]
    protected EventFailureActionDetail_Environment _EventFailureActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReportSourceField")]
    [Metadata("The source of the information provided with the event.", "ReportSourceField", false, false, false, "ReportSourceField", 1052510, true, false, false, null)]
    protected ReportSourceField_Environment _ReportSourceField;
    [Metadata("Did the person who reported the problem to the manufacturer also report the problem to the FDA", "ReportFiledWithFDAField", false, false, false, "ReportFiledWithFDAField", 1052508, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReportFiledWithFDAField")]
    protected ReportFiledWithFDAField_Environment _ReportFiledWithFDAField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventTypeField")]
    [Metadata("What type of event occured during the operation of the device/product.", "EventTypeField", false, false, false, "EventTypeField", 1051326, true, false, false, null)]
    protected EventTypeField_Environment _EventTypeField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventCustomDetail")]
    [Metadata("Used to manage customer extensions to Event.", "EventCustomDetail", false, false, false, "EventCustomDetail", 1052474, false, false, false, null)]
    protected EventCustomDetail_Environment _EventCustomDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_SuspectDeviceDetails")]
    [Metadata("The details of the product submitted by the sevice for the event.", "SuspectDeviceDetail", false, false, false, "SuspectDeviceDetail", 1052511, false, true, false, null)]
    protected SuspectDeviceDetail_Environment _SuspectDeviceDetails;
    [Metadata("Identifies the Customer information to assign to the Event.", "ReportingCustomerDetail", false, false, false, "ReportingCustomerDetail", 1052509, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReportingCustomerDetail")]
    protected ReportingCustomerDetail_Environment _ReportingCustomerDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_AdverseEventField")]
    [Metadata("Did the product cause an adverse effect?", "AdverseEventField", false, false, false, "AdverseEventField", 1051321, true, false, false, null)]
    protected AdverseEventField_Environment _AdverseEventField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ContactCustomerDetail")]
    [Metadata("Identifies the Customer information to assign to the Event.", "ContactCustomerDetail", false, false, false, "ContactCustomerDetail", 1052500, false, false, false, null)]
    protected ContactCustomerDetail_Environment _ContactCustomerDetail;
    [Metadata("Identifies additional data for an Event.", "EventData", false, false, false, "SubentityRef", 1051151, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventData")]
    protected Environment _EventData;
    [Metadata("Is Device available for evaluation?", "DeviceAvailableField", false, false, false, "DeviceAvailableField", 1048655, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DeviceAvailableField")]
    protected DeviceAvailableField_Environment _DeviceAvailableField;
    [Metadata("Has the manufacturer evaluated the device.", "DeviceEvaluatedField", false, false, false, "DeviceEvaluatedField", 1051323, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DeviceEvaluatedField")]
    protected DeviceEvaluatedField_Environment _DeviceEvaluatedField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DeviceReturnedField")]
    [Metadata("Was the device returned to the manufacturer", "DeviceReturnedField", false, false, false, "DeviceReturnedField", 1051325, true, false, false, null)]
    protected DeviceReturnedField_Environment _DeviceReturnedField;
    [Metadata("Action taken for returned equipment.", "ReturnedEquipmentAction", false, false, false, "NamedObjectRef", 1051262, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_CompensateCustomerAction")]
    protected Environment _CompensateCustomerAction;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_HealthProfessionalField")]
    [Metadata("Was the person reporting the problem a health professional", "HealthProfessionalField", false, false, false, "HealthProfessionalField", 1052506, true, false, false, null)]
    protected HealthProfessionalField_Environment _HealthProfessionalField;
    [Metadata("Problem with the product.", "ProductProblemField", false, false, false, "ProductProblemField", 1051328, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ProductProblemField")]
    protected ProductProblemField_Environment _ProductProblemField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DeviceOperatorField")]
    [Metadata("Who was operating the device.", "DeviceOperatorField", false, false, false, "DeviceOperatorField", 1051324, true, false, false, null)]
    protected DeviceOperatorField_Environment _DeviceOperatorField;
    [Metadata("A list of jobs available for selection in the MedWatch report.", "Occupation", false, false, false, "NamedObjectRef", 1051269, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_Occupation")]
    protected Environment _Occupation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_RMANumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051275, false, false, false, null)]
    protected Environment _RMANumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReturnedPhoneNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051440, false, false, false, null)]
    protected Environment _ReturnedPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_SampleQuantity")]
    [Metadata("Generic String", "", false, false, false, "String", 1051276, false, false, false, null)]
    protected Environment _SampleQuantity;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_EventDate")]
    [Metadata("Generic String", "", false, false, false, "String", 1052494, false, false, false, null)]
    protected Environment _EventDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052486, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DateReceived")]
    protected Environment _DateReceived;
    [Metadata("Generic String", "", false, false, false, "String", 1051271, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_RecallNumber")]
    protected Environment _RecallNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReportDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052496, false, false, false, null)]
    protected Environment _ReportDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReportDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052497, false, false, false, null)]
    protected Environment _ReportDateGMT;
    [Metadata("Generic String", "", false, false, false, "String", 1051441, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ReturnedContactName")]
    protected Environment _ReturnedContactName;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052487, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DateReceivedGMT")]
    protected Environment _DateReceivedGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_WorkflowRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050500, false, false, false, null)]
    protected Environment _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ProductRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049573, false, false, false, null)]
    protected Environment _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_SpecRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1049578, false, false, false, null)]
    protected Environment _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_WorkflowStepName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049822, false, false, true, null)]
    protected Environment _WorkflowStepName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_WorkflowName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050500, false, false, true, null)]
    protected Environment _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_SpecName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050232, false, false, true, null)]
    protected Environment _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_CauseCodeName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050492, false, false, true, null)]
    protected Environment _CauseCodeName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049575, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ResourceName")]
    protected Environment _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048709, false, false, true, null)]
    protected Environment _ProductName;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1051270, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_ProblemDescription")]
    protected Environment _ProblemDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_DeviceLocation")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051267, false, false, true, null)]
    protected Environment _DeviceLocation;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049568, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_OperationName")]
    protected Environment _OperationName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050601, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_NonconformanceNumber")]
    protected Environment _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_WorkCenterName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050129, false, false, true, null)]
    protected Environment _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_MaintenanceReqRev")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051172, false, false, false, null)]
    protected Environment _MaintenanceReqRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_MaintenanceReqName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050680, false, false, true, null)]
    protected Environment _MaintenanceReqName;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1050434, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_FailureInvestigationComments")]
    protected Environment _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_PreventiveActionComments")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1050432, false, false, false, null)]
    protected Environment _PreventiveActionComments;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1050433, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Environment_CorrectiveActionComments")]
    protected Environment _CorrectiveActionComments;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public EventLotDetail_Environment EventLotDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotDetails), (object) value);
      }
      get
      {
        return (EventLotDetail_Environment) this.PropertyGet(nameof (EventLotDetails));
      }
    }

    public EventFailureDetail_Environment EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail_Environment) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public Environment WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public EventLogDetail_Environment EventLogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogDetails), (object) value);
      }
      get
      {
        return (EventLogDetail_Environment) this.PropertyGet(nameof (EventLogDetails));
      }
    }

    public EventFailureActionDetail_Environment EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail_Environment) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }

    public ReportSourceField_Environment ReportSourceField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportSourceField), (object) value);
      }
      get
      {
        return (ReportSourceField_Environment) this.PropertyGet(nameof (ReportSourceField));
      }
    }

    public ReportFiledWithFDAField_Environment ReportFiledWithFDAField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFiledWithFDAField), (object) value);
      }
      get
      {
        return (ReportFiledWithFDAField_Environment) this.PropertyGet(nameof (ReportFiledWithFDAField));
      }
    }

    public EventTypeField_Environment EventTypeField
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventTypeField), (object) value);
      }
      get
      {
        return (EventTypeField_Environment) this.PropertyGet(nameof (EventTypeField));
      }
    }

    public EventCustomDetail_Environment EventCustomDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventCustomDetail), (object) value);
      }
      get
      {
        return (EventCustomDetail_Environment) this.PropertyGet(nameof (EventCustomDetail));
      }
    }

    public SuspectDeviceDetail_Environment SuspectDeviceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceDetails), (object) value);
      }
      get
      {
        return (SuspectDeviceDetail_Environment) this.PropertyGet(nameof (SuspectDeviceDetails));
      }
    }

    public ReportingCustomerDetail_Environment ReportingCustomerDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingCustomerDetail), (object) value);
      }
      get
      {
        return (ReportingCustomerDetail_Environment) this.PropertyGet(nameof (ReportingCustomerDetail));
      }
    }

    public AdverseEventField_Environment AdverseEventField
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdverseEventField), (object) value);
      }
      get
      {
        return (AdverseEventField_Environment) this.PropertyGet(nameof (AdverseEventField));
      }
    }

    public ContactCustomerDetail_Environment ContactCustomerDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCustomerDetail), (object) value);
      }
      get
      {
        return (ContactCustomerDetail_Environment) this.PropertyGet(nameof (ContactCustomerDetail));
      }
    }

    public Environment EventData
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventData), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventData));
      }
    }

    public DeviceAvailableField_Environment DeviceAvailableField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceAvailableField), (object) value);
      }
      get
      {
        return (DeviceAvailableField_Environment) this.PropertyGet(nameof (DeviceAvailableField));
      }
    }

    public DeviceEvaluatedField_Environment DeviceEvaluatedField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceEvaluatedField), (object) value);
      }
      get
      {
        return (DeviceEvaluatedField_Environment) this.PropertyGet(nameof (DeviceEvaluatedField));
      }
    }

    public DeviceReturnedField_Environment DeviceReturnedField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceReturnedField), (object) value);
      }
      get
      {
        return (DeviceReturnedField_Environment) this.PropertyGet(nameof (DeviceReturnedField));
      }
    }

    public Environment CompensateCustomerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompensateCustomerAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompensateCustomerAction));
      }
    }

    public HealthProfessionalField_Environment HealthProfessionalField
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessionalField), (object) value);
      }
      get
      {
        return (HealthProfessionalField_Environment) this.PropertyGet(nameof (HealthProfessionalField));
      }
    }

    public ProductProblemField_Environment ProductProblemField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductProblemField), (object) value);
      }
      get
      {
        return (ProductProblemField_Environment) this.PropertyGet(nameof (ProductProblemField));
      }
    }

    public DeviceOperatorField_Environment DeviceOperatorField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceOperatorField), (object) value);
      }
      get
      {
        return (DeviceOperatorField_Environment) this.PropertyGet(nameof (DeviceOperatorField));
      }
    }

    public Environment Occupation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occupation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Occupation));
      }
    }

    public Environment RMANumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (RMANumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RMANumber));
      }
    }

    public Environment ReturnedPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedPhoneNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReturnedPhoneNumber));
      }
    }

    public Environment SampleQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleQuantity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleQuantity));
      }
    }

    public Environment EventDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventDate));
      }
    }

    public Environment DateReceived
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateReceived), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateReceived));
      }
    }

    public Environment RecallNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecallNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecallNumber));
      }
    }

    public Environment ReportDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportDate));
      }
    }

    public Environment ReportDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportDateGMT));
      }
    }

    public Environment ReturnedContactName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedContactName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReturnedContactName));
      }
    }

    public Environment DateReceivedGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateReceivedGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DateReceivedGMT));
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

    public Environment SpecRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecRev));
      }
    }

    public Environment WorkflowStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkflowStepName));
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

    public Environment SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SpecName));
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

    public Environment ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceName));
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

    public Environment ProblemDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProblemDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProblemDescription));
      }
    }

    public Environment DeviceLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceLocation));
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

    public Environment WorkCenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkCenterName));
      }
    }

    public Environment MaintenanceReqRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReqRev));
      }
    }

    public Environment MaintenanceReqName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReqName));
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
  }
}
