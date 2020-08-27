// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDataDetails_Info
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
  public class EventDataDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventLotDetails")]
    protected EventLotDetail_Info _EventLotDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventFailureDetails")]
    protected EventFailureDetail_Info _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_WorkflowStack")]
    protected Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventLogDetails")]
    protected EventLogDetail_Info _EventLogDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventFailureActionDetails")]
    protected EventFailureActionDetail_Info _EventFailureActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReportSourceField")]
    protected ReportSourceField_Info _ReportSourceField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReportFiledWithFDAField")]
    protected ReportFiledWithFDAField_Info _ReportFiledWithFDAField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventTypeField")]
    protected EventTypeField_Info _EventTypeField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventCustomDetail")]
    protected EventCustomDetail_Info _EventCustomDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_SuspectDeviceDetails")]
    protected SuspectDeviceDetail_Info _SuspectDeviceDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReportingCustomerDetail")]
    protected ReportingCustomerDetail_Info _ReportingCustomerDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_AdverseEventField")]
    protected AdverseEventField_Info _AdverseEventField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ContactCustomerDetail")]
    protected ContactCustomerDetail_Info _ContactCustomerDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventData")]
    protected Info _EventData;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DeviceAvailableField")]
    protected DeviceAvailableField_Info _DeviceAvailableField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DeviceEvaluatedField")]
    protected DeviceEvaluatedField_Info _DeviceEvaluatedField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DeviceReturnedField")]
    protected DeviceReturnedField_Info _DeviceReturnedField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_CompensateCustomerAction")]
    protected Info _CompensateCustomerAction;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_HealthProfessionalField")]
    protected HealthProfessionalField_Info _HealthProfessionalField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ProductProblemField")]
    protected ProductProblemField_Info _ProductProblemField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DeviceOperatorField")]
    protected DeviceOperatorField_Info _DeviceOperatorField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_Occupation")]
    protected Info _Occupation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_RMANumber")]
    protected Info _RMANumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReturnedPhoneNumber")]
    protected Info _ReturnedPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_SampleQuantity")]
    protected Info _SampleQuantity;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_EventDate")]
    protected Info _EventDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DateReceived")]
    protected Info _DateReceived;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_RecallNumber")]
    protected Info _RecallNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReportDate")]
    protected Info _ReportDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReportDateGMT")]
    protected Info _ReportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ReturnedContactName")]
    protected Info _ReturnedContactName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DateReceivedGMT")]
    protected Info _DateReceivedGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_WorkflowRev")]
    protected Info _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ProductRev")]
    protected Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_SpecRev")]
    protected Info _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_WorkflowStepName")]
    protected Info _WorkflowStepName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_WorkflowName")]
    protected Info _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_SpecName")]
    protected Info _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_CauseCodeName")]
    protected Info _CauseCodeName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ResourceName")]
    protected Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_ProblemDescription")]
    protected Info _ProblemDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_DeviceLocation")]
    protected Info _DeviceLocation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_OperationName")]
    protected Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_NonconformanceNumber")]
    protected Info _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_WorkCenterName")]
    protected Info _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_MaintenanceReqRev")]
    protected Info _MaintenanceReqRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_MaintenanceReqName")]
    protected Info _MaintenanceReqName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_FailureInvestigationComments")]
    protected Info _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_PreventiveActionComments")]
    protected Info _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Info_CorrectiveActionComments")]
    protected Info _CorrectiveActionComments;

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public EventLotDetail_Info EventLotDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotDetails), (object) value);
      }
      get
      {
        return (EventLotDetail_Info) this.PropertyGet(nameof (EventLotDetails));
      }
    }

    public EventFailureDetail_Info EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail_Info) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public EventLogDetail_Info EventLogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogDetails), (object) value);
      }
      get
      {
        return (EventLogDetail_Info) this.PropertyGet(nameof (EventLogDetails));
      }
    }

    public EventFailureActionDetail_Info EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail_Info) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }

    public ReportSourceField_Info ReportSourceField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportSourceField), (object) value);
      }
      get
      {
        return (ReportSourceField_Info) this.PropertyGet(nameof (ReportSourceField));
      }
    }

    public ReportFiledWithFDAField_Info ReportFiledWithFDAField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFiledWithFDAField), (object) value);
      }
      get
      {
        return (ReportFiledWithFDAField_Info) this.PropertyGet(nameof (ReportFiledWithFDAField));
      }
    }

    public EventTypeField_Info EventTypeField
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventTypeField), (object) value);
      }
      get
      {
        return (EventTypeField_Info) this.PropertyGet(nameof (EventTypeField));
      }
    }

    public EventCustomDetail_Info EventCustomDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventCustomDetail), (object) value);
      }
      get
      {
        return (EventCustomDetail_Info) this.PropertyGet(nameof (EventCustomDetail));
      }
    }

    public SuspectDeviceDetail_Info SuspectDeviceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceDetails), (object) value);
      }
      get
      {
        return (SuspectDeviceDetail_Info) this.PropertyGet(nameof (SuspectDeviceDetails));
      }
    }

    public ReportingCustomerDetail_Info ReportingCustomerDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingCustomerDetail), (object) value);
      }
      get
      {
        return (ReportingCustomerDetail_Info) this.PropertyGet(nameof (ReportingCustomerDetail));
      }
    }

    public AdverseEventField_Info AdverseEventField
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdverseEventField), (object) value);
      }
      get
      {
        return (AdverseEventField_Info) this.PropertyGet(nameof (AdverseEventField));
      }
    }

    public ContactCustomerDetail_Info ContactCustomerDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCustomerDetail), (object) value);
      }
      get
      {
        return (ContactCustomerDetail_Info) this.PropertyGet(nameof (ContactCustomerDetail));
      }
    }

    public Info EventData
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventData), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventData));
      }
    }

    public DeviceAvailableField_Info DeviceAvailableField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceAvailableField), (object) value);
      }
      get
      {
        return (DeviceAvailableField_Info) this.PropertyGet(nameof (DeviceAvailableField));
      }
    }

    public DeviceEvaluatedField_Info DeviceEvaluatedField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceEvaluatedField), (object) value);
      }
      get
      {
        return (DeviceEvaluatedField_Info) this.PropertyGet(nameof (DeviceEvaluatedField));
      }
    }

    public DeviceReturnedField_Info DeviceReturnedField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceReturnedField), (object) value);
      }
      get
      {
        return (DeviceReturnedField_Info) this.PropertyGet(nameof (DeviceReturnedField));
      }
    }

    public Info CompensateCustomerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompensateCustomerAction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompensateCustomerAction));
      }
    }

    public HealthProfessionalField_Info HealthProfessionalField
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessionalField), (object) value);
      }
      get
      {
        return (HealthProfessionalField_Info) this.PropertyGet(nameof (HealthProfessionalField));
      }
    }

    public ProductProblemField_Info ProductProblemField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductProblemField), (object) value);
      }
      get
      {
        return (ProductProblemField_Info) this.PropertyGet(nameof (ProductProblemField));
      }
    }

    public DeviceOperatorField_Info DeviceOperatorField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceOperatorField), (object) value);
      }
      get
      {
        return (DeviceOperatorField_Info) this.PropertyGet(nameof (DeviceOperatorField));
      }
    }

    public Info Occupation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occupation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Occupation));
      }
    }

    public Info RMANumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (RMANumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RMANumber));
      }
    }

    public Info ReturnedPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedPhoneNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReturnedPhoneNumber));
      }
    }

    public Info SampleQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleQuantity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleQuantity));
      }
    }

    public Info EventDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventDate));
      }
    }

    public Info DateReceived
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateReceived), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateReceived));
      }
    }

    public Info RecallNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecallNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecallNumber));
      }
    }

    public Info ReportDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportDate));
      }
    }

    public Info ReportDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportDateGMT));
      }
    }

    public Info ReturnedContactName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedContactName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReturnedContactName));
      }
    }

    public Info DateReceivedGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateReceivedGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateReceivedGMT));
      }
    }

    public Info WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowRev));
      }
    }

    public Info ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Info SpecRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecRev));
      }
    }

    public Info WorkflowStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStepName));
      }
    }

    public Info WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public Info SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SpecName));
      }
    }

    public Info CauseCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CauseCodeName));
      }
    }

    public Info ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceName));
      }
    }

    public Info ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductName));
      }
    }

    public Info ProblemDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProblemDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProblemDescription));
      }
    }

    public Info DeviceLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceLocation));
      }
    }

    public Info OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationName));
      }
    }

    public Info NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NonconformanceNumber));
      }
    }

    public Info WorkCenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCenterName));
      }
    }

    public Info MaintenanceReqRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqRev), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReqRev));
      }
    }

    public Info MaintenanceReqName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReqName));
      }
    }

    public Info FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public Info PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Info CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }
  }
}
