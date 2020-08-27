// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusDetails_Environment
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
  public class ResourceStatusDetails_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_Availability")]
    [Metadata("Generic String", "", false, false, false, "String", 1049962, false, false, false, null)]
    protected Environment _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_ResourceAvailability")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049962, false, false, false, null)]
    protected Environment _ResourceAvailability;
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_ProductRev")]
    protected Environment _ProductRev;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_ReasonCodeName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050395, false, false, false, null)]
    protected Environment _ReasonCodeName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048709, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_ProductName")]
    protected Environment _ProductName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_Status")]
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1049247, false, false, false, null)]
    protected Environment _Status;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_TimeAtStatus")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1050391, false, false, false, null)]
    protected Environment _TimeAtStatus;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_Product")]
    protected Environment _Product;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_SetupRev")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, false, "String", 1050393, false, false, false, null)]
    protected Environment _SetupRev;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050396, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_StatusCodeName")]
    protected Environment _StatusCodeName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_Reason")]
    [Metadata("A Resource Status Reason Code is used to provide an added level of detail describing the reason for the current status of a Resource. For example, the current status may be REPAIR. A Status Reason Code can be used to provide additional details such as the type of repair that is being performed. This detail is included in the transaction history, which makes it available for Analysis Reporting.", "ResourceStatusReason", false, false, false, "NamedObjectRef", 1049249, false, false, false, null)]
    protected Environment _Reason;
    [Metadata("Current Setup number. This value is used to identify all of the work that is performed using a specific Setup. The value is set (incremented) as part of the Resource Setup transaction. All Throughput and Movement transactions record this value in their history transactions.", "", false, false, false, "String", 1048668, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_Run")]
    protected Environment _Run;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_Setup")]
    [Metadata("A Setup is a configuration of a resource needed to process a certain type of material (typcially a particular product, or a container referencing a particular spec)..  Normally the definition of a setup includes only items as hardware configurations, that take significant time to change, while a reciipe would include many other items such as process settings that may be changed instantly.\r\n\r\nStandard Camstar-provided attributes of a setup  include items such as the applicable set of documents describing the setup configuration, an estimate of time need to configure the setup, etc.  Setups are often defined in InSite to help provide scheduling/dispatching information on which containers/orders may be processed without significant changeover time between the items.\r\n\r\n", "Setup", false, false, false, "RevisionedObjectRef", 1049008, false, false, false, null)]
    protected Environment _Setup;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050231, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDetails_Environment_SetupName")]
    protected Environment _SetupName;

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

    public Environment ResourceAvailability
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceAvailability), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResourceAvailability));
      }
    }

    public Environment ProductRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductRev));
      }
    }

    public Environment ReasonCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCodeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReasonCodeName));
      }
    }

    public Environment ProductName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProductName));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment TimeAtStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimeAtStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TimeAtStatus));
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

    public Environment SetupRev
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupRev), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SetupRev));
      }
    }

    public Environment StatusCodeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusCodeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StatusCodeName));
      }
    }

    public Environment Reason
    {
      [param: In] set
      {
        this.PropertySet(nameof (Reason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Reason));
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

    public Environment SetupName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SetupName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SetupName));
      }
    }
  }
}
