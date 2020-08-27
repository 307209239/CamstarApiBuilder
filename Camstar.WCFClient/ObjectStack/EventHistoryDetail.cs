// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventHistoryDetail
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
  public class EventHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_EventDataHistoryDetail")]
    protected EventDataHistoryDetail _EventDataHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_ReporterOrganization")]
    protected NamedObjectRef _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_InitiatorOrganization")]
    protected NamedObjectRef _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_RegulatoryReportHistoryDetails")]
    protected RegulatoryReportHistoryDetail[] _RegulatoryReportHistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_OccurrenceDate")]
    protected Primitive<DateTime> _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_DiscoveryArea")]
    protected Primitive<string> _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_NonconformanceNumber")]
    protected Primitive<string> _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Reporter")]
    protected NamedObjectRef _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Initiator")]
    protected NamedObjectRef _Initiator;

    public override bool Equals(object obj)
    {
      return obj is EventHistoryDetail && object.Equals((object) this._PriorityLevel, (object) ((EventHistoryDetail) obj)._PriorityLevel) && (object.Equals((object) this._ExportImportKey, (object) ((EventHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._Description, (object) ((EventHistoryDetail) obj)._Description)) && (object.Equals((object) this._EventDataHistoryDetail, (object) ((EventHistoryDetail) obj)._EventDataHistoryDetail) && object.Equals((object) this._BriefDescription, (object) ((EventHistoryDetail) obj)._BriefDescription) && (object.Equals((object) this._ReporterOrganization, (object) ((EventHistoryDetail) obj)._ReporterOrganization) && object.Equals((object) this._InitiatorOrganization, (object) ((EventHistoryDetail) obj)._InitiatorOrganization))) && (this.CompareArrays((Array) this._RegulatoryReportHistoryDetails, (Array) ((EventHistoryDetail) obj)._RegulatoryReportHistoryDetails) && object.Equals((object) this._OccurrenceDate, (object) ((EventHistoryDetail) obj)._OccurrenceDate) && (object.Equals((object) this._HistoryId, (object) ((EventHistoryDetail) obj)._HistoryId) && object.Equals((object) this._OccurrenceDateGMT, (object) ((EventHistoryDetail) obj)._OccurrenceDateGMT)) && (object.Equals((object) this._DiscoveryArea, (object) ((EventHistoryDetail) obj)._DiscoveryArea) && object.Equals((object) this._NonconformanceNumber, (object) ((EventHistoryDetail) obj)._NonconformanceNumber) && (object.Equals((object) this._Reporter, (object) ((EventHistoryDetail) obj)._Reporter) && object.Equals((object) this._Initiator, (object) ((EventHistoryDetail) obj)._Initiator)))) && base.Equals(obj);
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

    public EventDataHistoryDetail EventDataHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDataHistoryDetail), (object) value);
      }
      get
      {
        return (EventDataHistoryDetail) this.PropertyGet(nameof (EventDataHistoryDetail));
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

    public RegulatoryReportHistoryDetail[] RegulatoryReportHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportHistoryDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportHistoryDetail[]) this.PropertyGet(nameof (RegulatoryReportHistoryDetails));
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
  }
}
