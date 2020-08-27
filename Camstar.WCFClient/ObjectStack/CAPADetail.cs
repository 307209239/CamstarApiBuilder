// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPADetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CAPAReportDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPARequestDetail))]
  [Serializable]
  public class CAPADetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_PriorityLevel")]
    protected NamedObjectRef _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_AdditionalOrganizations")]
    protected NamedObjectRef[] _AdditionalOrganizations;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_CAPACustomDetail")]
    protected CAPACustomDetail _CAPACustomDetail;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_BriefDescription")]
    protected Primitive<string> _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_ReporterOrganization")]
    protected NamedObjectRef _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_CARSeverity")]
    protected NamedObjectRef _CARSeverity;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_InitiatorOrganization")]
    protected NamedObjectRef _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_ReportedDate")]
    protected Primitive<DateTime> _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_OccurrenceDate")]
    protected Primitive<DateTime> _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_ReportedDateGMT")]
    protected Primitive<DateTime> _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_IsSystemicIssue")]
    protected Primitive<bool> _IsSystemicIssue;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_OccurrenceDateGMT")]
    protected Primitive<DateTime> _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Initiator")]
    protected NamedObjectRef _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Reporter")]
    protected NamedObjectRef _Reporter;

    public override bool Equals(object obj)
    {
      return obj is CAPADetail && object.Equals((object) this._Description, (object) ((CAPADetail) obj)._Description) && (object.Equals((object) this._PriorityLevel, (object) ((CAPADetail) obj)._PriorityLevel) && this.CompareArrays((Array) this._AdditionalOrganizations, (Array) ((CAPADetail) obj)._AdditionalOrganizations)) && (object.Equals((object) this._CAPACustomDetail, (object) ((CAPADetail) obj)._CAPACustomDetail) && object.Equals((object) this._BriefDescription, (object) ((CAPADetail) obj)._BriefDescription) && (object.Equals((object) this._ReporterOrganization, (object) ((CAPADetail) obj)._ReporterOrganization) && object.Equals((object) this._CARSeverity, (object) ((CAPADetail) obj)._CARSeverity))) && (object.Equals((object) this._InitiatorOrganization, (object) ((CAPADetail) obj)._InitiatorOrganization) && object.Equals((object) this._ReportedDate, (object) ((CAPADetail) obj)._ReportedDate) && (object.Equals((object) this._OccurrenceDate, (object) ((CAPADetail) obj)._OccurrenceDate) && object.Equals((object) this._ReportedDateGMT, (object) ((CAPADetail) obj)._ReportedDateGMT)) && (object.Equals((object) this._IsSystemicIssue, (object) ((CAPADetail) obj)._IsSystemicIssue) && object.Equals((object) this._OccurrenceDateGMT, (object) ((CAPADetail) obj)._OccurrenceDateGMT) && (object.Equals((object) this._Initiator, (object) ((CAPADetail) obj)._Initiator) && object.Equals((object) this._Reporter, (object) ((CAPADetail) obj)._Reporter)))) && base.Equals(obj);
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

    public CAPACustomDetail CAPACustomDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPACustomDetail), (object) value);
      }
      get
      {
        return (CAPACustomDetail) this.PropertyGet(nameof (CAPACustomDetail));
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
