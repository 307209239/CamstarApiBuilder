// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPAHistoryDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CAPAReportHistoryDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPARequestHistoryDetail_Info))]
  [Serializable]
  public class CAPAHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_InitiatorOrganization")]
    protected Info _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_CustomHistoryDetail")]
    protected CAPACustomHistoryDetail_Info _CustomHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_AdditionalOrganizations")]
    protected Info _AdditionalOrganizations;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_BriefDescription")]
    protected Info _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_CARSeverity")]
    protected Info _CARSeverity;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_ReporterOrganization")]
    protected Info _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_OccurrenceDate")]
    protected Info _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_ReportedDateGMT")]
    protected Info _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_ReportedDate")]
    protected Info _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_OccurrenceDateGMT")]
    protected Info _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_IsSystemicIssue")]
    protected Info _IsSystemicIssue;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_Initiator")]
    protected Info _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Info_Reporter")]
    protected Info _Reporter;

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public CAPACustomHistoryDetail_Info CustomHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomHistoryDetail), (object) value);
      }
      get
      {
        return (CAPACustomHistoryDetail_Info) this.PropertyGet(nameof (CustomHistoryDetail));
      }
    }

    public Info AdditionalOrganizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalOrganizations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdditionalOrganizations));
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

    public Info CARSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARSeverity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CARSeverity));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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

    public Info IsSystemicIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSystemicIssue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSystemicIssue));
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
  }
}
