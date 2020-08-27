// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventHistoryDetail_Info
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
  public class EventHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_EventDataHistoryDetail")]
    protected EventDataHistoryDetail_Info _EventDataHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_BriefDescription")]
    protected Info _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_ReporterOrganization")]
    protected Info _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_InitiatorOrganization")]
    protected Info _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_RegulatoryReportHistoryDetails")]
    protected RegulatoryReportHistoryDetail_Info _RegulatoryReportHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_OccurrenceDate")]
    protected Info _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_OccurrenceDateGMT")]
    protected Info _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_DiscoveryArea")]
    protected Info _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_NonconformanceNumber")]
    protected Info _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_Reporter")]
    protected Info _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Info_Initiator")]
    protected Info _Initiator;

    public Info PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PriorityLevel));
      }
    }

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

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public EventDataHistoryDetail_Info EventDataHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDataHistoryDetail), (object) value);
      }
      get
      {
        return (EventDataHistoryDetail_Info) this.PropertyGet(nameof (EventDataHistoryDetail));
      }
    }

    public Info BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public Info ReporterOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrganization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReporterOrganization));
      }
    }

    public Info InitiatorOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrganization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitiatorOrganization));
      }
    }

    public RegulatoryReportHistoryDetail_Info RegulatoryReportHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportHistoryDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportHistoryDetail_Info) this.PropertyGet(nameof (RegulatoryReportHistoryDetails));
      }
    }

    public Info OccurrenceDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccurrenceDate));
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

    public Info OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Info DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DiscoveryArea));
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

    public Info Reporter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reporter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Reporter));
      }
    }

    public Info Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Initiator));
      }
    }
  }
}
