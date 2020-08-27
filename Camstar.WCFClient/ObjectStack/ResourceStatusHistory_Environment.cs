// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusHistory_Environment
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
  public class ResourceStatusHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Resource State definition:\r\n1. NonScheduled\r\n2. UnscheduleDown\r\n3. ScheduleDown\r\n4. Engineering\r\n5. Productive\r\n6. Standby", "ResourceStateEnum", false, false, true, "Integer", 1053000, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldResourceState")]
    protected Environment _OldResourceState;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_ResourceState")]
    [Metadata("Resource State definition:\r\n1. NonScheduled\r\n2. UnscheduleDown\r\n3. ScheduleDown\r\n4. Engineering\r\n5. Productive\r\n6. Standby", "ResourceStateEnum", false, false, true, "Integer", 1052999, false, false, false, null)]
    protected Environment _ResourceState;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049270, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldLastStatusChangeDateGMT")]
    protected Environment _OldLastStatusChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_UpdateLastStatusChangeDate")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049009, false, false, false, null)]
    protected Environment _UpdateLastStatusChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldLastActivityDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049267, false, false, false, null)]
    protected Environment _OldLastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldLastStatusChangeDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049269, false, false, false, null)]
    protected Environment _OldLastStatusChangeDate;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049003, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_LastStatusChangeDate")]
    protected Environment _LastStatusChangeDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049276, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldUpdateLastStatusChangeDate")]
    protected Environment _OldUpdateLastStatusChangeDate;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldLastActivityDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049268, false, false, false, null)]
    protected Environment _OldLastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_LastStatusChangeDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049004, false, false, false, null)]
    protected Environment _LastStatusChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldResourceStatusReasonCode")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, true, "NamedObjectRef", 1049273, false, false, false, null)]
    protected Environment _OldResourceStatusReasonCode;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, true, "NamedObjectRef", 1049272, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldResourceStatusCode")]
    protected Environment _OldResourceStatusCode;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, true, "RevisionedObjectRef", 1049275, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldSetup")]
    protected Environment _OldSetup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_ResourceStatusReasonCode")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1049277, false, false, false, null)]
    protected Environment _ResourceStatusReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_Run")]
    [Metadata("Current Setup number. This value is used to identify all of the work that is performed using a specific Setup. The value is set (incremented) as part of the Resource Setup transaction. All Throughput and Movement transactions record this value in their history transactions.", "", false, false, false, "String", 1048668, false, false, false, null)]
    protected Environment _Run;
    [Metadata("Current Setup number. This value is used to identify all of the work that is performed using a specific Setup. The value is set (incremented) as part of the Resource Setup transaction. All Throughput and Movement transactions record this value in their history transactions.", "", false, false, true, "String", 1049274, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldRun")]
    protected Environment _OldRun;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_ResourceStatusCode")]
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1049247, false, false, false, null)]
    protected Environment _ResourceStatusCode;
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, false, "Integer", 1048655, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_Availability")]
    protected Environment _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1049271, false, false, false, null)]
    protected Environment _OldProduct;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_OldAvailability")]
    [Metadata("Defines the current availability status for a Resource.\r\nValid values and their meanings are:\r\n\r\n1 = Up (Available)\r\n2 = Down (Not available)", "ResourceAvailabilityEnum", false, false, true, "Integer", 1049266, false, false, false, null)]
    protected Environment _OldAvailability;
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, true, "RevisionedObjectRef", 1049008, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusHistory_Environment_Setup")]
    protected Environment _Setup;

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

    public Environment OldResourceState
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceState), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldResourceState));
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

    public Environment OldLastStatusChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastStatusChangeDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldLastStatusChangeDateGMT));
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

    public Environment OldLastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastActivityDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldLastActivityDate));
      }
    }

    public Environment OldLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldLastStatusChangeDate));
      }
    }

    public Environment LastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStatusChangeDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastStatusChangeDate));
      }
    }

    public Environment OldUpdateLastStatusChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldUpdateLastStatusChangeDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldUpdateLastStatusChangeDate));
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

    public Environment OldLastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldLastActivityDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldLastActivityDateGMT));
      }
    }

    public Environment LastStatusChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStatusChangeDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastStatusChangeDateGMT));
      }
    }

    public Environment OldResourceStatusReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceStatusReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldResourceStatusReasonCode));
      }
    }

    public Environment OldResourceStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldResourceStatusCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldResourceStatusCode));
      }
    }

    public Environment OldSetup
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldSetup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldSetup));
      }
    }

    public Environment ResourceStatusReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceStatusReasonCode));
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

    public Environment OldRun
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldRun), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldRun));
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

    public Environment OldProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldProduct));
      }
    }

    public Environment OldAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldAvailability), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldAvailability));
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
  }
}
