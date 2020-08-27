// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingPlanDetailsChanges_Environment
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
  public class SamplingPlanDetailsChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_Vendor")]
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", true, false, false, "NamedObjectRef", 1049565, false, false, true, null)]
    protected Environment _Vendor;
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_VendorItem")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", true, false, false, "NamedSubentityRef", 1049454, false, false, true, null)]
    protected Environment _VendorItem;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_InspectionLevel")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, false, "NamedObjectRef", 1053133, false, false, true, null)]
    protected Environment _InspectionLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_AQLLevel")]
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, false, "NamedObjectRef", 1053105, false, false, true, null)]
    protected Environment _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_SampleTest")]
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, true, false, "RevisionedObjectRef", 1053111, false, false, true, null)]
    protected Environment _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_SwitchingRule")]
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRule", false, false, false, "RevisionedObjectRef", 1053138, false, false, true, null)]
    protected Environment _SwitchingRule;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_ListItemToChange")]
    [Metadata("The specific describes the details for a Sampling Plan's Sample Test..  For each  Sample Test, the AQL Level, Inspection Level, Switching Rule, Spec, Vendor and Resoruce can be configured.", "SamplingPlanDetailsChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("The specific describes the details for a Sampling Plan's Sample Test..  For each  Sample Test, the AQL Level, Inspection Level, Switching Rule, Spec, Vendor and Resoruce can be configured.", "SamplingPlanDetails", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_SampleRate")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053134, false, false, false, null)]
    protected Environment _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_InspectAll")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053171, false, false, false, "0")]
    protected Environment _InspectAll;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_InspectAllContQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777737, false, false, false, "0")]
    protected Environment _InspectAllContQty;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_InspectAllQtyOnFailure")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777738, false, false, false, "0")]
    protected Environment _InspectAllQtyOnFailure;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 0, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "SamplingPlanDetailsChanges_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, false, "NamedObjectRef", 1048840, false, false, true, null)]
    protected Environment _Resource;

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

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment InspectAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAll), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectAll));
      }
    }

    public Environment InspectAllContQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllContQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectAllContQty));
      }
    }

    public Environment InspectAllQtyOnFailure
    {
      [param: In] set
      {
        this.PropertySet(nameof (InspectAllQtyOnFailure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InspectAllQtyOnFailure));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
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
