// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceSetup_Environment
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
  public class ResourceSetup_Environment : ResourceTxn_Environment
  {
    [Metadata("Current status information of a Resource.", "ResourceStatusDetails", false, false, false, "ResourceStatusDetails", 1050392, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_ResourceStatusDetails")]
    protected new ResourceStatusDetails_Environment _ResourceStatusDetails;
    [Metadata("A Named Object Group that represents a group of Resources.", "ResourceGroup", false, false, false, "NamedObjectRef", 1048761, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_ResourceGroup")]
    protected Environment _ResourceGroup;
    [Metadata("History Summary object for the ResourceSetup-type services. This object plus any related details objects will contain all the history information needed for the service that is not already contained in the HistoryMainline object.", "ResourceStatusHistory", false, false, false, "ResourceStatusHistory", 1049248, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_ResourceStatusHistory")]
    protected ResourceStatusHistory_Environment _ResourceStatusHistory;
    [Metadata("Resource State definition:\r\n1. NonScheduled\r\n2. UnscheduleDown\r\n3. ScheduleDown\r\n4. Engineering\r\n5. Productive\r\n6. Standby", "ResourceStateEnum", false, false, false, "Integer", 1052999, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_ResourceState")]
    protected Environment _ResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_Run")]
    [Metadata("Generic String", "", false, false, false, "String", 1048668, false, false, false, null)]
    protected Environment _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_UpdateLastStatusChangeDate")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049009, false, false, false, "1")]
    protected Environment _UpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_Setup")]
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1049008, false, false, true, null)]
    protected Environment _Setup;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, true, false, "Integer", 1048655, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_Availability")]
    protected Environment _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_ResourceStatusReason")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1049249, false, false, true, null)]
    protected Environment _ResourceStatusReason;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_Product")]
    protected Environment _Product;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, true, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_Resource")]
    protected new Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceSetup_Environment_ResourceStatusCode")]
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1049247, false, false, true, null)]
    protected Environment _ResourceStatusCode;

    public new ResourceStatusDetails_Environment ResourceStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDetails), (object) value);
      }
      get
      {
        return (ResourceStatusDetails_Environment) this.PropertyGet(nameof (ResourceStatusDetails));
      }
    }

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

    public ResourceStatusHistory_Environment ResourceStatusHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusHistory), (object) value);
      }
      get
      {
        return (ResourceStatusHistory_Environment) this.PropertyGet(nameof (ResourceStatusHistory));
      }
    }

    public Environment ResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceState), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceState));
      }
    }

    public Environment Run
    {
      [param: In] set
      {
        this.PropertySet(nameof (Run), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Run));
      }
    }

    public Environment UpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpdateLastStatusChangeDate));
      }
    }

    public Environment Setup
    {
      [param: In] set
      {
        this.PropertySet(nameof (Setup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Setup));
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

    public Environment ResourceStatusReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusReason));
      }
    }

    public Environment Product
    {
      [param: In] set
      {
        this.PropertySet(nameof (Product), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Product));
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

    public Environment ResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusCode));
      }
    }
  }
}
