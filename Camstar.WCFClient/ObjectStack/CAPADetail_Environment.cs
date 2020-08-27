// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPADetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (CAPARequestDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CAPAReportDetail_Environment))]
  [Serializable]
  public class CAPADetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Instruction", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_PriorityLevel")]
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, false, "NamedObjectRef", 1051051, false, false, true, null)]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_AdditionalOrganizations")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051546, false, true, true, null)]
    protected Environment _AdditionalOrganizations;
    [Metadata("Used to manage customer extensions to CAPA", "CAPACustomDetail", false, false, false, "CAPACustomDetail", 1052476, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_CAPACustomDetail")]
    protected CAPACustomDetail_Environment _CAPACustomDetail;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_BriefDescription")]
    [Metadata("Brief Description", "", false, false, false, "String", 1051299, false, false, false, null)]
    protected Environment _BriefDescription;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051054, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_ReporterOrganization")]
    protected Environment _ReporterOrganization;
    [Metadata("CAR/CAPA Severity", "CARSeverity", false, false, false, "NamedObjectRef", 1052153, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_CARSeverity")]
    protected Environment _CARSeverity;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_InitiatorOrganization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051049, false, false, true, null)]
    protected Environment _InitiatorOrganization;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051052, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_ReportedDate")]
    protected Environment _ReportedDate;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_OccurrenceDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051343, false, false, false, null)]
    protected Environment _OccurrenceDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051157, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_ReportedDateGMT")]
    protected Environment _ReportedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_IsSystemicIssue")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052154, false, false, false, "0")]
    protected Environment _IsSystemicIssue;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_OccurrenceDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051344, false, false, false, null)]
    protected Environment _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_Initiator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052281, false, false, true, null)]
    protected Environment _Initiator;
    [DataMember(EmitDefaultValue = false, Name = "CAPADetail_Environment_Reporter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052282, false, false, true, null)]
    protected Environment _Reporter;

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

    public CAPACustomDetail_Environment CAPACustomDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (CAPACustomDetail), (object) value);
      }
      get
      {
        return (CAPACustomDetail_Environment) this.PropertyGet(nameof (CAPACustomDetail));
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
