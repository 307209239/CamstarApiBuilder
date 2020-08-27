// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgAuditTrailInquiry
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
  public class MfgAuditTrailInquiry : ContainerHistoryInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_HistorySummary")]
    protected SubentityRef[] _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_WIPMsgHistoryDetails")]
    protected SubentityRef[] _WIPMsgHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_NextLevelHistoryDetails")]
    protected SubentityRef[] _NextLevelHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_HistoryDetails")]
    protected SubentityRef[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_SelectedHistoryMainline")]
    protected BaseObjectRef _SelectedHistoryMainline;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Histories")]
    protected BaseObjectRef[] _Histories;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_AttachmentsDetails")]
    protected DocAttachmentsHistoryDetails[] _AttachmentsDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_HistoryView")]
    protected NamedObjectRef _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Attachments")]
    protected SubentityRef _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_UIPreference")]
    protected new UIPreference _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_EventLog")]
    protected Camstar.WCF.ObjectStack.EventLog[] _EventLog;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_DetailsRequested")]
    protected Enumeration<DetailsRequestTypeEnum, int> _DetailsRequested;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_AvailableHistoryDetails")]
    protected Enumeration<AvailableHistDetailsMaskEnum, int> _AvailableHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_RecordType")]
    protected new Enumeration<HistoryRecordTypeEnum, int> _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_AttachDocumentHistories")]
    protected AttachDocumentHistory[] _AttachDocumentHistories;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ContainerAttributes")]
    protected UserAttribute[] _ContainerAttributes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_TransactionFilter")]
    protected Enumeration<MfgAuditTrailTypeEnum, int> _TransactionFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_NextReversibleHMIndex")]
    protected Primitive<int> _NextReversibleHMIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_SelectedHistoryMainlineIndex")]
    protected Primitive<int> _SelectedHistoryMainlineIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ShowFullHistory")]
    protected new Primitive<bool> _ShowFullHistory;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ShowAllAvailable")]
    protected Primitive<bool> _ShowAllAvailable;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ResultsetSizeLimit")]
    protected new Primitive<int> _ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ShowAllTxnTypes")]
    protected new Primitive<bool> _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ResultsetStartRow")]
    protected new Primitive<int> _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_SelectedHistorySummaryIndex")]
    protected Primitive<int> _SelectedHistorySummaryIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_EndDate")]
    protected new Primitive<DateTime> _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_DateTimeFormat")]
    protected Primitive<string> _DateTimeFormat;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ContainerStatus")]
    protected BaseObjectRef _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_SelectCurrentOperation")]
    protected Primitive<bool> _SelectCurrentOperation;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Status")]
    protected BaseObjectRef _Status;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_SelectedHistoryDetailsIndex")]
    protected Primitive<int> _SelectedHistoryDetailsIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_SortAscending")]
    protected new Primitive<bool> _SortAscending;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_StartDate")]
    protected new Primitive<DateTime> _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ShowReversalInfo")]
    protected new Primitive<bool> _ShowReversalInfo;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_EndDateLastSec")]
    protected Primitive<DateTime> _EndDateLastSec;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_OperationFilter")]
    protected NamedObjectRef _OperationFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ResourceStatusReasonFilter")]
    protected NamedObjectRef _ResourceStatusReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ResourceStatusCodeFilter")]
    protected NamedObjectRef _ResourceStatusCodeFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ResourceFilter")]
    protected NamedObjectRef _ResourceFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_AvailabilityFilter")]
    protected Enumeration<ResourceAvailabilityEnum, int> _AvailabilityFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_ShowTxnTypes")]
    protected new Primitive<int>[] _ShowTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_EmployeeFilter")]
    protected NamedObjectRef _EmployeeFilter;

    public override bool Equals(object obj)
    {
      return obj is MfgAuditTrailInquiry && this.CompareArrays((Array) this._HistorySummary, (Array) ((MfgAuditTrailInquiry) obj)._HistorySummary) && (this.CompareArrays((Array) this._WIPMsgHistoryDetails, (Array) ((MfgAuditTrailInquiry) obj)._WIPMsgHistoryDetails) && this.CompareArrays((Array) this._NextLevelHistoryDetails, (Array) ((MfgAuditTrailInquiry) obj)._NextLevelHistoryDetails)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((MfgAuditTrailInquiry) obj)._HistoryDetails) && object.Equals((object) this._SelectedHistoryMainline, (object) ((MfgAuditTrailInquiry) obj)._SelectedHistoryMainline) && (this.CompareArrays((Array) this._Histories, (Array) ((MfgAuditTrailInquiry) obj)._Histories) && this.CompareArrays((Array) this._AttachmentsDetails, (Array) ((MfgAuditTrailInquiry) obj)._AttachmentsDetails))) && (object.Equals((object) this._HistoryView, (object) ((MfgAuditTrailInquiry) obj)._HistoryView) && object.Equals((object) this._Attachments, (object) ((MfgAuditTrailInquiry) obj)._Attachments) && (object.Equals((object) this._UIPreference, (object) ((MfgAuditTrailInquiry) obj)._UIPreference) && object.Equals((object) this._QualityObject, (object) ((MfgAuditTrailInquiry) obj)._QualityObject)) && (this.CompareArrays((Array) this._EventLog, (Array) ((MfgAuditTrailInquiry) obj)._EventLog) && object.Equals((object) this._DetailsRequested, (object) ((MfgAuditTrailInquiry) obj)._DetailsRequested) && (object.Equals((object) this._AvailableHistoryDetails, (object) ((MfgAuditTrailInquiry) obj)._AvailableHistoryDetails) && object.Equals((object) this._RecordType, (object) ((MfgAuditTrailInquiry) obj)._RecordType)))) && (this.CompareArrays((Array) this._AttachDocumentHistories, (Array) ((MfgAuditTrailInquiry) obj)._AttachDocumentHistories) && this.CompareArrays((Array) this._ContainerAttributes, (Array) ((MfgAuditTrailInquiry) obj)._ContainerAttributes) && (object.Equals((object) this._TransactionFilter, (object) ((MfgAuditTrailInquiry) obj)._TransactionFilter) && object.Equals((object) this._NextReversibleHMIndex, (object) ((MfgAuditTrailInquiry) obj)._NextReversibleHMIndex)) && (object.Equals((object) this._SelectedHistoryMainlineIndex, (object) ((MfgAuditTrailInquiry) obj)._SelectedHistoryMainlineIndex) && object.Equals((object) this._ShowFullHistory, (object) ((MfgAuditTrailInquiry) obj)._ShowFullHistory) && (object.Equals((object) this._ShowAllAvailable, (object) ((MfgAuditTrailInquiry) obj)._ShowAllAvailable) && object.Equals((object) this._ResultsetSizeLimit, (object) ((MfgAuditTrailInquiry) obj)._ResultsetSizeLimit))) && (object.Equals((object) this._ShowAllTxnTypes, (object) ((MfgAuditTrailInquiry) obj)._ShowAllTxnTypes) && object.Equals((object) this._ResultsetStartRow, (object) ((MfgAuditTrailInquiry) obj)._ResultsetStartRow) && (object.Equals((object) this._SelectedHistorySummaryIndex, (object) ((MfgAuditTrailInquiry) obj)._SelectedHistorySummaryIndex) && object.Equals((object) this._EndDate, (object) ((MfgAuditTrailInquiry) obj)._EndDate)) && (object.Equals((object) this._Container, (object) ((MfgAuditTrailInquiry) obj)._Container) && object.Equals((object) this._DateTimeFormat, (object) ((MfgAuditTrailInquiry) obj)._DateTimeFormat) && (object.Equals((object) this._ContainerStatus, (object) ((MfgAuditTrailInquiry) obj)._ContainerStatus) && object.Equals((object) this._SelectCurrentOperation, (object) ((MfgAuditTrailInquiry) obj)._SelectCurrentOperation))))) && (object.Equals((object) this._Status, (object) ((MfgAuditTrailInquiry) obj)._Status) && object.Equals((object) this._SelectedHistoryDetailsIndex, (object) ((MfgAuditTrailInquiry) obj)._SelectedHistoryDetailsIndex) && (object.Equals((object) this._SortAscending, (object) ((MfgAuditTrailInquiry) obj)._SortAscending) && object.Equals((object) this._StartDate, (object) ((MfgAuditTrailInquiry) obj)._StartDate)) && (object.Equals((object) this._ShowReversalInfo, (object) ((MfgAuditTrailInquiry) obj)._ShowReversalInfo) && object.Equals((object) this._EndDateLastSec, (object) ((MfgAuditTrailInquiry) obj)._EndDateLastSec) && (object.Equals((object) this._OperationFilter, (object) ((MfgAuditTrailInquiry) obj)._OperationFilter) && object.Equals((object) this._Resource, (object) ((MfgAuditTrailInquiry) obj)._Resource))) && (object.Equals((object) this._ResourceStatusReasonFilter, (object) ((MfgAuditTrailInquiry) obj)._ResourceStatusReasonFilter) && object.Equals((object) this._ResourceStatusCodeFilter, (object) ((MfgAuditTrailInquiry) obj)._ResourceStatusCodeFilter) && (object.Equals((object) this._ResourceFilter, (object) ((MfgAuditTrailInquiry) obj)._ResourceFilter) && object.Equals((object) this._AvailabilityFilter, (object) ((MfgAuditTrailInquiry) obj)._AvailabilityFilter)) && (this.CompareArrays((Array) this._ShowTxnTypes, (Array) ((MfgAuditTrailInquiry) obj)._ShowTxnTypes) && object.Equals((object) this._EmployeeFilter, (object) ((MfgAuditTrailInquiry) obj)._EmployeeFilter)))) && base.Equals(obj);
    }

    public SubentityRef[] HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public SubentityRef[] WIPMsgHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (WIPMsgHistoryDetails));
      }
    }

    public SubentityRef[] NextLevelHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextLevelHistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (NextLevelHistoryDetails));
      }
    }

    public SubentityRef[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public BaseObjectRef SelectedHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainline), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (SelectedHistoryMainline));
      }
    }

    public BaseObjectRef[] Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (Histories));
      }
    }

    public DocAttachmentsHistoryDetails[] AttachmentsDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails[]) this.PropertyGet(nameof (AttachmentsDetails));
      }
    }

    public NamedObjectRef HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HistoryView));
      }
    }

    public SubentityRef Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (Attachments));
      }
    }

    public new UIPreference UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference) this.PropertyGet(nameof (UIPreference));
      }
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Camstar.WCF.ObjectStack.EventLog[] EventLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLog), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.EventLog[]) this.PropertyGet(nameof (EventLog));
      }
    }

    public Enumeration<DetailsRequestTypeEnum, int> DetailsRequested
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetailsRequested), (object) value);
      }
      get
      {
        return (Enumeration<DetailsRequestTypeEnum, int>) this.PropertyGet(nameof (DetailsRequested));
      }
    }

    public Enumeration<AvailableHistDetailsMaskEnum, int> AvailableHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableHistoryDetails), (object) value);
      }
      get
      {
        return (Enumeration<AvailableHistDetailsMaskEnum, int>) this.PropertyGet(nameof (AvailableHistoryDetails));
      }
    }

    public new Enumeration<HistoryRecordTypeEnum, int> RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Enumeration<HistoryRecordTypeEnum, int>) this.PropertyGet(nameof (RecordType));
      }
    }

    public AttachDocumentHistory[] AttachDocumentHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentHistories), (object) value);
      }
      get
      {
        return (AttachDocumentHistory[]) this.PropertyGet(nameof (AttachDocumentHistories));
      }
    }

    public UserAttribute[] ContainerAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerAttributes), (object) value);
      }
      get
      {
        return (UserAttribute[]) this.PropertyGet(nameof (ContainerAttributes));
      }
    }

    public Enumeration<MfgAuditTrailTypeEnum, int> TransactionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionFilter), (object) value);
      }
      get
      {
        return (Enumeration<MfgAuditTrailTypeEnum, int>) this.PropertyGet(nameof (TransactionFilter));
      }
    }

    public Primitive<int> NextReversibleHMIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextReversibleHMIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NextReversibleHMIndex));
      }
    }

    public Primitive<int> SelectedHistoryMainlineIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainlineIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedHistoryMainlineIndex));
      }
    }

    public new Primitive<bool> ShowFullHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowFullHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowFullHistory));
      }
    }

    public Primitive<bool> ShowAllAvailable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllAvailable), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAllAvailable));
      }
    }

    public new Primitive<int> ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }

    public new Primitive<bool> ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public new Primitive<int> ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ResultsetStartRow));
      }
    }

    public Primitive<int> SelectedHistorySummaryIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistorySummaryIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedHistorySummaryIndex));
      }
    }

    public new Primitive<DateTime> EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDate));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<string> DateTimeFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateTimeFormat), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DateTimeFormat));
      }
    }

    public BaseObjectRef ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public Primitive<bool> SelectCurrentOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectCurrentOperation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SelectCurrentOperation));
      }
    }

    public BaseObjectRef Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<int> SelectedHistoryDetailsIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryDetailsIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedHistoryDetailsIndex));
      }
    }

    public new Primitive<bool> SortAscending
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortAscending), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SortAscending));
      }
    }

    public new Primitive<DateTime> StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDate));
      }
    }

    public new Primitive<bool> ShowReversalInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowReversalInfo), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowReversalInfo));
      }
    }

    public Primitive<DateTime> EndDateLastSec
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateLastSec), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDateLastSec));
      }
    }

    public NamedObjectRef OperationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (OperationFilter));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedObjectRef ResourceStatusReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusReasonFilter));
      }
    }

    public NamedObjectRef ResourceStatusCodeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusCodeFilter));
      }
    }

    public NamedObjectRef ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceFilter));
      }
    }

    public Enumeration<ResourceAvailabilityEnum, int> AvailabilityFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailabilityFilter), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (AvailabilityFilter));
      }
    }

    public new Primitive<int>[] ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (ShowTxnTypes));
      }
    }

    public NamedObjectRef EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EmployeeFilter));
      }
    }
  }
}
