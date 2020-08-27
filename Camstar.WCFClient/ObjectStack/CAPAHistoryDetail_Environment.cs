// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPAHistoryDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CAPAReportHistoryDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPARequestHistoryDetail_Environment))]
  [Serializable]
  public class CAPAHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, true, "NamedObjectRef", 1051051, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_Description")]
    [Metadata("Instruction", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051049, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_InitiatorOrganization")]
    protected Environment _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_CustomHistoryDetail")]
    [Metadata("Used to record history of customer extensions to CAPA.", "CAPACustomHistoryDetail", false, false, true, "CAPACustomHistoryDetail", 1052472, false, false, false, null)]
    protected CAPACustomHistoryDetail_Environment _CustomHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_AdditionalOrganizations")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051335, false, true, false, null)]
    protected Environment _AdditionalOrganizations;
    [Metadata("Brief Description", "", false, false, true, "String", 1051299, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_BriefDescription")]
    protected Environment _BriefDescription;
    [Metadata("CAR/CAPA Severity", "CARSeverity", false, false, true, "NamedObjectRef", 1051334, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_CARSeverity")]
    protected Environment _CARSeverity;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051054, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_ReporterOrganization")]
    protected Environment _ReporterOrganization;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051343, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_OccurrenceDate")]
    protected Environment _OccurrenceDate;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051157, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_ReportedDateGMT")]
    protected Environment _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_ReportedDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051052, false, false, false, null)]
    protected Environment _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_OccurrenceDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051344, false, false, false, null)]
    protected Environment _OccurrenceDateGMT;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052154, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_IsSystemicIssue")]
    protected Environment _IsSystemicIssue;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_Initiator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052281, false, false, false, null)]
    protected Environment _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "CAPAHistoryDetail_Environment_Reporter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052282, false, false, false, null)]
    protected Environment _Reporter;

    public Environment PriorityLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (PriorityLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PriorityLevel));
      }
    }

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment InitiatorOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitiatorOrganization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitiatorOrganization));
      }
    }

    public CAPACustomHistoryDetail_Environment CustomHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CustomHistoryDetail), (object) value);
      }
      get
      {
        return (CAPACustomHistoryDetail_Environment) this.PropertyGet(nameof (CustomHistoryDetail));
      }
    }

    public Environment AdditionalOrganizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdditionalOrganizations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AdditionalOrganizations));
      }
    }

    public Environment BriefDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (BriefDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BriefDescription));
      }
    }

    public Environment CARSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARSeverity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CARSeverity));
      }
    }

    public Environment ReporterOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReporterOrganization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReporterOrganization));
      }
    }

    public Environment OccurrenceDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccurrenceDate));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment ReportedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportedDateGMT));
      }
    }

    public Environment ReportedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportedDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReportedDate));
      }
    }

    public Environment OccurrenceDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OccurrenceDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OccurrenceDateGMT));
      }
    }

    public Environment IsSystemicIssue
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSystemicIssue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsSystemicIssue));
      }
    }

    public Environment Initiator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Initiator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Initiator));
      }
    }

    public Environment Reporter
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reporter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Reporter));
      }
    }
  }
}
