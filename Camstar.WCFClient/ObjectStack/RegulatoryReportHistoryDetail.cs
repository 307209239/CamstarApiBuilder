// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RegulatoryReportHistoryDetail
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
  public class RegulatoryReportHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_AttachmentRef")]
    protected NamedSubentityRef _AttachmentRef;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_RegulatoryAgency")]
    protected NamedObjectRef _RegulatoryAgency;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_RegulatoryReportType")]
    protected NamedObjectRef _RegulatoryReportType;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_SubmissionDate")]
    protected Primitive<DateTime> _SubmissionDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_DueDate")]
    protected Primitive<DateTime> _DueDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_DueDateGMT")]
    protected Primitive<DateTime> _DueDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_CreationDateGMT")]
    protected Primitive<DateTime> _CreationDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_CreationDate")]
    protected Primitive<DateTime> _CreationDate;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_ReportNumber")]
    protected Primitive<string> _ReportNumber;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_SubmissionRequired")]
    protected Primitive<bool> _SubmissionRequired;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_SubmissionDateGMT")]
    protected Primitive<DateTime> _SubmissionDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_SubmittedBy")]
    protected NamedObjectRef _SubmittedBy;
    [DataMember(EmitDefaultValue = false, Name = "RegulatoryReportHistoryDetail_CreatedBy")]
    protected NamedObjectRef _CreatedBy;

    public override bool Equals(object obj)
    {
      return obj is RegulatoryReportHistoryDetail && object.Equals((object) this._AttachmentRef, (object) ((RegulatoryReportHistoryDetail) obj)._AttachmentRef) && (object.Equals((object) this._ExportImportKey, (object) ((RegulatoryReportHistoryDetail) obj)._ExportImportKey) && object.Equals((object) this._Comments, (object) ((RegulatoryReportHistoryDetail) obj)._Comments)) && (object.Equals((object) this._RegulatoryAgency, (object) ((RegulatoryReportHistoryDetail) obj)._RegulatoryAgency) && object.Equals((object) this._RegulatoryReportType, (object) ((RegulatoryReportHistoryDetail) obj)._RegulatoryReportType) && (object.Equals((object) this._SubmissionDate, (object) ((RegulatoryReportHistoryDetail) obj)._SubmissionDate) && object.Equals((object) this._DueDate, (object) ((RegulatoryReportHistoryDetail) obj)._DueDate))) && (object.Equals((object) this._DueDateGMT, (object) ((RegulatoryReportHistoryDetail) obj)._DueDateGMT) && object.Equals((object) this._CreationDateGMT, (object) ((RegulatoryReportHistoryDetail) obj)._CreationDateGMT) && (object.Equals((object) this._CreationDate, (object) ((RegulatoryReportHistoryDetail) obj)._CreationDate) && object.Equals((object) this._ReportNumber, (object) ((RegulatoryReportHistoryDetail) obj)._ReportNumber)) && (object.Equals((object) this._SubmissionRequired, (object) ((RegulatoryReportHistoryDetail) obj)._SubmissionRequired) && object.Equals((object) this._SubmissionDateGMT, (object) ((RegulatoryReportHistoryDetail) obj)._SubmissionDateGMT) && (object.Equals((object) this._HistoryId, (object) ((RegulatoryReportHistoryDetail) obj)._HistoryId) && object.Equals((object) this._SubmittedBy, (object) ((RegulatoryReportHistoryDetail) obj)._SubmittedBy)))) && object.Equals((object) this._CreatedBy, (object) ((RegulatoryReportHistoryDetail) obj)._CreatedBy) && base.Equals(obj);
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
  }
}
