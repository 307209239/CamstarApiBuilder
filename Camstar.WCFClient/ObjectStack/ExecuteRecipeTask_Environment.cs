// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteRecipeTask_Environment
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
  public class ExecuteRecipeTask_Environment : ExecuteProductionProcess_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_IssueDifferenceReason")]
    [Metadata("Describes the reason for the difference between the required quantity and the actual quantity issued.", "IssueDifferenceReason", false, false, false, "NamedObjectRef", 1049467, false, false, true, null)]
    protected Environment _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_Spec")]
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, true, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_MaterialContainer")]
    [Metadata("Material Container", "MaterialContainer", false, false, false, "ContainerRef", 1051878, false, false, true, null)]
    protected Environment _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_Container")]
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, true, false, "ContainerRef", 1051854, false, false, true, null)]
    protected new Environment _Container;
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, false, "NamedObjectRef", 1051807, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_Carrier")]
    protected new Environment _Carrier;
    [Metadata("Extends validation logic to RecipeTasks/RecipeList and MasterRecipe and verifies they have been completed in the correct sequence.", "RecipeSequenceValidation", false, false, true, "RecipeSequenceValidation", 1052217, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_ProcessSequenceValidation")]
    protected RecipeSequenceValidation_Environment _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_Task")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, true, false, "NamedSubentityRef", 1051879, false, false, true, null)]
    protected new Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_RecipeExpressionFields")]
    [Metadata("Stores the common fields for several objects as well as the context for evaluating these expressions", "RecipeExpressionFields", false, false, true, "RecipeExpressionFields", 1052232, true, false, false, null)]
    protected RecipeExpressionFields_Environment _RecipeExpressionFields;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_TaskList")]
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, true, false, "RevisionedObjectRef", 1051849, false, false, true, null)]
    protected new Environment _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_TaskUsage")]
    [Metadata("Enumeration of the Task Usage\r\n1 = Container\r\n2 = Batch", "TaskUsageEnum", false, false, true, "Integer", 1051883, false, false, true, null)]
    protected Environment _TaskUsage;
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_ElectronicProcedure")]
    protected new Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Environment_CompleteTaskForBatch")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051880, false, false, false, "0")]
    protected Environment _CompleteTaskForBatch;

    public Environment IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueDifferenceReason));
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

    public Environment MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaterialContainer));
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

    public new Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }

    public RecipeSequenceValidation_Environment ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (RecipeSequenceValidation_Environment) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public new Environment Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Task));
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

    public new Environment TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskList));
      }
    }

    public Environment TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskUsage));
      }
    }

    public new Environment ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Environment CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
