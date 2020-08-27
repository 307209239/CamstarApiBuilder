// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductFamilyChanges_Environment
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
  public class ProductFamilyChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_TrainingReqGroup")]
    [Metadata("TrainingRequirement Group", "TrainingReqGroup", false, false, false, "NamedObjectRef", 1050473, false, false, true, null)]
    protected Environment _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_StdStartUOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1050599, false, false, true, null)]
    protected Environment _StdStartUOM2;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1050598, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_StdStartQty2")]
    protected Environment _StdStartQty2;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_StdStartUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1049509, false, false, true, null)]
    protected Environment _StdStartUOM;
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1051905, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_ContainerNumberingRule")]
    protected Environment _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_SamplingPlan")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    protected Environment _SamplingPlan;
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1048649, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_StdCost")]
    protected Environment _StdCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_PlannedCost")]
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1048706, false, false, false, null)]
    protected Environment _PlannedCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050089, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_StdStartQty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049654, false, false, false, null)]
    protected Environment _StdStartQty;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_CurrentCost")]
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1048645, false, false, false, null)]
    protected Environment _CurrentCost;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_Workflow")]
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    protected Environment _Workflow;
    [Metadata("A Document Set is a list of one or more documents. Most Modeling entities include a reference to a Document Set. Documents are used in this context to provide extended (unstructured) information, such as product drawings, scanned images, relating existing manufacturing specifications, or operating procedures. Each instance of a Document (CDO) includes an identifier for the external document (i.e., a file name or a URL) and a reference to the program used for presenting the document.", "DocumentSet", false, false, false, "NamedObjectRef", 1048646, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_DocumentSet")]
    protected Environment _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_ObjectToChange")]
    [Metadata("A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Each Product can belong to a Product Family. Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.\r\n\r\nProduct Families are a slightly different concept from object groups. Grouping (Product bases, Operations, Resources, etc.) is done for validation and reporting. Groups are more free form and the application has less concrete knowledge of Groups (than Product Families). Another differentiation is that one object can belong to multiple Groups, but a product can only belong to one Product Family. Finally, Groups can contain other (sub-) Groups. Product Families can only contain Products.", "ProductFamily", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductFamilyChanges_Environment_Products")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1048648, false, true, true, null)]
    protected Environment _Products;

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

    public Environment StdStartUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartUOM2));
      }
    }

    public Environment StdStartQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartQty2));
      }
    }

    public Environment StdStartUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartUOM));
      }
    }

    public Environment ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNumberingRule));
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

    public Environment StdCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdCost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdCost));
      }
    }

    public Environment PlannedCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlannedCost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PlannedCost));
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

    public Environment StdStartQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (StdStartQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StdStartQty));
      }
    }

    public Environment CurrentCost
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentCost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentCost));
      }
    }

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public Environment DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DocumentSet));
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

    public Environment Products
    {
      [param: In] set
      {
        this.PropertySet(nameof (Products), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Products));
      }
    }
  }
}
