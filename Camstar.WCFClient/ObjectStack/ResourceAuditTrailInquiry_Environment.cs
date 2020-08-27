// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceAuditTrailInquiry_Environment
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
  public class ResourceAuditTrailInquiry_Environment : MfgAuditTrailInquiry_Environment
  {
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_ResourceGroup")]
    protected Environment _ResourceGroup;
    [Metadata("Resource Family is used to differentiate between types of Resources such as Testers and Handlers.\r\n", "ResourceFamily", false, false, false, "NamedObjectRef", 1052142, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_ResourceFamily")]
    protected Environment _ResourceFamily;
    [Metadata("Enumeration for the History Record Type:\r\n1 = Event\r\n2 = CAR\r\n3 = CAPA\r\n4 = Container\r\n5 = ContainerInCarrier", "HistoryRecordTypeEnum", false, false, false, "Integer", 1051578, false, false, false, "6")]
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_RecordType")]
    protected new Environment _RecordType;
    [Metadata("ResourceAuditTrailType", "ResourceAuditTrailTypeEnum", false, false, false, "Integer", 16778917, false, false, true, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_TransactionFilter")]
    protected new Environment _TransactionFilter;
    [Metadata("Resource Type, a Resource categorization.  Resources with the same Resource Type may share the same Resources Status Model.", "ResourceType", false, false, false, "NamedObjectRef", 1052921, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_ResourceType")]
    protected Environment _ResourceType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_ShowAllTxnTypes")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049588, false, false, false, "1")]
    protected new Environment _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected new Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_ResourceStatusReasonFilter")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1049249, false, false, true, null)]
    protected new Environment _ResourceStatusReasonFilter;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, false, "Integer", 1048655, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_AvailabilityFilter")]
    protected new Environment _AvailabilityFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Environment_ResourceStatusCodeFilter")]
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1049247, false, false, true, null)]
    protected new Environment _ResourceStatusCodeFilter;

    public Environment ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceGroup));
      }
    }

    public Environment ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public new Environment RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordType));
      }
    }

    public new Environment TransactionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransactionFilter));
      }
    }

    public Environment ResourceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceType));
      }
    }

    public new Environment ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public new Environment Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Resource));
      }
    }

    public new Environment ResourceStatusReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusReasonFilter));
      }
    }

    public new Environment AvailabilityFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailabilityFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AvailabilityFilter));
      }
    }

    public new Environment ResourceStatusCodeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCodeFilter));
      }
    }
  }
}
