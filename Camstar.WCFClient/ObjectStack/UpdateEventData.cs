// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventData
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
  public class UpdateEventData : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_ReporterOrganization")]
    protected NamedObjectRef _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_InitiatorOrganization")]
    protected NamedObjectRef _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_QualityResolutionCode")]
    protected NamedObjectRef _QualityResolutionCode;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_EventDataDetail")]
    protected EventDataDetails _EventDataDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_RegulatoryReportDetails")]
    protected RegulatoryReportDetail[] _RegulatoryReportDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_DisallowedTxns")]
    protected Primitive<int>[] _DisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_OccurrenceDate")]
    protected Primitive<DateTime> _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_ReportedDate")]
    protected Primitive<DateTime> _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_ReportedDateGMT")]
    protected Primitive<DateTime> _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_DiscoveryArea")]
    protected Primitive<string> _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_CloseDescription")]
    protected Primitive<string> _CloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Initiator")]
    protected NamedObjectRef _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Reporter")]
    protected NamedObjectRef _Reporter;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventData && object.Equals((object) this._ReporterOrganization, (object) ((UpdateEventData) obj)._ReporterOrganization) && (object.Equals((object) this._PriorityLevel, (object) ((UpdateEventData) obj)._PriorityLevel) && object.Equals((object) this._InitiatorOrganization, (object) ((UpdateEventData) obj)._InitiatorOrganization)) && (object.Equals((object) this._Description, (object) ((UpdateEventData) obj)._Description) && object.Equals((object) this._QualityResolutionCode, (object) ((UpdateEventData) obj)._QualityResolutionCode) && (object.Equals((object) this._EventDataDetail, (object) ((UpdateEventData) obj)._EventDataDetail) && this.CompareArrays((Array) this._RegulatoryReportDetails, (Array) ((UpdateEventData) obj)._RegulatoryReportDetails))) && (object.Equals((object) this._BriefDescription, (object) ((UpdateEventData) obj)._BriefDescription) && this.CompareArrays((Array) this._DisallowedTxns, (Array) ((UpdateEventData) obj)._DisallowedTxns) && (object.Equals((object) this._OccurrenceDateGMT, (object) ((UpdateEventData) obj)._OccurrenceDateGMT) && object.Equals((object) this._OccurrenceDate, (object) ((UpdateEventData) obj)._OccurrenceDate)) && (object.Equals((object) this._ReportedDate, (object) ((UpdateEventData) obj)._ReportedDate) && object.Equals((object) this._ReportedDateGMT, (object) ((UpdateEventData) obj)._ReportedDateGMT) && (object.Equals((object) this._DiscoveryArea, (object) ((UpdateEventData) obj)._DiscoveryArea) && object.Equals((object) this._CloseDescription, (object) ((UpdateEventData) obj)._CloseDescription)))) && (object.Equals((object) this._Initiator, (object) ((UpdateEventData) obj)._Initiator) && object.Equals((object) this._Reporter, (object) ((UpdateEventData) obj)._Reporter)) && base.Equals(obj);
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

    public NamedObjectRef QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityResolutionCode));
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

    public Primitive<int>[] DisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DisallowedTxns));
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

    public Primitive<string> CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CloseDescription));
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
  }
}
