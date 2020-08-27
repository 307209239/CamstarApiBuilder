// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeDispense_Environment
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
  public class RecipeDispense_Environment : ComponentIssue_Environment
  {
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, false, false, "RevisionedObjectRef", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_MaterialList")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "MaterialListItem", false, false, true, "NamedSubentityRef", 1049721, false, true, false, null)]
    protected Environment _MaterialList;
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_MasterRecipe")]
    protected Environment _MasterRecipe;
    [Metadata("Stores the common fields for several objects as well as the context for evaluating these expressions", "RecipeExpressionFields", false, false, true, "RecipeExpressionFields", 1052232, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_RecipeExpressionFields")]
    protected RecipeExpressionFields_Environment _RecipeExpressionFields;
    [Metadata("One of the three possible types of Tasks in a RecipeList, this is a new TaskItem type. A RecipeIssueItem is used to define a component material to be issued to a RecipeList's Target Container.", "RecipeIssueItem", false, false, false, "NamedSubentityRef", 1051859, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_RecipeIssueItem")]
    protected Environment _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_RecipeSequenceValidation")]
    [Metadata("Extends validation logic to RecipeTasks/RecipeList and MasterRecipe and verifies they have been completed in the correct sequence.", "RecipeSequenceValidation", false, false, true, "RecipeSequenceValidation", 1052218, true, false, false, null)]
    protected RecipeSequenceValidation_Environment _RecipeSequenceValidation;
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, false, false, "RevisionedObjectRef", 1051849, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_RecipeList")]
    protected Environment _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_Container")]
    [Metadata("Material Container", "MaterialContainer", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    protected new Environment _Container;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, false, "ContainerRef", 1051854, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_Batch")]
    protected Environment _Batch;
    [Metadata("An enumeration of FEFOEnforceType. 0=Not Enforced, 1=Enforced, 2=Warn, 3=WarnWithESig", "FEFOEnum", false, false, true, "Integer", 1051858, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_FEFOFlag")]
    protected Environment _FEFOFlag;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_CatchQtyErrors")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051941, false, false, false, "0")]
    protected Environment _CatchQtyErrors;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_UseMaterialFromBatch")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051821, false, false, false, "0")]
    protected Environment _UseMaterialFromBatch;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051857, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_BypassExpirationCheck")]
    protected Environment _BypassExpirationCheck;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052215, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_AreRequiredTasksCompleted")]
    protected Environment _AreRequiredTasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_OverrideUOMMismatch")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051860, false, false, false, "0")]
    protected Environment _OverrideUOMMismatch;
    [Metadata("An Operation is a manufacturing or processing point where inventory and production activities are tracked. The Operation describes such things as the reason codes, the work center, and the allowed transactions for the movement of material through  a workflow step. In contrast, specifications define the specific processing that is performed at an operation.\r\n\r\nThe Operation also provides the general rules for the process and provides a general reporting construct. An Operation is referenced by a specification at a workflow step. \r\n\r\n", "Operation", false, false, false, "NamedObjectRef", 1048815, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Environment_Operation")]
    protected new Environment _Operation;

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

    public Environment MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaterialList));
      }
    }

    public Environment MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MasterRecipe));
      }
    }

    public RecipeExpressionFields_Environment RecipeExpressionFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeExpressionFields), (object) value);
      }
      get
      {
        return (RecipeExpressionFields_Environment) this.PropertyGet(nameof (RecipeExpressionFields));
      }
    }

    public Environment RecipeIssueItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeIssueItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeIssueItem));
      }
    }

    public RecipeSequenceValidation_Environment RecipeSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeSequenceValidation), (object) value);
      }
      get
      {
        return (RecipeSequenceValidation_Environment) this.PropertyGet(nameof (RecipeSequenceValidation));
      }
    }

    public Environment RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecipeList));
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

    public Environment Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Batch));
      }
    }

    public Environment FEFOFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOFlag), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FEFOFlag));
      }
    }

    public Environment CatchQtyErrors
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatchQtyErrors), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CatchQtyErrors));
      }
    }

    public Environment UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Environment BypassExpirationCheck
    {
      [param: In] set
      {
        this.PropertySet(nameof (BypassExpirationCheck), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BypassExpirationCheck));
      }
    }

    public Environment AreRequiredTasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (AreRequiredTasksCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AreRequiredTasksCompleted));
      }
    }

    public Environment OverrideUOMMismatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideUOMMismatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OverrideUOMMismatch));
      }
    }

    public new Environment Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
