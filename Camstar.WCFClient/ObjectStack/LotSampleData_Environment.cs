// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LotSampleData_Environment
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
  public class LotSampleData_Environment : ContainerSampleData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_Spec")]
    protected Environment _Spec;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, true, "NamedSubentityRef", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_VendorItem")]
    protected Environment _VendorItem;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, true, "RevisionedObjectRef", 1053111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_SampleTest")]
    protected new Environment _SampleTest;
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, true, "NamedObjectRef", 1053105, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_AQLLevel")]
    protected new Environment _AQLLevel;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, true, "RevisionedObjectRef", 1053112, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_SamplingPlan")]
    protected new Environment _SamplingPlan;
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, true, "NamedObjectRef", 1053133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_InspectionLevel")]
    protected new Environment _InspectionLevel;
    [Metadata("The specific describes the details for a Sampling Plan's Sample Test..  For each  Sample Test, the AQL Level, Inspection Level, Switching Rule, Spec, Vendor and Resoruce can be configured.", "SamplingPlanDetails", false, false, true, "SubentityRef", 1053137, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_SamplingPlanDetail")]
    protected Environment _SamplingPlanDetail;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777739, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_SamplesFailed")]
    protected Environment _SamplesFailed;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_InspectAllContQty")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777737, false, false, false, "0")]
    protected new Environment _InspectAllContQty;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053154, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_SamplesTested")]
    protected Environment _SamplesTested;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_Rejects")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053150, false, false, false, null)]
    protected new Environment _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_TotalSamplesRequired")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053164, false, false, false, null)]
    protected new Environment _TotalSamplesRequired;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777738, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_InspectAllQtyOnFailure")]
    protected new Environment _InspectAllQtyOnFailure;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_AllowedRejects")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053160, false, false, false, null)]
    protected new Environment _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_CompletedSamples")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053161, false, false, false, null)]
    protected new Environment _CompletedSamples;
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "LotSampleData_Environment_Resource")]
    protected Environment _Resource;

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

    public new Environment SampleTest
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

    public new Environment AQLLevel
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

    public new Environment SamplingPlan
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

    public new Environment InspectionLevel
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

    public Environment SamplingPlanDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlanDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlanDetail));
      }
    }

    public Environment SamplesFailed
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplesFailed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplesFailed));
      }
    }

    public new Environment InspectAllContQty
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

    public Environment SamplesTested
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplesTested), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplesTested));
      }
    }

    public new Environment Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejects));
      }
    }

    public new Environment TotalSamplesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalSamplesRequired));
      }
    }

    public new Environment InspectAllQtyOnFailure
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

    public new Environment AllowedRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowedRejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowedRejects));
      }
    }

    public new Environment CompletedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletedSamples));
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
