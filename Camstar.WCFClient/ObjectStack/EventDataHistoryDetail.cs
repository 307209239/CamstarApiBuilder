// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDataHistoryDetail
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
  public class EventDataHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ContactCustomerHistoryDetail")]
    protected SubentityRef _ContactCustomerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_PreventiveActionHistory")]
    protected NCRPreventiveActionHistory _PreventiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReportingCustomerHistoryDetail")]
    protected SubentityRef _ReportingCustomerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EventFailureHistoryDetails")]
    protected EventFailureHistoryDetail[] _EventFailureHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EventLotHistoryDetails")]
    protected EventLotHistoryDetail[] _EventLotHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_FailureInvestigationHistory")]
    protected NCRFailureInvestigationHistory _FailureInvestigationHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_CorrectiveActionHistory")]
    protected NCRCorrectiveActionHistory _CorrectiveActionHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_AdverseEventHistoryDetail")]
    protected SubentityRef _AdverseEventHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EventTypeHistoryDetail")]
    protected SubentityRef _EventTypeHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DeviceOperatorHistoryDetail")]
    protected SubentityRef _DeviceOperatorHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReportSourceHistoryDetail")]
    protected SubentityRef _ReportSourceHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EventLogHistoryDetails")]
    protected EventLogHistoryDetail[] _EventLogHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReportFiledWithFDAHistDetail")]
    protected SubentityRef _ReportFiledWithFDAHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DeviceAvailableHistoryDetail")]
    protected SubentityRef _DeviceAvailableHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DeviceEvaluatedHistDetail")]
    protected SubentityRef _DeviceEvaluatedHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EventFailureActionHistoryDetails")]
    protected EventFailureActionHistoryDtl[] _EventFailureActionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DeviceReturnedHistoryDetail")]
    protected SubentityRef _DeviceReturnedHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_SuspectDeviceHistoryDetails")]
    protected SubentityRef[] _SuspectDeviceHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Occupation")]
    protected NamedObjectRef _Occupation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ProductProblemHistoryDetail")]
    protected SubentityRef _ProductProblemHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_CustomHistoryDetail")]
    protected EventCustomHistoryDetail _CustomHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_HealthProfessionalHistDetail")]
    protected SubentityRef _HealthProfessionalHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_CompensateCustomerAction")]
    protected NamedObjectRef _CompensateCustomerAction;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReturnedPhoneNumber")]
    protected Primitive<string> _ReturnedPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EventDate")]
    protected Primitive<string> _EventDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReportDateGMT")]
    protected Primitive<DateTime> _ReportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_RMANumber")]
    protected Primitive<string> _RMANumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReportDate")]
    protected Primitive<DateTime> _ReportDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EscalateComplaintDateGMT")]
    protected Primitive<DateTime> _EscalateComplaintDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_EscalateComplaintDate")]
    protected Primitive<DateTime> _EscalateComplaintDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DateReceivedGMT")]
    protected Primitive<DateTime> _DateReceivedGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ReturnedContactName")]
    protected Primitive<string> _ReturnedContactName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DateReceived")]
    protected Primitive<DateTime> _DateReceived;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_SampleQuantity")]
    protected Primitive<string> _SampleQuantity;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_RecallNumber")]
    protected Primitive<string> _RecallNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_DeviceLocation")]
    protected Primitive<string> _DeviceLocation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_MaintenanceReqName")]
    protected Primitive<string> _MaintenanceReqName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ResourceName")]
    protected Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_WorkflowName")]
    protected Primitive<string> _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_WorkCenterName")]
    protected Primitive<string> _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ProblemDescription")]
    protected Primitive<string> _ProblemDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_WorkflowRev")]
    protected Primitive<string> _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_NonconformanceNumber")]
    protected Primitive<string> _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_SpecRev")]
    protected Primitive<string> _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_CorrectiveActionComments")]
    protected Primitive<string> _CorrectiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_MaintenanceReqRev")]
    protected Primitive<string> _MaintenanceReqRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_SpecName")]
    protected Primitive<string> _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_PreventiveActionComments")]
    protected Primitive<string> _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_FailureInvestigationComments")]
    protected Primitive<string> _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_CauseCodeName")]
    protected Primitive<string> _CauseCodeName;

    public override bool Equals(object obj)
    {
      return obj is EventDataHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((EventDataHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._ContactCustomerHistoryDetail, (object) ((EventDataHistoryDetail) obj)._ContactCustomerHistoryDetail) && object.Equals((object) this._PreventiveActionHistory, (object) ((EventDataHistoryDetail) obj)._PreventiveActionHistory)) && (object.Equals((object) this._ReportingCustomerHistoryDetail, (object) ((EventDataHistoryDetail) obj)._ReportingCustomerHistoryDetail) && this.CompareArrays((Array) this._EventFailureHistoryDetails, (Array) ((EventDataHistoryDetail) obj)._EventFailureHistoryDetails) && (this.CompareArrays((Array) this._EventLotHistoryDetails, (Array) ((EventDataHistoryDetail) obj)._EventLotHistoryDetails) && object.Equals((object) this._FailureInvestigationHistory, (object) ((EventDataHistoryDetail) obj)._FailureInvestigationHistory))) && (object.Equals((object) this._CorrectiveActionHistory, (object) ((EventDataHistoryDetail) obj)._CorrectiveActionHistory) && object.Equals((object) this._AdverseEventHistoryDetail, (object) ((EventDataHistoryDetail) obj)._AdverseEventHistoryDetail) && (object.Equals((object) this._EventTypeHistoryDetail, (object) ((EventDataHistoryDetail) obj)._EventTypeHistoryDetail) && object.Equals((object) this._DeviceOperatorHistoryDetail, (object) ((EventDataHistoryDetail) obj)._DeviceOperatorHistoryDetail)) && (object.Equals((object) this._ReportSourceHistoryDetail, (object) ((EventDataHistoryDetail) obj)._ReportSourceHistoryDetail) && this.CompareArrays((Array) this._EventLogHistoryDetails, (Array) ((EventDataHistoryDetail) obj)._EventLogHistoryDetails) && (object.Equals((object) this._ReportFiledWithFDAHistDetail, (object) ((EventDataHistoryDetail) obj)._ReportFiledWithFDAHistDetail) && object.Equals((object) this._DeviceAvailableHistoryDetail, (object) ((EventDataHistoryDetail) obj)._DeviceAvailableHistoryDetail)))) && (object.Equals((object) this._DeviceEvaluatedHistDetail, (object) ((EventDataHistoryDetail) obj)._DeviceEvaluatedHistDetail) && this.CompareArrays((Array) this._EventFailureActionHistoryDetails, (Array) ((EventDataHistoryDetail) obj)._EventFailureActionHistoryDetails) && (object.Equals((object) this._DeviceReturnedHistoryDetail, (object) ((EventDataHistoryDetail) obj)._DeviceReturnedHistoryDetail) && this.CompareArrays((Array) this._SuspectDeviceHistoryDetails, (Array) ((EventDataHistoryDetail) obj)._SuspectDeviceHistoryDetails)) && (object.Equals((object) this._Occupation, (object) ((EventDataHistoryDetail) obj)._Occupation) && object.Equals((object) this._ProductProblemHistoryDetail, (object) ((EventDataHistoryDetail) obj)._ProductProblemHistoryDetail) && (object.Equals((object) this._CustomHistoryDetail, (object) ((EventDataHistoryDetail) obj)._CustomHistoryDetail) && object.Equals((object) this._HealthProfessionalHistDetail, (object) ((EventDataHistoryDetail) obj)._HealthProfessionalHistDetail))) && (object.Equals((object) this._CompensateCustomerAction, (object) ((EventDataHistoryDetail) obj)._CompensateCustomerAction) && object.Equals((object) this._ReturnedPhoneNumber, (object) ((EventDataHistoryDetail) obj)._ReturnedPhoneNumber) && (object.Equals((object) this._EventDate, (object) ((EventDataHistoryDetail) obj)._EventDate) && object.Equals((object) this._ReportDateGMT, (object) ((EventDataHistoryDetail) obj)._ReportDateGMT)) && (object.Equals((object) this._RMANumber, (object) ((EventDataHistoryDetail) obj)._RMANumber) && object.Equals((object) this._ReportDate, (object) ((EventDataHistoryDetail) obj)._ReportDate) && (object.Equals((object) this._EscalateComplaintDateGMT, (object) ((EventDataHistoryDetail) obj)._EscalateComplaintDateGMT) && object.Equals((object) this._EscalateComplaintDate, (object) ((EventDataHistoryDetail) obj)._EscalateComplaintDate))))) && (object.Equals((object) this._DateReceivedGMT, (object) ((EventDataHistoryDetail) obj)._DateReceivedGMT) && object.Equals((object) this._ReturnedContactName, (object) ((EventDataHistoryDetail) obj)._ReturnedContactName) && (object.Equals((object) this._DateReceived, (object) ((EventDataHistoryDetail) obj)._DateReceived) && object.Equals((object) this._SampleQuantity, (object) ((EventDataHistoryDetail) obj)._SampleQuantity)) && (object.Equals((object) this._HistoryId, (object) ((EventDataHistoryDetail) obj)._HistoryId) && object.Equals((object) this._RecallNumber, (object) ((EventDataHistoryDetail) obj)._RecallNumber) && (object.Equals((object) this._DeviceLocation, (object) ((EventDataHistoryDetail) obj)._DeviceLocation) && object.Equals((object) this._MaintenanceReqName, (object) ((EventDataHistoryDetail) obj)._MaintenanceReqName))) && (object.Equals((object) this._ResourceName, (object) ((EventDataHistoryDetail) obj)._ResourceName) && object.Equals((object) this._WorkflowName, (object) ((EventDataHistoryDetail) obj)._WorkflowName) && (object.Equals((object) this._WorkCenterName, (object) ((EventDataHistoryDetail) obj)._WorkCenterName) && object.Equals((object) this._ProblemDescription, (object) ((EventDataHistoryDetail) obj)._ProblemDescription)) && (object.Equals((object) this._ProductRev, (object) ((EventDataHistoryDetail) obj)._ProductRev) && object.Equals((object) this._WorkflowRev, (object) ((EventDataHistoryDetail) obj)._WorkflowRev) && (object.Equals((object) this._NonconformanceNumber, (object) ((EventDataHistoryDetail) obj)._NonconformanceNumber) && object.Equals((object) this._SpecRev, (object) ((EventDataHistoryDetail) obj)._SpecRev)))) && (object.Equals((object) this._CorrectiveActionComments, (object) ((EventDataHistoryDetail) obj)._CorrectiveActionComments) && object.Equals((object) this._MaintenanceReqRev, (object) ((EventDataHistoryDetail) obj)._MaintenanceReqRev) && (object.Equals((object) this._OperationName, (object) ((EventDataHistoryDetail) obj)._OperationName) && object.Equals((object) this._SpecName, (object) ((EventDataHistoryDetail) obj)._SpecName)) && (object.Equals((object) this._ProductName, (object) ((EventDataHistoryDetail) obj)._ProductName) && object.Equals((object) this._PreventiveActionComments, (object) ((EventDataHistoryDetail) obj)._PreventiveActionComments) && (object.Equals((object) this._FailureInvestigationComments, (object) ((EventDataHistoryDetail) obj)._FailureInvestigationComments) && object.Equals((object) this._CauseCodeName, (object) ((EventDataHistoryDetail) obj)._CauseCodeName))))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public SubentityRef ContactCustomerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCustomerHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ContactCustomerHistoryDetail));
      }
    }

    public NCRPreventiveActionHistory PreventiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionHistory), (object) value);
      }
      get
      {
        return (NCRPreventiveActionHistory) this.PropertyGet(nameof (PreventiveActionHistory));
      }
    }

    public SubentityRef ReportingCustomerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingCustomerHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ReportingCustomerHistoryDetail));
      }
    }

    public EventFailureHistoryDetail[] EventFailureHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureHistoryDetail[]) this.PropertyGet(nameof (EventFailureHistoryDetails));
      }
    }

    public EventLotHistoryDetail[] EventLotHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotHistoryDetails), (object) value);
      }
      get
      {
        return (EventLotHistoryDetail[]) this.PropertyGet(nameof (EventLotHistoryDetails));
      }
    }

    public NCRFailureInvestigationHistory FailureInvestigationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationHistory), (object) value);
      }
      get
      {
        return (NCRFailureInvestigationHistory) this.PropertyGet(nameof (FailureInvestigationHistory));
      }
    }

    public NCRCorrectiveActionHistory CorrectiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionHistory), (object) value);
      }
      get
      {
        return (NCRCorrectiveActionHistory) this.PropertyGet(nameof (CorrectiveActionHistory));
      }
    }

    public SubentityRef AdverseEventHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdverseEventHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (AdverseEventHistoryDetail));
      }
    }

    public SubentityRef EventTypeHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventTypeHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventTypeHistoryDetail));
      }
    }

    public SubentityRef DeviceOperatorHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceOperatorHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DeviceOperatorHistoryDetail));
      }
    }

    public SubentityRef ReportSourceHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportSourceHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ReportSourceHistoryDetail));
      }
    }

    public EventLogHistoryDetail[] EventLogHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogHistoryDetails), (object) value);
      }
      get
      {
        return (EventLogHistoryDetail[]) this.PropertyGet(nameof (EventLogHistoryDetails));
      }
    }

    public SubentityRef ReportFiledWithFDAHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFiledWithFDAHistDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ReportFiledWithFDAHistDetail));
      }
    }

    public SubentityRef DeviceAvailableHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceAvailableHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DeviceAvailableHistoryDetail));
      }
    }

    public SubentityRef DeviceEvaluatedHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceEvaluatedHistDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DeviceEvaluatedHistDetail));
      }
    }

    public EventFailureActionHistoryDtl[] EventFailureActionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureActionHistoryDtl[]) this.PropertyGet(nameof (EventFailureActionHistoryDetails));
      }
    }

    public SubentityRef DeviceReturnedHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceReturnedHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DeviceReturnedHistoryDetail));
      }
    }

    public SubentityRef[] SuspectDeviceHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (SuspectDeviceHistoryDetails));
      }
    }

    public NamedObjectRef Occupation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occupation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Occupation));
      }
    }

    public SubentityRef ProductProblemHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductProblemHistoryDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ProductProblemHistoryDetail));
      }
    }

    public EventCustomHistoryDetail CustomHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomHistoryDetail), (object) value);
      }
      get
      {
        return (EventCustomHistoryDetail) this.PropertyGet(nameof (CustomHistoryDetail));
      }
    }

    public SubentityRef HealthProfessionalHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessionalHistDetail), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (HealthProfessionalHistDetail));
      }
    }

    public NamedObjectRef CompensateCustomerAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompensateCustomerAction), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CompensateCustomerAction));
      }
    }

    public Primitive<string> ReturnedPhoneNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedPhoneNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReturnedPhoneNumber));
      }
    }

    public Primitive<string> EventDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDate), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EventDate));
      }
    }

    public Primitive<DateTime> ReportDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportDateGMT));
      }
    }

    public Primitive<string> RMANumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (RMANumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RMANumber));
      }
    }

    public Primitive<DateTime> ReportDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportDate));
      }
    }

    public Primitive<DateTime> EscalateComplaintDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalateComplaintDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EscalateComplaintDateGMT));
      }
    }

    public Primitive<DateTime> EscalateComplaintDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalateComplaintDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EscalateComplaintDate));
      }
    }

    public Primitive<DateTime> DateReceivedGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateReceivedGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DateReceivedGMT));
      }
    }

    public Primitive<string> ReturnedContactName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReturnedContactName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReturnedContactName));
      }
    }

    public Primitive<DateTime> DateReceived
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateReceived), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DateReceived));
      }
    }

    public Primitive<string> SampleQuantity
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleQuantity), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleQuantity));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<string> RecallNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecallNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RecallNumber));
      }
    }

    public Primitive<string> DeviceLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceLocation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DeviceLocation));
      }
    }

    public Primitive<string> MaintenanceReqName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceReqName));
      }
    }

    public Primitive<string> ResourceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ResourceName));
      }
    }

    public Primitive<string> WorkflowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowName));
      }
    }

    public Primitive<string> WorkCenterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCenterName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkCenterName));
      }
    }

    public Primitive<string> ProblemDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProblemDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProblemDescription));
      }
    }

    public Primitive<string> ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Primitive<string> WorkflowRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowRev));
      }
    }

    public Primitive<string> NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NonconformanceNumber));
      }
    }

    public Primitive<string> SpecRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecRev));
      }
    }

    public Primitive<string> CorrectiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CorrectiveActionComments));
      }
    }

    public Primitive<string> MaintenanceReqRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReqRev), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceReqRev));
      }
    }

    public Primitive<string> OperationName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OperationName));
      }
    }

    public Primitive<string> SpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SpecName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SpecName));
      }
    }

    public Primitive<string> ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProductName));
      }
    }

    public Primitive<string> PreventiveActionComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PreventiveActionComments));
      }
    }

    public Primitive<string> FailureInvestigationComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FailureInvestigationComments));
      }
    }

    public Primitive<string> CauseCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CauseCodeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CauseCodeName));
      }
    }
  }
}
