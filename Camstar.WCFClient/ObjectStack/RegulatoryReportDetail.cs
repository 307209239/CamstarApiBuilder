// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryReportDetail
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
  public class RegulatoryReportDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_AttachmentRef")]
    protected NamedSubentityRef _AttachmentRef;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_RegulatoryReportType")]
    protected NamedObjectRef _RegulatoryReportType;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_RegulatoryReport")]
    protected SubentityRef _RegulatoryReport;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_RegulatoryAgency")]
    protected NamedObjectRef _RegulatoryAgency;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_DecisionTreeSummary")]
    protected RecordDecisionTreeHistory _DecisionTreeSummary;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_SubmissionDateGMT")]
    protected Primitive<DateTime> _SubmissionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_SubmissionRequired")]
    protected Primitive<bool> _SubmissionRequired;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_SubmissionDate")]
    protected Primitive<DateTime> _SubmissionDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_ReportNumber")]
    protected Primitive<string> _ReportNumber;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_CreatedBy")]
    protected NamedObjectRef _CreatedBy;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_SubmittedBy")]
    protected NamedObjectRef _SubmittedBy;

    public override bool Equals(object obj)
    {
      return obj is RegulatoryReportDetail && object.Equals((object) this._Comments, (object) ((RegulatoryReportDetail) obj)._Comments) && (object.Equals((object) this._AttachmentRef, (object) ((RegulatoryReportDetail) obj)._AttachmentRef) && object.Equals((object) this._RegulatoryReportType, (object) ((RegulatoryReportDetail) obj)._RegulatoryReportType)) && (object.Equals((object) this._RegulatoryReport, (object) ((RegulatoryReportDetail) obj)._RegulatoryReport) && object.Equals((object) this._RegulatoryAgency, (object) ((RegulatoryReportDetail) obj)._RegulatoryAgency) && (object.Equals((object) this._DecisionTreeSummary, (object) ((RegulatoryReportDetail) obj)._DecisionTreeSummary) && object.Equals((object) this._SubmissionDateGMT, (object) ((RegulatoryReportDetail) obj)._SubmissionDateGMT))) && (object.Equals((object) this._CreationDateGMT, (object) ((RegulatoryReportDetail) obj)._CreationDateGMT) && object.Equals((object) this._SubmissionRequired, (object) ((RegulatoryReportDetail) obj)._SubmissionRequired) && (object.Equals((object) this._SubmissionDate, (object) ((RegulatoryReportDetail) obj)._SubmissionDate) && object.Equals((object) this._DueDateGMT, (object) ((RegulatoryReportDetail) obj)._DueDateGMT)) && (object.Equals((object) this._DueDate, (object) ((RegulatoryReportDetail) obj)._DueDate) && object.Equals((object) this._ReportNumber, (object) ((RegulatoryReportDetail) obj)._ReportNumber) && (object.Equals((object) this._CreationDate, (object) ((RegulatoryReportDetail) obj)._CreationDate) && object.Equals((object) this._CreatedBy, (object) ((RegulatoryReportDetail) obj)._CreatedBy)))) && object.Equals((object) this._SubmittedBy, (object) ((RegulatoryReportDetail) obj)._SubmittedBy) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedSubentityRef AttachmentRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentRef), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (AttachmentRef));
      }
    }

    public NamedObjectRef RegulatoryReportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RegulatoryReportType));
      }
    }

    public SubentityRef RegulatoryReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReport), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (RegulatoryReport));
      }
    }

    public NamedObjectRef RegulatoryAgency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryAgency), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RegulatoryAgency));
      }
    }

    public RecordDecisionTreeHistory DecisionTreeSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTreeSummary), (object) value);
      }
      get
      {
        return (RecordDecisionTreeHistory) this.PropertyGet(nameof (DecisionTreeSummary));
      }
    }

    public Primitive<DateTime> SubmissionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SubmissionDateGMT));
      }
    }

    public Primitive<DateTime> CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Primitive<bool> SubmissionRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (SubmissionRequired));
      }
    }

    public Primitive<DateTime> SubmissionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (SubmissionDate));
      }
    }

    public Primitive<DateTime> DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Primitive<DateTime> DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDate));
      }
    }

    public Primitive<string> ReportNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportNumber));
      }
    }

    public Primitive<DateTime> CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CreationDate));
      }
    }

    public NamedObjectRef CreatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CreatedBy));
      }
    }

    public NamedObjectRef SubmittedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmittedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SubmittedBy));
      }
    }
  }
}
