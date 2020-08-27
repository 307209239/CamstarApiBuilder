// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDetail_Info
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
  public class EventDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_InitiatorOrganization")]
    protected Info _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_ReporterOrganization")]
    protected Info _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_BriefDescription")]
    protected Info _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_RegulatoryReportDetails")]
    protected RegulatoryReportDetail_Info _RegulatoryReportDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_EventDataDetail")]
    protected EventDataDetails_Info _EventDataDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_ReportedDate")]
    protected Info _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_ReportedDateGMT")]
    protected Info _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_OccurrenceDateGMT")]
    protected Info _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_OccurrenceDate")]
    protected Info _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_Initiator")]
    protected Info _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_Reporter")]
    protected Info _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Info_DiscoveryArea")]
    protected Info _DiscoveryArea;

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

    public RegulatoryReportDetail_Info RegulatoryReportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportDetail_Info) this.PropertyGet(nameof (RegulatoryReportDetails));
      }
    }

    public EventDataDetails_Info EventDataDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDataDetail), (object) value);
      }
      get
      {
        return (EventDataDetails_Info) this.PropertyGet(nameof (EventDataDetail));
      }
    }

    public Info ReportedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportedDate));
      }
    }

    public Info ReportedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportedDateGMT));
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
  }
}
