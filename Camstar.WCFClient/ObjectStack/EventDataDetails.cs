// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDataDetails
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
  public class EventDataDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventLotDetails")]
    protected EventLotDetail[] _EventLotDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventFailureDetails")]
    protected EventFailureDetail[] _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_WorkflowStack")]
    protected NamedSubentityRef[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventLogDetails")]
    protected EventLogDetail[] _EventLogDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventFailureActionDetails")]
    protected EventFailureActionDetail[] _EventFailureActionDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReportSourceField")]
    protected ReportSourceField _ReportSourceField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReportFiledWithFDAField")]
    protected ReportFiledWithFDAField _ReportFiledWithFDAField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventTypeField")]
    protected EventTypeField _EventTypeField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventCustomDetail")]
    protected EventCustomDetail _EventCustomDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_SuspectDeviceDetails")]
    protected SuspectDeviceDetail[] _SuspectDeviceDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReportingCustomerDetail")]
    protected ReportingCustomerDetail _ReportingCustomerDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_AdverseEventField")]
    protected AdverseEventField _AdverseEventField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ContactCustomerDetail")]
    protected ContactCustomerDetail _ContactCustomerDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventData")]
    protected SubentityRef _EventData;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DeviceAvailableField")]
    protected DeviceAvailableField _DeviceAvailableField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DeviceEvaluatedField")]
    protected DeviceEvaluatedField _DeviceEvaluatedField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DeviceReturnedField")]
    protected DeviceReturnedField _DeviceReturnedField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_CompensateCustomerAction")]
    protected NamedObjectRef _CompensateCustomerAction;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_HealthProfessionalField")]
    protected HealthProfessionalField _HealthProfessionalField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ProductProblemField")]
    protected ProductProblemField _ProductProblemField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DeviceOperatorField")]
    protected DeviceOperatorField _DeviceOperatorField;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_Occupation")]
    protected NamedObjectRef _Occupation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_RMANumber")]
    protected Primitive<string> _RMANumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReturnedPhoneNumber")]
    protected Primitive<string> _ReturnedPhoneNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_SampleQuantity")]
    protected Primitive<string> _SampleQuantity;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_EventDate")]
    protected Primitive<string> _EventDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DateReceived")]
    protected Primitive<DateTime> _DateReceived;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_RecallNumber")]
    protected Primitive<string> _RecallNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReportDate")]
    protected Primitive<DateTime> _ReportDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReportDateGMT")]
    protected Primitive<DateTime> _ReportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ReturnedContactName")]
    protected Primitive<string> _ReturnedContactName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DateReceivedGMT")]
    protected Primitive<DateTime> _DateReceivedGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_WorkflowRev")]
    protected Primitive<string> _WorkflowRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ProductRev")]
    protected Primitive<string> _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_SpecRev")]
    protected Primitive<string> _SpecRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_WorkflowStepName")]
    protected Primitive<string> _WorkflowStepName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_WorkflowName")]
    protected Primitive<string> _WorkflowName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_SpecName")]
    protected Primitive<string> _SpecName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_CauseCodeName")]
    protected Primitive<string> _CauseCodeName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ResourceName")]
    protected Primitive<string> _ResourceName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ProductName")]
    protected Primitive<string> _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_ProblemDescription")]
    protected Primitive<string> _ProblemDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_DeviceLocation")]
    protected Primitive<string> _DeviceLocation;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_OperationName")]
    protected Primitive<string> _OperationName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_NonconformanceNumber")]
    protected Primitive<string> _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_WorkCenterName")]
    protected Primitive<string> _WorkCenterName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_MaintenanceReqRev")]
    protected Primitive<string> _MaintenanceReqRev;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_MaintenanceReqName")]
    protected Primitive<string> _MaintenanceReqName;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_FailureInvestigationComments")]
    protected Primitive<string> _FailureInvestigationComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_PreventiveActionComments")]
    protected Primitive<string> _PreventiveActionComments;
    [DataMember(EmitDefaultValue = false, Name = "EventDataDetails_CorrectiveActionComments")]
    protected Primitive<string> _CorrectiveActionComments;

    public override bool Equals(object obj)
    {
      return obj is EventDataDetails && object.Equals((object) this._ResourceGroup, (object) ((EventDataDetails) obj)._ResourceGroup) && (this.CompareArrays((Array) this._EventLotDetails, (Array) ((EventDataDetails) obj)._EventLotDetails) && this.CompareArrays((Array) this._EventFailureDetails, (Array) ((EventDataDetails) obj)._EventFailureDetails)) && (this.CompareArrays((Array) this._WorkflowStack, (Array) ((EventDataDetails) obj)._WorkflowStack) && this.CompareArrays((Array) this._EventLogDetails, (Array) ((EventDataDetails) obj)._EventLogDetails) && (this.CompareArrays((Array) this._EventFailureActionDetails, (Array) ((EventDataDetails) obj)._EventFailureActionDetails) && object.Equals((object) this._ReportSourceField, (object) ((EventDataDetails) obj)._ReportSourceField))) && (object.Equals((object) this._ReportFiledWithFDAField, (object) ((EventDataDetails) obj)._ReportFiledWithFDAField) && object.Equals((object) this._EventTypeField, (object) ((EventDataDetails) obj)._EventTypeField) && (object.Equals((object) this._EventCustomDetail, (object) ((EventDataDetails) obj)._EventCustomDetail) && this.CompareArrays((Array) this._SuspectDeviceDetails, (Array) ((EventDataDetails) obj)._SuspectDeviceDetails)) && (object.Equals((object) this._ReportingCustomerDetail, (object) ((EventDataDetails) obj)._ReportingCustomerDetail) && object.Equals((object) this._AdverseEventField, (object) ((EventDataDetails) obj)._AdverseEventField) && (object.Equals((object) this._ContactCustomerDetail, (object) ((EventDataDetails) obj)._ContactCustomerDetail) && object.Equals((object) this._EventData, (object) ((EventDataDetails) obj)._EventData)))) && (object.Equals((object) this._DeviceAvailableField, (object) ((EventDataDetails) obj)._DeviceAvailableField) && object.Equals((object) this._DeviceEvaluatedField, (object) ((EventDataDetails) obj)._DeviceEvaluatedField) && (object.Equals((object) this._DeviceReturnedField, (object) ((EventDataDetails) obj)._DeviceReturnedField) && object.Equals((object) this._CompensateCustomerAction, (object) ((EventDataDetails) obj)._CompensateCustomerAction)) && (object.Equals((object) this._HealthProfessionalField, (object) ((EventDataDetails) obj)._HealthProfessionalField) && object.Equals((object) this._ProductProblemField, (object) ((EventDataDetails) obj)._ProductProblemField) && (object.Equals((object) this._DeviceOperatorField, (object) ((EventDataDetails) obj)._DeviceOperatorField) && object.Equals((object) this._Occupation, (object) ((EventDataDetails) obj)._Occupation))) && (object.Equals((object) this._RMANumber, (object) ((EventDataDetails) obj)._RMANumber) && object.Equals((object) this._ReturnedPhoneNumber, (object) ((EventDataDetails) obj)._ReturnedPhoneNumber) && (object.Equals((object) this._SampleQuantity, (object) ((EventDataDetails) obj)._SampleQuantity) && object.Equals((object) this._EventDate, (object) ((EventDataDetails) obj)._EventDate)) && (object.Equals((object) this._DateReceived, (object) ((EventDataDetails) obj)._DateReceived) && object.Equals((object) this._RecallNumber, (object) ((EventDataDetails) obj)._RecallNumber) && (object.Equals((object) this._ReportDate, (object) ((EventDataDetails) obj)._ReportDate) && object.Equals((object) this._ReportDateGMT, (object) ((EventDataDetails) obj)._ReportDateGMT))))) && (object.Equals((object) this._ReturnedContactName, (object) ((EventDataDetails) obj)._ReturnedContactName) && object.Equals((object) this._DateReceivedGMT, (object) ((EventDataDetails) obj)._DateReceivedGMT) && (object.Equals((object) this._WorkflowRev, (object) ((EventDataDetails) obj)._WorkflowRev) && object.Equals((object) this._ProductRev, (object) ((EventDataDetails) obj)._ProductRev)) && (object.Equals((object) this._SpecRev, (object) ((EventDataDetails) obj)._SpecRev) && object.Equals((object) this._WorkflowStepName, (object) ((EventDataDetails) obj)._WorkflowStepName) && (object.Equals((object) this._WorkflowName, (object) ((EventDataDetails) obj)._WorkflowName) && object.Equals((object) this._SpecName, (object) ((EventDataDetails) obj)._SpecName))) && (object.Equals((object) this._CauseCodeName, (object) ((EventDataDetails) obj)._CauseCodeName) && object.Equals((object) this._ResourceName, (object) ((EventDataDetails) obj)._ResourceName) && (object.Equals((object) this._ProductName, (object) ((EventDataDetails) obj)._ProductName) && object.Equals((object) this._ProblemDescription, (object) ((EventDataDetails) obj)._ProblemDescription)) && (object.Equals((object) this._DeviceLocation, (object) ((EventDataDetails) obj)._DeviceLocation) && object.Equals((object) this._OperationName, (object) ((EventDataDetails) obj)._OperationName) && (object.Equals((object) this._NonconformanceNumber, (object) ((EventDataDetails) obj)._NonconformanceNumber) && object.Equals((object) this._WorkCenterName, (object) ((EventDataDetails) obj)._WorkCenterName)))) && (object.Equals((object) this._MaintenanceReqRev, (object) ((EventDataDetails) obj)._MaintenanceReqRev) && object.Equals((object) this._MaintenanceReqName, (object) ((EventDataDetails) obj)._MaintenanceReqName) && (object.Equals((object) this._FailureInvestigationComments, (object) ((EventDataDetails) obj)._FailureInvestigationComments) && object.Equals((object) this._PreventiveActionComments, (object) ((EventDataDetails) obj)._PreventiveActionComments)) && object.Equals((object) this._CorrectiveActionComments, (object) ((EventDataDetails) obj)._CorrectiveActionComments))) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public EventLotDetail[] EventLotDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotDetails), (object) value);
      }
      get
      {
        return (EventLotDetail[]) this.PropertyGet(nameof (EventLotDetails));
      }
    }

    public EventFailureDetail[] EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail[]) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public NamedSubentityRef[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public EventLogDetail[] EventLogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogDetails), (object) value);
      }
      get
      {
        return (EventLogDetail[]) this.PropertyGet(nameof (EventLogDetails));
      }
    }

    public EventFailureActionDetail[] EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail[]) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }

    public ReportSourceField ReportSourceField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportSourceField), (object) value);
      }
      get
      {
        return (ReportSourceField) this.PropertyGet(nameof (ReportSourceField));
      }
    }

    public ReportFiledWithFDAField ReportFiledWithFDAField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportFiledWithFDAField), (object) value);
      }
      get
      {
        return (ReportFiledWithFDAField) this.PropertyGet(nameof (ReportFiledWithFDAField));
      }
    }

    public EventTypeField EventTypeField
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventTypeField), (object) value);
      }
      get
      {
        return (EventTypeField) this.PropertyGet(nameof (EventTypeField));
      }
    }

    public EventCustomDetail EventCustomDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventCustomDetail), (object) value);
      }
      get
      {
        return (EventCustomDetail) this.PropertyGet(nameof (EventCustomDetail));
      }
    }

    public SuspectDeviceDetail[] SuspectDeviceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SuspectDeviceDetails), (object) value);
      }
      get
      {
        return (SuspectDeviceDetail[]) this.PropertyGet(nameof (SuspectDeviceDetails));
      }
    }

    public ReportingCustomerDetail ReportingCustomerDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportingCustomerDetail), (object) value);
      }
      get
      {
        return (ReportingCustomerDetail) this.PropertyGet(nameof (ReportingCustomerDetail));
      }
    }

    public AdverseEventField AdverseEventField
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdverseEventField), (object) value);
      }
      get
      {
        return (AdverseEventField) this.PropertyGet(nameof (AdverseEventField));
      }
    }

    public ContactCustomerDetail ContactCustomerDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContactCustomerDetail), (object) value);
      }
      get
      {
        return (ContactCustomerDetail) this.PropertyGet(nameof (ContactCustomerDetail));
      }
    }

    public SubentityRef EventData
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventData), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (EventData));
      }
    }

    public DeviceAvailableField DeviceAvailableField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceAvailableField), (object) value);
      }
      get
      {
        return (DeviceAvailableField) this.PropertyGet(nameof (DeviceAvailableField));
      }
    }

    public DeviceEvaluatedField DeviceEvaluatedField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceEvaluatedField), (object) value);
      }
      get
      {
        return (DeviceEvaluatedField) this.PropertyGet(nameof (DeviceEvaluatedField));
      }
    }

    public DeviceReturnedField DeviceReturnedField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceReturnedField), (object) value);
      }
      get
      {
        return (DeviceReturnedField) this.PropertyGet(nameof (DeviceReturnedField));
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

    public HealthProfessionalField HealthProfessionalField
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessionalField), (object) value);
      }
      get
      {
        return (HealthProfessionalField) this.PropertyGet(nameof (HealthProfessionalField));
      }
    }

    public ProductProblemField ProductProblemField
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductProblemField), (object) value);
      }
      get
      {
        return (ProductProblemField) this.PropertyGet(nameof (ProductProblemField));
      }
    }

    public DeviceOperatorField DeviceOperatorField
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeviceOperatorField), (object) value);
      }
      get
      {
        return (DeviceOperatorField) this.PropertyGet(nameof (DeviceOperatorField));
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

    public Primitive<string> WorkflowStepName
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStepName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkflowStepName));
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
  }
}
