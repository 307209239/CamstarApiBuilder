// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeListChanges_Environment
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
  public class RecipeListChanges_Environment : ProcessListChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_TargetContainerUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1051815, false, false, true, null)]
    protected Environment _TargetContainerUOM;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_TargetContainerPlannedQty")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051813, false, false, false, null)]
    protected Environment _TargetContainerPlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_Carriers")]
    [Metadata("A Named Object Group that represents a group of Carriers", "CarrierGroup", false, false, false, "NamedObjectRef", 1051805, false, false, true, null)]
    protected Environment _Carriers;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_PrerequisiteTaskList")]
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, false, false, "RevisionedObjectRef", 1050516, false, false, true, null)]
    protected new Environment _PrerequisiteTaskList;
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_Scales")]
    [Metadata("A Named Object Group that represents a group of Scales", "ScaleGroup", false, false, false, "NamedObjectRef", 1052238, false, false, true, null)]
    protected Environment _Scales;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_Base")]
    [Metadata("Recipe List", "RecipeListBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItemChanges", false, true, false, "ProcessItemChanges", 1050574, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_Tasks")]
    protected new ProcessItemChanges_Environment _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_LabelTxnMap")]
    [Metadata("Contains a match between a Recipe List and a label definition to be printed.", "RecipeLabelMapChanges", false, false, false, "RecipeLabelMapChanges", 1050618, false, true, false, null)]
    protected RecipeLabelMapChanges_Environment _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_TargetContainerProduct")]
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1051814, false, false, true, null)]
    protected Environment _TargetContainerProduct;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051810, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Environment_TargetContainerLevel")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1051812, false, false, true, null)]
    protected Environment _TargetContainerLevel;

    public Environment TargetContainerUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetContainerUOM));
      }
    }

    public Environment TargetContainerPlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerPlannedQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetContainerPlannedQty));
      }
    }

    public Environment Carriers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carriers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carriers));
      }
    }

    public new Environment PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTaskList));
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

    public Environment Scales
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scales), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Scales));
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

    public new ProcessItemChanges_Environment Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (ProcessItemChanges_Environment) this.PropertyGet(nameof (Tasks));
      }
    }

    public RecipeLabelMapChanges_Environment LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (RecipeLabelMapChanges_Environment) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public Environment TargetContainerProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetContainerProduct));
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

    public Environment TargetContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerLevel), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetContainerLevel));
      }
    }
  }
}
