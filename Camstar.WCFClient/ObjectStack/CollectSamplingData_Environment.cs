// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingData_Environment
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
  public class CollectSamplingData_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_ChangeQty")]
    [Metadata("ChangeQty is used to update the quantity of a container or of a multi-level cotainer structure.  ", "ChangeQty", false, false, false, "ChangeQty", 1049810, false, false, false, null)]
    protected ChangeQty_Environment _ChangeQty;
    [Metadata("The user code for loss reason.", "LossReason", false, false, false, "NamedObjectRef", 1053152, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_RejectReasons")]
    protected Environment _RejectReasons;
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1049454, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_VendorItem")]
    protected Environment _VendorItem;
    [Metadata("Collect Sampling Data Details", "CollectSamplingDataDetails", false, false, false, "CollectSamplingDataDetails", 1053156, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_ServiceDetails")]
    protected CollectSamplingDataDetails_Environment _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_ContainerSampleData")]
    [Metadata("Used to  record all sampling plan data for a container.  The sampling plan data is stored in this objects in order to keep updates from a user to the SamplingPlan from changing once the container has started its sampling plan tested.  This is also used to provide selection data for the user on the Collect Sampling transaction.  The next container will pick up the new changes.", "ContainerSampleData", false, false, false, "ContainerSampleData", 1053102, false, true, false, null)]
    protected ContainerSampleData_Environment _ContainerSampleData;
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_SamplingPlan")]
    protected new Environment _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_SamplingStatus")]
    [Metadata("SampleStatus", "SampleStatusEnum", false, false, false, "String", 1053155, false, false, false, null)]
    protected Environment _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_ContainerSampleDataItem")]
    [Metadata("Used to  record all sampling plan data for a container.  The sampling plan data is stored in this objects in order to keep updates from a user to the SamplingPlan from changing once the container has started its sampling plan tested.  This is also used to provide selection data for the user on the Collect Sampling transaction.  The next container will pick up the new changes.", "ContainerSampleData", false, false, false, "SubentityRef", 1053102, false, false, false, null)]
    protected Environment _ContainerSampleDataItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_AQLLevel")]
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, false, "NamedObjectRef", 1053105, false, false, false, null)]
    protected Environment _AQLLevel;
    [Metadata("Collect Sampling Data Points  - Required to send RDO List to WCF Service", "CollectSamplingDataPoints", false, false, false, "CollectSamplingDataPoints", 1053148, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_CollectSamplingDataPoints")]
    protected CollectSamplingDataPoints_Environment _CollectSamplingDataPoints;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_CreateProductionEvent")]
    [Metadata("Service to create a new Event in the system.", "CreateProductionEvent", false, false, false, "CreateProductionEvent", 1053149, false, false, false, null)]
    protected CreateProductionEvent_Environment _CreateProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_SampleTest")]
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, false, false, "RevisionedObjectRef", 1053111, false, false, false, null)]
    protected Environment _SampleTest;
    [Metadata("Each instance of this object maintains a set of quantity ranges and their associated Lot Size Code to be assigned to a Sample Plan.", "InspectionLevel", false, false, false, "NamedObjectRef", 1053133, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_InspectionLevel")]
    protected Environment _InspectionLevel;
    [Metadata("Used to identify the Sample Test type associated with a Product Sampling Plan.\r\nCounted= 1\r\nMeasured = 2", "SampleTypeEnum", false, false, false, "Integer", 1053100, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_SampleType")]
    protected Environment _SampleType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_AllowedRejects")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053160, false, false, false, null)]
    protected Environment _AllowedRejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_RequiredSamples")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053153, false, false, false, null)]
    protected Environment _RequiredSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_TotalSampleCompleted")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053158, false, false, false, null)]
    protected Environment _TotalSampleCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_PassedSamples")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053151, false, false, false, null)]
    protected Environment _PassedSamples;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_ProcessESignatures")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    protected new Environment _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_AcceptableRejectCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053147, false, false, false, null)]
    protected Environment _AcceptableRejectCount;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053154, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_SamplesTested")]
    protected Environment _SamplesTested;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053150, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_FailedSamples")]
    protected Environment _FailedSamples;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048625, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingData_Environment_Product")]
    protected Environment _Product;

    public ChangeQty_Environment ChangeQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeQty), (object) value);
      }
      get
      {
        return (ChangeQty_Environment) this.PropertyGet(nameof (ChangeQty));
      }
    }

    public Environment RejectReasons
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReasons), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RejectReasons));
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

    public CollectSamplingDataDetails_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (CollectSamplingDataDetails_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public ContainerSampleData_Environment ContainerSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleData), (object) value);
      }
      get
      {
        return (ContainerSampleData_Environment) this.PropertyGet(nameof (ContainerSampleData));
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

    public Environment ContainerSampleDataItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerSampleDataItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerSampleDataItem));
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

    public CollectSamplingDataPoints_Environment CollectSamplingDataPoints
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingDataPoints), (object) value);
      }
      get
      {
        return (CollectSamplingDataPoints_Environment) this.PropertyGet(nameof (CollectSamplingDataPoints));
      }
    }

    public CreateProductionEvent_Environment CreateProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreateProductionEvent), (object) value);
      }
      get
      {
        return (CreateProductionEvent_Environment) this.PropertyGet(nameof (CreateProductionEvent));
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

    public Environment SampleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleType));
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

    public new Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
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

    public Environment TotalSampleCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSampleCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalSampleCompleted));
      }
    }

    public Environment PassedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (PassedSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PassedSamples));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Environment AcceptableRejectCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (AcceptableRejectCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AcceptableRejectCount));
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

    public Environment FailedSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (FailedSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FailedSamples));
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
