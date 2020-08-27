// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventDetail
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
  public class EventDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_InitiatorOrganization")]
    protected NamedObjectRef _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_ReporterOrganization")]
    protected NamedObjectRef _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_RegulatoryReportDetails")]
    protected RegulatoryReportDetail[] _RegulatoryReportDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_EventDataDetail")]
    protected EventDataDetails _EventDataDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_ReportedDate")]
    protected Primitive<DateTime> _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_ReportedDateGMT")]
    protected Primitive<DateTime> _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_OccurrenceDate")]
    protected Primitive<DateTime> _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Initiator")]
    protected NamedObjectRef _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_Reporter")]
    protected NamedObjectRef _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "EventDetail_DiscoveryArea")]
    protected Primitive<string> _DiscoveryArea;

    public override bool Equals(object obj)
    {
      return obj is EventDetail && object.Equals((object) this._PriorityLevel, (object) ((EventDetail) obj)._PriorityLevel) && (object.Equals((object) this._Description, (object) ((EventDetail) obj)._Description) && object.Equals((object) this._InitiatorOrganization, (object) ((EventDetail) obj)._InitiatorOrganization)) && (object.Equals((object) this._ReporterOrganization, (object) ((EventDetail) obj)._ReporterOrganization) && object.Equals((object) this._BriefDescription, (object) ((EventDetail) obj)._BriefDescription) && (this.CompareArrays((Array) this._RegulatoryReportDetails, (Array) ((EventDetail) obj)._RegulatoryReportDetails) && object.Equals((object) this._EventDataDetail, (object) ((EventDetail) obj)._EventDataDetail))) && (object.Equals((object) this._ReportedDate, (object) ((EventDetail) obj)._ReportedDate) && object.Equals((object) this._ReportedDateGMT, (object) ((EventDetail) obj)._ReportedDateGMT) && (object.Equals((object) this._OccurrenceDateGMT, (object) ((EventDetail) obj)._OccurrenceDateGMT) && object.Equals((object) this._OccurrenceDate, (object) ((EventDetail) obj)._OccurrenceDate)) && (object.Equals((object) this._Initiator, (object) ((EventDetail) obj)._Initiator) && object.Equals((object) this._Reporter, (object) ((EventDetail) obj)._Reporter) && object.Equals((object) this._DiscoveryArea, (object) ((EventDetail) obj)._DiscoveryArea))) && base.Equals(obj);
    }

    public NamedObjectRef PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public NamedObjectRef InitiatorOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrganization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (InitiatorOrganization));
      }
    }

    public NamedObjectRef ReporterOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrganization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReporterOrganization));
      }
    }

    public Primitive<string> BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public RegulatoryReportDetail[] RegulatoryReportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportDetail[]) this.PropertyGet(nameof (RegulatoryReportDetails));
      }
    }

    public EventDataDetails EventDataDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDataDetail), (object) value);
      }
      get
      {
        return (EventDataDetails) this.PropertyGet(nameof (EventDataDetail));
      }
    }

    public Primitive<DateTime> ReportedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportedDate));
      }
    }

    public Primitive<DateTime> ReportedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ReportedDateGMT));
      }
    }

    public Primitive<DateTime> OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Primitive<DateTime> OccurrenceDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (OccurrenceDate));
      }
    }

    public NamedObjectRef Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Initiator));
      }
    }

    public NamedObjectRef Reporter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reporter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Reporter));
      }
    }

    public Primitive<string> DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DiscoveryArea));
      }
    }
  }
}
