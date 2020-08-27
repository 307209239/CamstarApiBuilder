// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventHistoryDetail_Environment
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
  public class EventHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Identifies a Priority for an Event.", "PriorityLevel", false, true, false, "NamedObjectRef", 1051051, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_PriorityLevel")]
    protected Environment _PriorityLevel;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_Description")]
    [Metadata("Instruction", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("History of the EventDataDetails.", "EventDataHistoryDetail", false, false, true, "EventDataHistoryDetail", 1051095, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_EventDataHistoryDetail")]
    protected EventDataHistoryDetail_Environment _EventDataHistoryDetail;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_BriefDescription")]
    [Metadata("Brief Description", "", false, false, true, "String", 1051299, false, false, false, null)]
    protected Environment _BriefDescription;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051054, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_ReporterOrganization")]
    protected Environment _ReporterOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_InitiatorOrganization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, true, "NamedObjectRef", 1051049, false, false, false, null)]
    protected Environment _InitiatorOrganization;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_RegulatoryReportHistoryDetails")]
    [Metadata("Regulatory Report History Detail", "RegulatoryReportHistoryDetail", false, false, true, "RegulatoryReportHistoryDetail", 1051740, false, true, false, null)]
    protected RegulatoryReportHistoryDetail_Environment _RegulatoryReportHistoryDetails;
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1051436, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_OccurrenceDate")]
    protected Environment _OccurrenceDate;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_OccurrenceDateGMT")]
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1051437, false, false, false, null)]
    protected Environment _OccurrenceDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_DiscoveryArea")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051043, false, false, false, null)]
    protected Environment _DiscoveryArea;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_NonconformanceNumber")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050601, false, false, false, null)]
    protected Environment _NonconformanceNumber;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_Reporter")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052282, false, false, false, null)]
    protected Environment _Reporter;
    [DataMember(EmitDefaultValue = false, Name = "EventHistoryDetail_Environment_Initiator")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 1052281, false, false, true, null)]
    protected Environment _Initiator;

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

    public EventDataHistoryDetail_Environment EventDataHistoryDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventDataHistoryDetail), (object) value);
      }
      get
      {
        return (EventDataHistoryDetail_Environment) this.PropertyGet(nameof (EventDataHistoryDetail));
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

    public RegulatoryReportHistoryDetail_Environment RegulatoryReportHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (RegulatoryReportHistoryDetails), (object) value);
      }
      get
      {
        return (RegulatoryReportHistoryDetail_Environment) this.PropertyGet(nameof (RegulatoryReportHistoryDetails));
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

    public Environment NonconformanceNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (NonconformanceNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NonconformanceNumber));
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
  }
}
