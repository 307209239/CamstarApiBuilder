// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CollectLotSamplingDataHistory_Environment))]
  [Serializable]
  public class CollectSamplingDataHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, true, "NamedSubentityRef", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_VendorItem")]
    protected Environment _VendorItem;
    [Metadata("A vendor is a provider of goods and services. An example of these goods and services are components and subassemblies used to manufacture products, products purchased for resale, non-production materials,\r\nservices such as resource and building maintenance and so on.", "Vendor", false, false, true, "NamedObjectRef", 1049565, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_Vendor")]
    protected Environment _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, true, "RevisionedObjectRef", 1049033, false, false, false, null)]
    protected Environment _Spec;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_HistoryDetails")]
    [Metadata("Collect Sampling History Details", "CollectSamplingHistoryDetails", false, false, false, "CollectSamplingHistoryDetails", 1049096, false, true, false, null)]
    protected CollectSamplingHistoryDetails_Environment _HistoryDetails;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, true, "RevisionedObjectRef", 1053111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_SampleTest")]
    protected Environment _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_InspectionLevel")]
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, true, "NamedObjectRef", 1053133, false, false, false, null)]
    protected Environment _InspectionLevel;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, true, "RevisionedObjectRef", 1053112, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_SamplingPlan")]
    protected Environment _SamplingPlan;
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, true, "NamedObjectRef", 1053105, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_AQLLevel")]
    protected Environment _AQLLevel;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_AllowedRejects")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053160, false, false, false, null)]
    protected Environment _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777971, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_TotalPassedSamples")]
    protected Environment _TotalPassedSamples;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053154, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_SamplesTested")]
    protected Environment _SamplesTested;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053153, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_RequiredSamples")]
    protected Environment _RequiredSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_TxnDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1053113, false, false, false, null)]
    protected Environment _TxnDateGMT;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053158, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_TotalSamplesCompleted")]
    protected Environment _TotalSamplesCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_SamplingStatus")]
    [Metadata("Generic String", "", false, false, true, "String", 1053155, false, false, false, null)]
    protected Environment _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_TotalRejects")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053157, false, false, false, null)]
    protected Environment _TotalRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_Resource")]
    [Metadata("A Resource describes any non-material entity within a factory. The common use (and most concrete example) of a Resource is to describe a Machine. Resources are associated with a single factory, to define their physical location. Resources also belong to zero or more Resource Groups, to provide a logical grouping.\r\n\r\nA Resource is a static (modeling) entity. Each Resource can have a Resource Status entry to track the current status for each Status Category defined. The application is delivered with three specific Status Categories. They are Production, Preventative Maintenance and Log. Production is used to determine availability for production. Preventative Maintenance is used to track the current Preventative Maintenance status for a Resource. Log is used to provide a mechanism for logging freeform comments and optionally assigning predefined status and reason codes. Customers can define additional Status categories to concurrently track Resource status is multiple user-defined ways.", "Resource", false, false, true, "NamedObjectRef", 1048840, false, false, false, null)]
    protected Environment _Resource;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataHistory_Environment_Product")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, true, "RevisionedObjectRef", 1048625, false, false, false, null)]
    protected Environment _Product;

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

    public CollectSamplingHistoryDetails_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (CollectSamplingHistoryDetails_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public Environment AllowedRejects
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

    public Environment TotalPassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalPassedSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalPassedSamples));
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

    public Environment RequiredSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequiredSamples));
      }
    }

    public Environment TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnDateGMT));
      }
    }

    public Environment TotalSamplesCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalSamplesCompleted));
      }
    }

    public Environment SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public Environment TotalRejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalRejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalRejects));
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
  }
}
