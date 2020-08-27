// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDataHistoryDetail_Environment
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
  public class EventDataHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("History for the EventCustomerDetail.", "CustomerHistoryDetail", false, false, true, "SubentityRef", 1052527, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ContactCustomerHistoryDetail")]
    protected Environment _ContactCustomerHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_PreventiveActionHistory")]
    [Metadata("Preventive action history comments.", "NCRPreventiveActionHistory", false, false, true, "NCRPreventiveActionHistory", 1050442, false, false, false, null)]
    protected NCRPreventiveActionHistory_Environment _PreventiveActionHistory;
    [Metadata("History for the EventCustomerDetail.", "CustomerHistoryDetail", false, false, true, "SubentityRef", 1052523, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReportingCustomerHistoryDetail")]
    protected Environment _ReportingCustomerHistoryDetail;
    [Metadata("History for the EventFailureDetail.", "EventFailureHistoryDetail", false, false, true, "EventFailureHistoryDetail", 1051075, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EventFailureHistoryDetails")]
    protected EventFailureHistoryDetail_Environment _EventFailureHistoryDetails;
    [Metadata("History for the EventLotDetail.", "EventLotHistoryDetail", false, false, true, "EventLotHistoryDetail", 1051076, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EventLotHistoryDetails")]
    protected EventLotHistoryDetail_Environment _EventLotHistoryDetails;
    [Metadata("Failure investigation history comments.", "NCRFailureInvestigationHistory", false, false, true, "NCRFailureInvestigationHistory", 1050443, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_FailureInvestigationHistory")]
    protected NCRFailureInvestigationHistory_Environment _FailureInvestigationHistory;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_CorrectiveActionHistory")]
    [Metadata("Corrective action history comments.", "NCRCorrectiveActionHistory", false, false, true, "NCRCorrectiveActionHistory", 1050441, false, false, false, null)]
    protected NCRCorrectiveActionHistory_Environment _CorrectiveActionHistory;
    [Metadata("Adverse event occured using the product.", "AdverseEventHistoryDetail", false, false, true, "SubentityRef", 1052516, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_AdverseEventHistoryDetail")]
    protected Environment _AdverseEventHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EventTypeHistoryDetail")]
    [Metadata("EventTypeHistoryDetail history", "EventTypeHistoryDetail", false, false, true, "SubentityRef", 1052519, false, false, false, null)]
    protected Environment _EventTypeHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DeviceOperatorHistoryDetail")]
    [Metadata("DeviceOperatorHistoryDetail history", "DeviceOperatorHistoryDetail", false, false, true, "SubentityRef", 1052525, false, false, false, null)]
    protected Environment _DeviceOperatorHistoryDetail;
    [Metadata("ReportSourceHistoryDetail history", "ReportSourceHistoryDetail", false, false, true, "SubentityRef", 1051331, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReportSourceHistoryDetail")]
    protected Environment _ReportSourceHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EventLogHistoryDetails")]
    [Metadata("History for the EventLog.", "EventLogHistoryDetail", false, false, true, "EventLogHistoryDetail", 1052960, false, true, false, null)]
    protected EventLogHistoryDetail_Environment _EventLogHistoryDetails;
    [Metadata("ReportFiledWithFDA history", "ReportFiledWithFDAHistDetail", false, false, true, "SubentityRef", 1052522, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReportFiledWithFDAHistDetail")]
    protected Environment _ReportFiledWithFDAHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DeviceAvailableHistoryDetail")]
    [Metadata("Device available for evaluation.", "DeviceAvailableHistoryDetail", false, false, true, "SubentityRef", 1052517, false, false, false, null)]
    protected Environment _DeviceAvailableHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DeviceEvaluatedHistDetail")]
    [Metadata("DeviceEvaluatedHistDetail history", "DeviceEvaluatedHistDetail", false, false, true, "SubentityRef", 1052518, false, false, false, null)]
    protected Environment _DeviceEvaluatedHistDetail;
    [Metadata("EventFailureActionHistoryDtl", "EventFailureActionHistoryDtl", false, false, true, "EventFailureActionHistoryDtl", 1052969, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EventFailureActionHistoryDetails")]
    protected EventFailureActionHistoryDtl_Environment _EventFailureActionHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DeviceReturnedHistoryDetail")]
    [Metadata("DeviceReturnedHistoryDetail history", "DeviceReturnedHistoryDetail", false, false, true, "SubentityRef", 1052526, false, false, false, null)]
    protected Environment _DeviceReturnedHistoryDetail;
    [Metadata("History for the SuspectDeviceDetail.", "SuspectDeviceHistoryDetail", false, false, true, "SubentityRef", 1052524, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_SuspectDeviceHistoryDetails")]
    protected Environment _SuspectDeviceHistoryDetails;
    [Metadata("A list of jobs available for selection in the MedWatch report.", "Occupation", false, false, true, "NamedObjectRef", 1051269, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_Occupation")]
    protected Environment _Occupation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ProductProblemHistoryDetail")]
    [Metadata("Problem with the product.", "ProductProblemHistoryDetail", false, false, true, "SubentityRef", 1052521, false, false, false, null)]
    protected Environment _ProductProblemHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_CustomHistoryDetail")]
    [Metadata("Used to record history of customer extensions to Event", "EventCustomHistoryDetail", false, false, true, "EventCustomHistoryDetail", 1052472, false, false, false, null)]
    protected EventCustomHistoryDetail_Environment _CustomHistoryDetail;
    [Metadata("HealthProfessionalHistDetail history", "HealthProfessionalHistDetail", false, false, true, "SubentityRef", 1052520, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_HealthProfessionalHistDetail")]
    protected Environment _HealthProfessionalHistDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_CompensateCustomerAction")]
    [Metadata("Action taken for returned equipment.", "ReturnedEquipmentAction", false, false, true, "NamedObjectRef", 1052485, false, false, false, null)]
    protected Environment _CompensateCustomerAction;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReturnedPhoneNumber")]
    [Metadata("Generic String", "", false, false, true, "String", 1051440, false, false, false, null)]
    protected Environment _ReturnedPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EventDate")]
    [Metadata("Generic String", "", false, false, true, "String", 1052494, false, false, false, null)]
    protected Environment _EventDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReportDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052497, false, false, false, null)]
    protected Environment _ReportDateGMT;
    [Metadata("Generic String", "", false, false, true, "String", 1051275, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_RMANumber")]
    protected Environment _RMANumber;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052496, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReportDate")]
    protected Environment _ReportDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051727, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EscalateComplaintDateGMT")]
    protected Environment _EscalateComplaintDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_EscalateComplaintDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051726, false, false, false, null)]
    protected Environment _EscalateComplaintDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DateReceivedGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052487, false, false, false, null)]
    protected Environment _DateReceivedGMT;
    [Metadata("Generic String", "", false, false, true, "String", 1051441, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ReturnedContactName")]
    protected Environment _ReturnedContactName;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052486, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DateReceived")]
    protected Environment _DateReceived;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_SampleQuantity")]
    [Metadata("Generic String", "", false, false, true, "String", 1051276, false, false, false, null)]
    protected Environment _SampleQuantity;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_RecallNumber")]
    [Metadata("Generic String", "", false, false, true, "String", 1051271, false, false, false, null)]
    protected Environment _RecallNumber;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052490, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_DeviceLocation")]
    protected Environment _DeviceLocation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_MaintenanceReqName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050680, false, false, false, null)]
    protected Environment _MaintenanceReqName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049575, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ResourceName")]
    protected Environment _ResourceName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050233, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_WorkflowName")]
    protected Environment _WorkflowName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050129, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_WorkCenterName")]
    protected Environment _WorkCenterName;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051270, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ProblemDescription")]
    protected Environment _ProblemDescription;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049573, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ProductRev")]
    protected Environment _ProductRev;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1051152, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_WorkflowRev")]
    protected Environment _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_NonconformanceNumber")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050601, false, false, false, null)]
    protected Environment _NonconformanceNumber;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1049578, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_SpecRev")]
    protected Environment _SpecRev;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050433, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_CorrectiveActionComments")]
    protected Environment _CorrectiveActionComments;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051172, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_MaintenanceReqRev")]
    protected Environment _MaintenanceReqRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_OperationName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049568, false, false, false, null)]
    protected Environment _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_SpecName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050232, false, false, false, null)]
    protected Environment _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_ProductName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048709, false, false, false, null)]
    protected Environment _ProductName;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050432, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_PreventiveActionComments")]
    protected Environment _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_FailureInvestigationComments")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1050434, false, false, false, null)]
    protected Environment _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataHistoryDetail_Environment_CauseCodeName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051782, false, false, false, null)]
    protected Environment _CauseCodeName;

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

    public Environment ContactCustomerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCustomerHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContactCustomerHistoryDetail));
      }
    }

    public NCRPreventiveActionHistory_Environment PreventiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (PreventiveActionHistory), (object) value);
      }
      get
      {
        return (NCRPreventiveActionHistory_Environment) this.PropertyGet(nameof (PreventiveActionHistory));
      }
    }

    public Environment ReportingCustomerHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingCustomerHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportingCustomerHistoryDetail));
      }
    }

    public EventFailureHistoryDetail_Environment EventFailureHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureHistoryDetail_Environment) this.PropertyGet(nameof (EventFailureHistoryDetails));
      }
    }

    public EventLotHistoryDetail_Environment EventLotHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotHistoryDetails), (object) value);
      }
      get
      {
        return (EventLotHistoryDetail_Environment) this.PropertyGet(nameof (EventLotHistoryDetails));
      }
    }

    public NCRFailureInvestigationHistory_Environment FailureInvestigationHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailureInvestigationHistory), (object) value);
      }
      get
      {
        return (NCRFailureInvestigationHistory_Environment) this.PropertyGet(nameof (FailureInvestigationHistory));
      }
    }

    public NCRCorrectiveActionHistory_Environment CorrectiveActionHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CorrectiveActionHistory), (object) value);
      }
      get
      {
        return (NCRCorrectiveActionHistory_Environment) this.PropertyGet(nameof (CorrectiveActionHistory));
      }
    }

    public Environment AdverseEventHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdverseEventHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdverseEventHistoryDetail));
      }
    }

    public Environment EventTypeHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventTypeHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventTypeHistoryDetail));
      }
    }

    public Environment DeviceOperatorHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceOperatorHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceOperatorHistoryDetail));
      }
    }

    public Environment ReportSourceHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportSourceHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportSourceHistoryDetail));
      }
    }

    public EventLogHistoryDetail_Environment EventLogHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogHistoryDetails), (object) value);
      }
      get
      {
        return (EventLogHistoryDetail_Environment) this.PropertyGet(nameof (EventLogHistoryDetails));
      }
    }

    public Environment ReportFiledWithFDAHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFiledWithFDAHistDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportFiledWithFDAHistDetail));
      }
    }

    public Environment DeviceAvailableHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceAvailableHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceAvailableHistoryDetail));
      }
    }

    public Environment DeviceEvaluatedHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceEvaluatedHistDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceEvaluatedHistDetail));
      }
    }

    public EventFailureActionHistoryDtl_Environment EventFailureActionHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionHistoryDetails), (object) value);
      }
      get
      {
        return (EventFailureActionHistoryDtl_Environment) this.PropertyGet(nameof (EventFailureActionHistoryDetails));
      }
    }

    public Environment DeviceReturnedHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceReturnedHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeviceReturnedHistoryDetail));
      }
    }

    public Environment SuspectDeviceHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceHistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SuspectDeviceHistoryDetails));
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

    public Environment ProductProblemHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductProblemHistoryDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductProblemHistoryDetail));
      }
    }

    public EventCustomHistoryDetail_Environment CustomHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomHistoryDetail), (object) value);
      }
      get
      {
        return (EventCustomHistoryDetail_Environment) this.PropertyGet(nameof (CustomHistoryDetail));
      }
    }

    public Environment HealthProfessionalHistDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessionalHistDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HealthProfessionalHistDetail));
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

    public Environment EscalateComplaintDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalateComplaintDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalateComplaintDateGMT));
      }
    }

    public Environment EscalateComplaintDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EscalateComplaintDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EscalateComplaintDate));
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
  }
}
