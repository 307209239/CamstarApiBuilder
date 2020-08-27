// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPAHistoryDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPAReportHistoryDetail))]
  [KnownType(typeof (CAPARequestHistoryDetail))]
  [Serializable]
  public class CAPAHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_InitiatorOrganization")]
    protected NamedObjectRef _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_CustomHistoryDetail")]
    protected CAPACustomHistoryDetail _CustomHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_AdditionalOrganizations")]
    protected NamedObjectRef[] _AdditionalOrganizations;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_CARSeverity")]
    protected NamedObjectRef _CARSeverity;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_ReporterOrganization")]
    protected NamedObjectRef _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_OccurrenceDate")]
    protected Primitive<DateTime> _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_ReportedDateGMT")]
    protected Primitive<DateTime> _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_ReportedDate")]
    protected Primitive<DateTime> _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_IsSystemicIssue")]
    protected Primitive<bool> _IsSystemicIssue;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Initiator")]
    protected NamedObjectRef _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Reporter")]
    protected NamedObjectRef _Reporter;

    public override bool Equals(object obj)
    {
      return obj is CAPAHistoryDetail && object.Equals((object) this._PriorityLevel, (object) ((CAPAHistoryDetail) obj)._PriorityLevel) && (object.Equals((object) this._ExportImportKey, (object) ((CAPAHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._Description, (object) ((CAPAHistoryDetail) obj)._Description)) && (object.Equals((object) this._InitiatorOrganization, (object) ((CAPAHistoryDetail) obj)._InitiatorOrganization) && object.Equals((object) this._CustomHistoryDetail, (object) ((CAPAHistoryDetail) obj)._CustomHistoryDetail) && (this.CompareArrays((Array) this._AdditionalOrganizations, (Array) ((CAPAHistoryDetail) obj)._AdditionalOrganizations) && object.Equals((object) this._BriefDescription, (object) ((CAPAHistoryDetail) obj)._BriefDescription))) && (object.Equals((object) this._CARSeverity, (object) ((CAPAHistoryDetail) obj)._CARSeverity) && object.Equals((object) this._ReporterOrganization, (object) ((CAPAHistoryDetail) obj)._ReporterOrganization) && (object.Equals((object) this._OccurrenceDate, (object) ((CAPAHistoryDetail) obj)._OccurrenceDate) && object.Equals((object) this._HistoryId, (object) ((CAPAHistoryDetail) obj)._HistoryId)) && (object.Equals((object) this._ReportedDateGMT, (object) ((CAPAHistoryDetail) obj)._ReportedDateGMT) && object.Equals((object) this._ReportedDate, (object) ((CAPAHistoryDetail) obj)._ReportedDate) && (object.Equals((object) this._OccurrenceDateGMT, (object) ((CAPAHistoryDetail) obj)._OccurrenceDateGMT) && object.Equals((object) this._IsSystemicIssue, (object) ((CAPAHistoryDetail) obj)._IsSystemicIssue)))) && (object.Equals((object) this._Initiator, (object) ((CAPAHistoryDetail) obj)._Initiator) && object.Equals((object) this._Reporter, (object) ((CAPAHistoryDetail) obj)._Reporter)) && base.Equals(obj);
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

    public CAPACustomHistoryDetail CustomHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomHistoryDetail), (object) value);
      }
      get
      {
        return (CAPACustomHistoryDetail) this.PropertyGet(nameof (CustomHistoryDetail));
      }
    }

    public NamedObjectRef[] AdditionalOrganizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalOrganizations), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (AdditionalOrganizations));
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

    public NamedObjectRef CARSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARSeverity), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CARSeverity));
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

    public Primitive<bool> IsSystemicIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSystemicIssue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsSystemicIssue));
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
