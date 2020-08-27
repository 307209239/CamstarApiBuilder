// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgAuditTrailInquiry_Info
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
  public class MfgAuditTrailInquiry_Info : ContainerHistoryInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_HistorySummary")]
    protected Info _HistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_WIPMsgHistoryDetails")]
    protected Info _WIPMsgHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_NextLevelHistoryDetails")]
    protected Info _NextLevelHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_HistoryDetails")]
    protected Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_SelectedHistoryMainline")]
    protected Info _SelectedHistoryMainline;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_Histories")]
    protected Info _Histories;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_AttachmentsDetails")]
    protected DocAttachmentsHistoryDetails_Info _AttachmentsDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_HistoryView")]
    protected Info _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_Attachments")]
    protected Info _Attachments;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_UIPreference")]
    protected new UIPreference_Info _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_EventLog")]
    protected EventLog_Info _EventLog;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_DetailsRequested")]
    protected Info _DetailsRequested;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_AvailableHistoryDetails")]
    protected Info _AvailableHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_RecordType")]
    protected new Info _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_AttachDocumentHistories")]
    protected AttachDocumentHistory_Info _AttachDocumentHistories;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ContainerAttributes")]
    protected UserAttribute_Info _ContainerAttributes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_TransactionFilter")]
    protected Info _TransactionFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_NextReversibleHMIndex")]
    protected Info _NextReversibleHMIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_SelectedHistoryMainlineIndex")]
    protected Info _SelectedHistoryMainlineIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ShowFullHistory")]
    protected new Info _ShowFullHistory;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ShowAllAvailable")]
    protected Info _ShowAllAvailable;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ResultsetSizeLimit")]
    protected new Info _ResultsetSizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ShowAllTxnTypes")]
    protected new Info _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ResultsetStartRow")]
    protected new Info _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_SelectedHistorySummaryIndex")]
    protected Info _SelectedHistorySummaryIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_EndDate")]
    protected new Info _EndDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_DateTimeFormat")]
    protected Info _DateTimeFormat;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ContainerStatus")]
    protected Info _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_SelectCurrentOperation")]
    protected Info _SelectCurrentOperation;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_Status")]
    protected Info _Status;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_SelectedHistoryDetailsIndex")]
    protected Info _SelectedHistoryDetailsIndex;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_SortAscending")]
    protected new Info _SortAscending;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_StartDate")]
    protected new Info _StartDate;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ShowReversalInfo")]
    protected new Info _ShowReversalInfo;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_EndDateLastSec")]
    protected Info _EndDateLastSec;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_OperationFilter")]
    protected Info _OperationFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ResourceStatusReasonFilter")]
    protected Info _ResourceStatusReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ResourceStatusCodeFilter")]
    protected Info _ResourceStatusCodeFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ResourceFilter")]
    protected Info _ResourceFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_AvailabilityFilter")]
    protected Info _AvailabilityFilter;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_ShowTxnTypes")]
    protected new Info _ShowTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "MfgAuditTrailInquiry_Info_EmployeeFilter")]
    protected Info _EmployeeFilter;

    public Info HistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistorySummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistorySummary));
      }
    }

    public Info WIPMsgHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgHistoryDetails));
      }
    }

    public Info NextLevelHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextLevelHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextLevelHistoryDetails));
      }
    }

    public Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info SelectedHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainline), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistoryMainline));
      }
    }

    public Info Histories
    {
      [param: In] set
      {
        this.PropertySet(nameof (Histories), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Histories));
      }
    }

    public DocAttachmentsHistoryDetails_Info AttachmentsDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentsDetails), (object) value);
      }
      get
      {
        return (DocAttachmentsHistoryDetails_Info) this.PropertyGet(nameof (AttachmentsDetails));
      }
    }

    public Info HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryView));
      }
    }

    public Info Attachments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Attachments));
      }
    }

    public new UIPreference_Info UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference_Info) this.PropertyGet(nameof (UIPreference));
      }
    }

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public EventLog_Info EventLog
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLog), (object) value);
      }
      get
      {
        return (EventLog_Info) this.PropertyGet(nameof (EventLog));
      }
    }

    public Info DetailsRequested
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetailsRequested), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DetailsRequested));
      }
    }

    public Info AvailableHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableHistoryDetails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AvailableHistoryDetails));
      }
    }

    public new Info RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordType));
      }
    }

    public AttachDocumentHistory_Info AttachDocumentHistories
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentHistories), (object) value);
      }
      get
      {
        return (AttachDocumentHistory_Info) this.PropertyGet(nameof (AttachDocumentHistories));
      }
    }

    public UserAttribute_Info ContainerAttributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerAttributes), (object) value);
      }
      get
      {
        return (UserAttribute_Info) this.PropertyGet(nameof (ContainerAttributes));
      }
    }

    public Info TransactionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransactionFilter));
      }
    }

    public Info NextReversibleHMIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (NextReversibleHMIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NextReversibleHMIndex));
      }
    }

    public Info SelectedHistoryMainlineIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainlineIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistoryMainlineIndex));
      }
    }

    public new Info ShowFullHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowFullHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowFullHistory));
      }
    }

    public Info ShowAllAvailable
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllAvailable), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowAllAvailable));
      }
    }

    public new Info ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }

    public new Info ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public new Info ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResultsetStartRow));
      }
    }

    public Info SelectedHistorySummaryIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistorySummaryIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistorySummaryIndex));
      }
    }

    public new Info EndDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDate));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info DateTimeFormat
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateTimeFormat), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DateTimeFormat));
      }
    }

    public Info ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public Info SelectCurrentOperation
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectCurrentOperation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectCurrentOperation));
      }
    }

    public Info Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Status));
      }
    }

    public Info SelectedHistoryDetailsIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryDetailsIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistoryDetailsIndex));
      }
    }

    public new Info SortAscending
    {
      [param: In] set
      {
        this.PropertySet(nameof (SortAscending), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SortAscending));
      }
    }

    public new Info StartDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartDate));
      }
    }

    public new Info ShowReversalInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowReversalInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowReversalInfo));
      }
    }

    public Info EndDateLastSec
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateLastSec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDateLastSec));
      }
    }

    public Info OperationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (OperationFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OperationFilter));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info ResourceStatusReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReasonFilter));
      }
    }

    public Info ResourceStatusCodeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCodeFilter));
      }
    }

    public Info ResourceFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceFilter));
      }
    }

    public Info AvailabilityFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailabilityFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AvailabilityFilter));
      }
    }

    public new Info ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowTxnTypes));
      }
    }

    public Info EmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (EmployeeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EmployeeFilter));
      }
    }
  }
}
