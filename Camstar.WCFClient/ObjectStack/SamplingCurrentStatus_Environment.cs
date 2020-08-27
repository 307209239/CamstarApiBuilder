// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingCurrentStatus_Environment
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
  public class SamplingCurrentStatus_Environment : BaseObject_Environment
  {
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, true, "NamedSubentityRef", 1049454, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_VendorItem")]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_Vendor")]
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, true, "NamedObjectRef", 1049565, false, false, false, null)]
    protected Environment _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    protected Environment _Spec;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, true, "RevisionedObjectRef", 1053111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_SampleTest")]
    protected Environment _SampleTest;
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, true, "NamedObjectRef", 1053105, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_AQLLevel")]
    protected Environment _AQLLevel;
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, true, "NamedObjectRef", 16777719, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_SamplingLot")]
    protected Environment _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_SamplePlanInspectionLevel")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, true, "NamedObjectRef", 1053109, false, false, false, null)]
    protected Environment _SamplePlanInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_SamplingPlan")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, true, "RevisionedObjectRef", 1053112, false, false, false, null)]
    protected Environment _SamplingPlan;
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, true, "NamedObjectRef", 1053106, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_CurrentInspectionLevel")]
    protected Environment _CurrentInspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_LastUpdateDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053108, false, false, false, null)]
    protected Environment _LastUpdateDate;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053110, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_SampleRateCounter")]
    protected Environment _SampleRateCounter;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053107, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_CurrentSampleRate")]
    protected Environment _CurrentSampleRate;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_Product")]
    protected Environment _Product;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingCurrentStatus_Environment_Resource")]
    protected Environment _Resource;

    public Environment VendorItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VendorItem));
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

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public Environment SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Environment AQLLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (AQLLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AQLLevel));
      }
    }

    public Environment SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Environment SamplePlanInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplePlanInspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplePlanInspectionLevel));
      }
    }

    public Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Environment CurrentInspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentInspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentInspectionLevel));
      }
    }

    public Environment LastUpdateDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdateDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastUpdateDate));
      }
    }

    public Environment SampleRateCounter
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRateCounter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleRateCounter));
      }
    }

    public Environment CurrentSampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSampleRate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentSampleRate));
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

    public Environment Resource
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
  }
}
