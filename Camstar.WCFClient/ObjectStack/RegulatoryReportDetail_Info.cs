// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryReportDetail_Info
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
  public class RegulatoryReportDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_AttachmentRef")]
    protected Info _AttachmentRef;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_RegulatoryReportType")]
    protected Info _RegulatoryReportType;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_RegulatoryReport")]
    protected Info _RegulatoryReport;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_RegulatoryAgency")]
    protected Info _RegulatoryAgency;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_DecisionTreeSummary")]
    protected RecordDecisionTreeHistory_Info _DecisionTreeSummary;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_SubmissionDateGMT")]
    protected Info _SubmissionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_CreationDateGMT")]
    protected Info _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_SubmissionRequired")]
    protected Info _SubmissionRequired;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_SubmissionDate")]
    protected Info _SubmissionDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_DueDateGMT")]
    protected Info _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_DueDate")]
    protected Info _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_ReportNumber")]
    protected Info _ReportNumber;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_CreationDate")]
    protected Info _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_CreatedBy")]
    protected Info _CreatedBy;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Info_SubmittedBy")]
    protected Info _SubmittedBy;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info AttachmentRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentRef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AttachmentRef));
      }
    }

    public Info RegulatoryReportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RegulatoryReportType));
      }
    }

    public Info RegulatoryReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RegulatoryReport));
      }
    }

    public Info RegulatoryAgency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryAgency), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RegulatoryAgency));
      }
    }

    public RecordDecisionTreeHistory_Info DecisionTreeSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTreeSummary), (object) value);
      }
      get
      {
        return (RecordDecisionTreeHistory_Info) this.PropertyGet(nameof (DecisionTreeSummary));
      }
    }

    public Info SubmissionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubmissionDateGMT));
      }
    }

    public Info CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Info SubmissionRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubmissionRequired));
      }
    }

    public Info SubmissionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubmissionDate));
      }
    }

    public Info DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Info DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDate));
      }
    }

    public Info ReportNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportNumber));
      }
    }

    public Info CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Info CreatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreatedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CreatedBy));
      }
    }

    public Info SubmittedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmittedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubmittedBy));
      }
    }
  }
}
