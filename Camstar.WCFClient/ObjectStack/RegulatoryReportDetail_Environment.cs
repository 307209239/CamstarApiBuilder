// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryReportDetail_Environment
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
  public class RegulatoryReportDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_AttachmentRef")]
    [Metadata("Attached Document", "AttachedDoc", false, false, false, "NamedSubentityRef", 1051761, false, false, true, null)]
    protected Environment _AttachmentRef;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_RegulatoryReportType")]
    [Metadata("Regulatory Report Type", "RegulatoryReportType", false, false, false, "NamedObjectRef", 1051717, false, false, true, null)]
    protected Environment _RegulatoryReportType;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_RegulatoryReport")]
    [Metadata("Regulatory Report", "RegulatoryReport", false, false, false, "SubentityRef", 1051741, false, false, false, null)]
    protected Environment _RegulatoryReport;
    [Metadata("Regulatory Agency", "RegulatoryAgency", false, false, false, "NamedObjectRef", 1051723, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_RegulatoryAgency")]
    protected Environment _RegulatoryAgency;
    [Metadata("Record Decision Tree History", "RecordDecisionTreeHistory", false, false, true, "RecordDecisionTreeHistory", 1051735, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_DecisionTreeSummary")]
    protected RecordDecisionTreeHistory_Environment _DecisionTreeSummary;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051764, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_SubmissionDateGMT")]
    protected Environment _SubmissionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_CreationDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049060, false, false, false, null)]
    protected Environment _CreationDateGMT;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051765, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_SubmissionRequired")]
    protected Environment _SubmissionRequired;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051763, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_SubmissionDate")]
    protected Environment _SubmissionDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_DueDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048792, false, false, false, null)]
    protected Environment _DueDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1048791, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_DueDate")]
    protected Environment _DueDate;
    [Metadata("Generic String", "", false, false, false, "String", 1051762, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_ReportNumber")]
    protected Environment _ReportNumber;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_CreationDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049059, false, false, false, null)]
    protected Environment _CreationDate;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051724, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_CreatedBy")]
    protected Environment _CreatedBy;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1051766, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportDetail_Environment_SubmittedBy")]
    protected Environment _SubmittedBy;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public Environment AttachmentRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachmentRef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachmentRef));
      }
    }

    public Environment RegulatoryReportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RegulatoryReportType));
      }
    }

    public Environment RegulatoryReport
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RegulatoryReport));
      }
    }

    public Environment RegulatoryAgency
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryAgency), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RegulatoryAgency));
      }
    }

    public RecordDecisionTreeHistory_Environment DecisionTreeSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (DecisionTreeSummary), (object) value);
      }
      get
      {
        return (RecordDecisionTreeHistory_Environment) this.PropertyGet(nameof (DecisionTreeSummary));
      }
    }

    public Environment SubmissionDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubmissionDateGMT));
      }
    }

    public Environment CreationDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDateGMT));
      }
    }

    public Environment SubmissionRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubmissionRequired));
      }
    }

    public Environment SubmissionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmissionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubmissionDate));
      }
    }

    public Environment DueDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDateGMT));
      }
    }

    public Environment DueDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDate));
      }
    }

    public Environment ReportNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportNumber));
      }
    }

    public Environment CreationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreationDate));
      }
    }

    public Environment CreatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreatedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreatedBy));
      }
    }

    public Environment SubmittedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubmittedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubmittedBy));
      }
    }
  }
}
