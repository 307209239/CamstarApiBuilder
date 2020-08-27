// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceChanges_Environment
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
  public class ResourceChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected Environment _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_PMStatusItem")]
    [Metadata("PMStatusChanges\r\nNOTE: This is NOT Impletemented in the current version", "PMStatusChanges", false, false, false, "SubentityRef", 1048665, false, false, false, null)]
    protected Environment _PMStatusItem;
    [Metadata("Configures a Transport to communicate to a WebService.", "WebServiceTransport", false, false, false, "NamedObjectRef", 1051928, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_WebServiceTransport")]
    protected Environment _WebServiceTransport;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_Logs")]
    [Metadata("ResourceLogChanges\r\nNOTE: This is NOT Impletemented in the current version", "ResourceLogChanges", false, false, false, "ResourceLogChanges", 1048662, false, true, false, null)]
    protected ResourceLogChanges_Environment _Logs;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_TrainingReqGroup")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    protected Environment _TrainingReqGroup;
    [Metadata("Enumeration for ClearanceLevel.\r\n1 = None\r\n2 = Container", "ClearanceLevelEnum", false, false, false, "Integer", 1050560, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ClearanceLevel")]
    protected Environment _ClearanceLevel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_WIPMsgDefMgr")]
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [Metadata("ResourceLogChanges\r\nNOTE: This is NOT Impletemented in the current version", "ResourceLogChanges", false, false, false, "SubentityRef", 1048661, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_LogItem")]
    protected Environment _LogItem;
    [Metadata("PMStatusChanges\r\nNOTE: This is NOT Impletemented in the current version", "PMStatusChanges", false, false, false, "PMStatusChanges", 1048664, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_PMStatus")]
    protected PMStatusChanges_Environment _PMStatus;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_Vendor")]
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1049565, false, false, true, null)]
    protected Environment _Vendor;
    [Metadata("Defines the relationship between a Maintenance Requirement and a group of Resources.", "MaintenanceClass", false, false, false, "NamedObjectRef", 1050702, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_MaintenanceClass")]
    protected Environment _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ResourceFamily")]
    [Metadata("Resource Family is used to differentiate between types of Resources such as Testers and Handlers.\r\n", "ResourceFamily", false, false, false, "NamedObjectRef", 1052142, false, false, true, null)]
    protected Environment _ResourceFamily;
    [Metadata("Defines a Resource Status Model which includes:\r\n1. Available initialization Resource Status Codes\r\n2. A Mapping of available \"From Status\" and \"To Statuses\"", "ResourceStatusModel", false, false, false, "NamedObjectRef", 1052849, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ResourceStatusModel")]
    protected Environment _ResourceStatusModel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_FullyQualifiedName")]
    [Metadata("Fully Qualified Name", "", false, false, false, "String", 1051929, false, false, false, null)]
    protected Environment _FullyQualifiedName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ResourceType")]
    [Metadata("Resource Type, a Resource categorization.  Resources with the same Resource Type may share the same Resources Status Model.", "ResourceType", false, false, false, "NamedObjectRef", 1052921, false, false, true, null)]
    protected Environment _ResourceType;
    [Metadata("Generic String", "", false, false, false, "String", 1050864, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_VendorSerialNumber")]
    protected Environment _VendorSerialNumber;
    [Metadata("Generic String", "", false, false, false, "String", 1050863, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_VendorModel")]
    protected Environment _VendorModel;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, true, "RevisionedObjectRef", 1048657, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_CurrentSetup")]
    protected Environment _CurrentSetup;
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_Factory")]
    protected Environment _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ObjectToChange")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049575, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, false, "Integer", 1048655, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_Availability")]
    protected Environment _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ChildResources")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048656, false, true, true, null)]
    protected Environment _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_ParentResource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048663, false, false, true, null)]
    protected Environment _ParentResource;
    [Metadata("Defines a physical location within a Factory. This can be as high level as a single Location that defines the entire Factory or as specific as individual Locations for each bin within a holding area. Every Container includes a Location attribute. This is used to identify the physical location of the Container.", "Location", false, false, false, "NamedSubentityRef", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Environment_Location")]
    protected Environment _Location;

    public Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment PMStatusItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (PMStatusItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PMStatusItem));
      }
    }

    public Environment WebServiceTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebServiceTransport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WebServiceTransport));
      }
    }

    public ResourceLogChanges_Environment Logs
    {
      [param: In] set
      {
        this.PropertySet(nameof (Logs), (object) value);
      }
      get
      {
        return (ResourceLogChanges_Environment) this.PropertyGet(nameof (Logs));
      }
    }

    public Environment TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Environment ClearanceLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearanceLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ClearanceLevel));
      }
    }

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Environment LogItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LogItem));
      }
    }

    public PMStatusChanges_Environment PMStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PMStatus), (object) value);
      }
      get
      {
        return (PMStatusChanges_Environment) this.PropertyGet(nameof (PMStatus));
      }
    }

    public Environment Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Vendor));
      }
    }

    public Environment MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceClass));
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

    public Environment ResourceStatusModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusModel));
      }
    }

    public Environment FullyQualifiedName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullyQualifiedName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FullyQualifiedName));
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

    public Environment VendorSerialNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorSerialNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorSerialNumber));
      }
    }

    public Environment VendorModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorModel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorModel));
      }
    }

    public Environment CurrentSetup
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSetup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentSetup));
      }
    }

    public Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Availability));
      }
    }

    public Environment ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildResources));
      }
    }

    public Environment ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentResource));
      }
    }

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }
  }
}
