// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventData_Environment
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
  public class UpdateEventData_Environment : UpdateEventDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_ReporterOrganization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051054, false, false, true, null)]
    protected Environment _ReporterOrganization;
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, false, false, "NamedObjectRef", 1051051, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_InitiatorOrganization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051049, false, false, true, null)]
    protected Environment _InitiatorOrganization;
    [Metadata("Instruction", "", false, false, false, "String", 1050514, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_QualityResolutionCode")]
    [Metadata("Identifies the valid resolution codes for closing an Event or CAPA.", "QualityResolutionCode", false, false, true, "NamedObjectRef", 16779415, false, false, false, null)]
    protected Environment _QualityResolutionCode;
    [Metadata("Identifies the data details to assign to the Event.", "EventDataDetails", false, false, false, "EventDataDetails", 8390320, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_EventDataDetail")]
    protected EventDataDetails_Environment _EventDataDetail;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_RegulatoryReportDetails")]
    [Metadata("Regulatory Report Detail", "RegulatoryReportDetail", false, false, false, "RegulatoryReportDetail", 1051738, false, true, false, null)]
    protected RegulatoryReportDetail_Environment _RegulatoryReportDetails;
    [Metadata("Brief Description", "", false, false, false, "String", 1051299, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_BriefDescription")]
    protected Environment _BriefDescription;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_DisallowedTxns")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 16779231, false, true, true, null)]
    protected Environment _DisallowedTxns;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051437, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_OccurrenceDateGMT")]
    protected Environment _OccurrenceDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051436, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_OccurrenceDate")]
    protected Environment _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_ReportedDate")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051052, false, false, false, null)]
    protected Environment _ReportedDate;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051157, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_ReportedDateGMT")]
    protected Environment _ReportedDateGMT;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_DiscoveryArea")]
    protected Environment _DiscoveryArea;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1051417, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_CloseDescription")]
    protected Environment _CloseDescription;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_Initiator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052281, false, false, true, null)]
    protected Environment _Initiator;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052282, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventData_Environment_Reporter")]
    protected Environment _Reporter;

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

    public Environment QualityResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityResolutionCode));
      }
    }

    public EventDataDetails_Environment EventDataDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDataDetail), (object) value);
      }
      get
      {
        return (EventDataDetails_Environment) this.PropertyGet(nameof (EventDataDetail));
      }
    }

    public RegulatoryReportDetail_Environment RegulatoryReportDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportDetail_Environment) this.PropertyGet(nameof (RegulatoryReportDetails));
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

    public Environment DisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowedTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisallowedTxns));
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

    public Environment DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DiscoveryArea));
      }
    }

    public Environment CloseDescription
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseDescription), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CloseDescription));
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
