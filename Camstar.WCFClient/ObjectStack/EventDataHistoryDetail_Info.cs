// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDataHistoryDetail_Info
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
  public class EventDataHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ContactCustomerHistoryDetail")]
    protected Info _ContactCustomerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_PreventiveActionHistory")]
    protected NCRPreventiveActionHistory_Info _PreventiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReportingCustomerHistoryDetail")]
    protected Info _ReportingCustomerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EventFailureHistoryDetails")]
    protected EventFailureHistoryDetail_Info _EventFailureHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EventLotHistoryDetails")]
    protected EventLotHistoryDetail_Info _EventLotHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_FailureInvestigationHistory")]
    protected NCRFailureInvestigationHistory_Info _FailureInvestigationHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_CorrectiveActionHistory")]
    protected NCRCorrectiveActionHistory_Info _CorrectiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_AdverseEventHistoryDetail")]
    protected Info _AdverseEventHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EventTypeHistoryDetail")]
    protected Info _EventTypeHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DeviceOperatorHistoryDetail")]
    protected Info _DeviceOperatorHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReportSourceHistoryDetail")]
    protected Info _ReportSourceHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EventLogHistoryDetails")]
    protected EventLogHistoryDetail_Info _EventLogHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReportFiledWithFDAHistDetail")]
    protected Info _ReportFiledWithFDAHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DeviceAvailableHistoryDetail")]
    protected Info _DeviceAvailableHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DeviceEvaluatedHistDetail")]
    protected Info _DeviceEvaluatedHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EventFailureActionHistoryDetails")]
    protected EventFailureActionHistoryDtl_Info _EventFailureActionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DeviceReturnedHistoryDetail")]
    protected Info _DeviceReturnedHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_SuspectDeviceHistoryDetails")]
    protected Info _SuspectDeviceHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_Occupation")]
    protected Info _Occupation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ProductProblemHistoryDetail")]
    protected Info _ProductProblemHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_CustomHistoryDetail")]
    protected EventCustomHistoryDetail_Info _CustomHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_HealthProfessionalHistDetail")]
    protected Info _HealthProfessionalHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_CompensateCustomerAction")]
    protected Info _CompensateCustomerAction;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReturnedPhoneNumber")]
    protected Info _ReturnedPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EventDate")]
    protected Info _EventDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReportDateGMT")]
    protected Info _ReportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_RMANumber")]
    protected Info _RMANumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReportDate")]
    protected Info _ReportDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EscalateComplaintDateGMT")]
    protected Info _EscalateComplaintDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_EscalateComplaintDate")]
    protected Info _EscalateComplaintDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DateReceivedGMT")]
    protected Info _DateReceivedGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ReturnedContactName")]
    protected Info _ReturnedContactName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DateReceived")]
    protected Info _DateReceived;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_SampleQuantity")]
    protected Info _SampleQuantity;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_RecallNumber")]
    protected Info _RecallNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_DeviceLocation")]
    protected Info _DeviceLocation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_MaintenanceReqName")]
    protected Info _MaintenanceReqName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ResourceName")]
    protected Info _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_WorkflowName")]
    protected Info _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_WorkCenterName")]
    protected Info _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ProblemDescription")]
    protected Info _ProblemDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ProductRev")]
    protected Info _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_WorkflowRev")]
    protected Info _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_NonconformanceNumber")]
    protected Info _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_SpecRev")]
    protected Info _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_CorrectiveActionComments")]
    protected Info _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_MaintenanceReqRev")]
    protected Info _MaintenanceReqRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_OperationName")]
    protected Info _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_SpecName")]
    protected Info _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_ProductName")]
    protected Info _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_PreventiveActionComments")]
    protected Info _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_FailureInvestigationComments")]
    protected Info _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Info_CauseCodeName")]
    protected Info _CauseCodeName;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info ContactCustomerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCustomerHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContactCustomerHistoryDetail));
      }
    }

    public NCRPreventiveActionHistory_Info PreventiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionHistory), (object) value);
      }
      get
      {
        return (NCRPreventiveActionHistory_Info) this.PropertyGet(nameof (PreventiveActionHistory));
      }
    }

    public Info ReportingCustomerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingCustomerHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportingCustomerHistoryDetail));
      }
    }

    public EventFailureHistoryDetail_Info EventFailureHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureHistoryDetail_Info) this.PropertyGet(nameof (EventFailureHistoryDetails));
      }
    }

    public EventLotHistoryDetail_Info EventLotHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotHistoryDetails), (object) value);
      }
      get
      {
        return (EventLotHistoryDetail_Info) this.PropertyGet(nameof (EventLotHistoryDetails));
      }
    }

    public NCRFailureInvestigationHistory_Info FailureInvestigationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationHistory), (object) value);
      }
      get
      {
        return (NCRFailureInvestigationHistory_Info) this.PropertyGet(nameof (FailureInvestigationHistory));
      }
    }

    public NCRCorrectiveActionHistory_Info CorrectiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionHistory), (object) value);
      }
      get
      {
        return (NCRCorrectiveActionHistory_Info) this.PropertyGet(nameof (CorrectiveActionHistory));
      }
    }

    public Info AdverseEventHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdverseEventHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdverseEventHistoryDetail));
      }
    }

    public Info EventTypeHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventTypeHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventTypeHistoryDetail));
      }
    }

    public Info DeviceOperatorHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceOperatorHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceOperatorHistoryDetail));
      }
    }

    public Info ReportSourceHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportSourceHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportSourceHistoryDetail));
      }
    }

    public EventLogHistoryDetail_Info EventLogHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogHistoryDetails), (object) value);
      }
      get
      {
        return (EventLogHistoryDetail_Info) this.PropertyGet(nameof (EventLogHistoryDetails));
      }
    }

    public Info ReportFiledWithFDAHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFiledWithFDAHistDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportFiledWithFDAHistDetail));
      }
    }

    public Info DeviceAvailableHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceAvailableHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceAvailableHistoryDetail));
      }
    }

    public Info DeviceEvaluatedHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceEvaluatedHistDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceEvaluatedHistDetail));
      }
    }

    public EventFailureActionHistoryDtl_Info EventFailureActionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureActionHistoryDtl_Info) this.PropertyGet(nameof (EventFailureActionHistoryDetails));
      }
    }

    public Info DeviceReturnedHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceReturnedHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeviceReturnedHistoryDetail));
      }
    }

    public Info SuspectDeviceHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SuspectDeviceHistoryDetails));
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

    public Info ProductProblemHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductProblemHistoryDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductProblemHistoryDetail));
      }
    }

    public EventCustomHistoryDetail_Info CustomHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomHistoryDetail), (object) value);
      }
      get
      {
        return (EventCustomHistoryDetail_Info) this.PropertyGet(nameof (CustomHistoryDetail));
      }
    }

    public Info HealthProfessionalHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessionalHistDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HealthProfessionalHistDetail));
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

    public Info EscalateComplaintDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalateComplaintDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalateComplaintDateGMT));
      }
    }

    public Info EscalateComplaintDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalateComplaintDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EscalateComplaintDate));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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
  }
}
