// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPADetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPAReportDetail_Info))]
  [KnownType(typeof (CAPARequestDetail_Info))]
  [Serializable]
  public class CAPADetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_PriorityLevel")]
    protected Info _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_AdditionalOrganizations")]
    protected Info _AdditionalOrganizations;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_CAPACustomDetail")]
    protected CAPACustomDetail_Info _CAPACustomDetail;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_BriefDescription")]
    protected Info _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_ReporterOrganization")]
    protected Info _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_CARSeverity")]
    protected Info _CARSeverity;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_InitiatorOrganization")]
    protected Info _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_ReportedDate")]
    protected Info _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_OccurrenceDate")]
    protected Info _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_ReportedDateGMT")]
    protected Info _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_IsSystemicIssue")]
    protected Info _IsSystemicIssue;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_OccurrenceDateGMT")]
    protected Info _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_Initiator")]
    protected Info _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Info_Reporter")]
    protected Info _Reporter;

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

    public CAPACustomDetail_Info CAPACustomDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPACustomDetail), (object) value);
      }
      get
      {
        return (CAPACustomDetail_Info) this.PropertyGet(nameof (CAPACustomDetail));
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
