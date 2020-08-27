// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterRecipeChanges_Environment
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
  public class MasterRecipeChanges_Environment : ProductionProcessChanges_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1051835, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_RecipeQtyNominal")]
    protected Environment _RecipeQtyNominal;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_RecipeQtyUpperLimit")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051836, false, false, false, null)]
    protected Environment _RecipeQtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_PrinterLabelDefinition")]
    [Metadata("Defines the properties of a printer label.", "PrinterLabelDefinition", false, false, false, "RevisionedObjectRef", 1050616, false, false, true, null)]
    protected Environment _PrinterLabelDefinition;
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1051838, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_RecipeUOM")]
    protected Environment _RecipeUOM;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_RecipeQtyLowerLimit")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051834, false, false, false, null)]
    protected Environment _RecipeQtyLowerLimit;
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Master Recipe Detail", "MasterRecipeDetailChanges", false, true, false, "MasterRecipeDetailChanges", 1051867, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_EProcedureDetails")]
    protected MasterRecipeDetailChanges_Environment _EProcedureDetails;
    [Metadata("Master Recipe", "MasterRecipeBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_Base")]
    protected new Environment _Base;
    [Metadata("A Workflow defines the route and processing required for a manufacturing process, and is the primary driving object of the InSite factory model. When a Container is created (started) it references a Workflow (and a Step within that Workflow). The default Workflow for the Start transaction is the Workflow referenced in the Product definition. \r\n\r\nA Workflow is a collection of Steps that are linked by Paths and ReworkPaths. Steps reference either other Workflows or Specs, and a Spec references an Operation.  Note that the definition of Step, Spec, and Operation controls the processing details at any individual point in the workflow.", "Workflow", false, false, false, "RevisionedObjectRef", 1048654, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_Workflow")]
    protected Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051833, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("A Product is typically a definition of what kind of material needs to be provided to a customer or what kind of material is being used as a raw material or other component in a manufacturing process.  Products can belong to a Product Family. A product to be manufactured will have an associated Workflow. Attributes of the Workflow may be overridden to be product specific.\r\n\r\nOptionally, a Product can belong to a Product Family. A Product Family is used to group products for the purpose of simplifying the maintenance task (for modeling data). Common attributes such as costing or processing information can then be provided for a Product Family and applied to each Product within the family.", "Product", false, false, false, "RevisionedObjectRef", 1051837, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Environment_RecipeProduct")]
    protected Environment _RecipeProduct;

    public Environment RecipeQtyNominal
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyNominal), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeQtyNominal));
      }
    }

    public Environment RecipeQtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyUpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeQtyUpperLimit));
      }
    }

    public Environment PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public Environment RecipeUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeUOM));
      }
    }

    public Environment RecipeQtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyLowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeQtyLowerLimit));
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

    public MasterRecipeDetailChanges_Environment EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (MasterRecipeDetailChanges_Environment) this.PropertyGet(nameof (EProcedureDetails));
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

    public Environment RecipeProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeProduct), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeProduct));
      }
    }
  }
}
