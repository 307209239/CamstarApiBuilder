// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanChanges_Environment
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
  public class SamplingPlanChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, false, "NamedObjectRef", 1049565, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_Vendor")]
    protected Environment _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    protected Environment _VendorItem;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_Spec")]
    protected Environment _Spec;
    [Metadata("The specific describes the details for a Sampling Plan's Sample Test..  For each  Sample Test, the AQL Level, Inspection Level, Switching Rule, Spec, Vendor and Resoruce can be configured.", "SamplingPlanDetailsChanges", false, false, false, "SamplingPlanDetailsChanges", 1053137, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_SamplingPlanDetails")]
    protected SamplingPlanDetailsChanges_Environment _SamplingPlanDetails;
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRule", false, false, false, "RevisionedObjectRef", 1053138, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_SwitchingRule")]
    protected Environment _SwitchingRule;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_ObjectToChange")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_AQLLevel")]
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, false, "NamedObjectRef", 1053105, false, false, true, null)]
    protected Environment _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_InspectionLevel")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, false, "NamedObjectRef", 1053133, false, false, true, null)]
    protected Environment _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_Base")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlanBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053135, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_SampleRateMaxDuration")]
    protected Environment _SampleRateMaxDuration;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053134, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_SampleRate")]
    protected Environment _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_SwitchingRuleMaxDuration")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053139, false, false, false, "0")]
    protected Environment _SwitchingRuleMaxDuration;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053136, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_SampleSizeBasedOnStartQty")]
    protected Environment _SampleSizeBasedOnStartQty;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_Resource")]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053140, false, false, false, null)]
    protected new Environment _Name;

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

    public SamplingPlanDetailsChanges_Environment SamplingPlanDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetails), (object) value);
      }
      get
      {
        return (SamplingPlanDetailsChanges_Environment) this.PropertyGet(nameof (SamplingPlanDetails));
      }
    }

    public Environment SwitchingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SwitchingRule));
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

    public Environment InspectionLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectionLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectionLevel));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment SampleRateMaxDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRateMaxDuration), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleRateMaxDuration));
      }
    }

    public Environment SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleRate));
      }
    }

    public Environment SwitchingRuleMaxDuration
    {
      [param: In] set
      {
        this.PropertySet(nameof (SwitchingRuleMaxDuration), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SwitchingRuleMaxDuration));
      }
    }

    public Environment SampleSizeBasedOnStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeBasedOnStartQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleSizeBasedOnStartQty));
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
  }
}
