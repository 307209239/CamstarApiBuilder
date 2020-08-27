// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteRecipeTask
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
  public class ExecuteRecipeTask : ExecuteProductionProcess
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_IssueDifferenceReason")]
    protected NamedObjectRef _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_MaterialContainer")]
    protected ContainerRef _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_ProcessSequenceValidation")]
    protected RecipeSequenceValidation _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Task")]
    protected new NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_RecipeExpressionFields")]
    protected RecipeExpressionFields _RecipeExpressionFields;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_TaskList")]
    protected new RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_TaskUsage")]
    protected Enumeration<TaskUsageEnum, int> _TaskUsage;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_ElectronicProcedure")]
    protected new RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_CompleteTaskForBatch")]
    protected Primitive<bool> _CompleteTaskForBatch;

    public override bool Equals(object obj)
    {
      return obj is ExecuteRecipeTask && object.Equals((object) this._IssueDifferenceReason, (object) ((ExecuteRecipeTask) obj)._IssueDifferenceReason) && (object.Equals((object) this._Spec, (object) ((ExecuteRecipeTask) obj)._Spec) && object.Equals((object) this._MaterialContainer, (object) ((ExecuteRecipeTask) obj)._MaterialContainer)) && (object.Equals((object) this._Container, (object) ((ExecuteRecipeTask) obj)._Container) && object.Equals((object) this._Carrier, (object) ((ExecuteRecipeTask) obj)._Carrier) && (object.Equals((object) this._ProcessSequenceValidation, (object) ((ExecuteRecipeTask) obj)._ProcessSequenceValidation) && object.Equals((object) this._Task, (object) ((ExecuteRecipeTask) obj)._Task))) && (object.Equals((object) this._RecipeExpressionFields, (object) ((ExecuteRecipeTask) obj)._RecipeExpressionFields) && object.Equals((object) this._TaskList, (object) ((ExecuteRecipeTask) obj)._TaskList) && (object.Equals((object) this._TaskUsage, (object) ((ExecuteRecipeTask) obj)._TaskUsage) && object.Equals((object) this._ElectronicProcedure, (object) ((ExecuteRecipeTask) obj)._ElectronicProcedure)) && object.Equals((object) this._CompleteTaskForBatch, (object) ((ExecuteRecipeTask) obj)._CompleteTaskForBatch)) && base.Equals(obj);
    }

    public NamedObjectRef IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public ContainerRef MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public new NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public RecipeSequenceValidation ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (RecipeSequenceValidation) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public new NamedSubentityRef Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Task));
      }
    }

    public RecipeExpressionFields RecipeExpressionFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeExpressionFields), (object) value);
      }
      get
      {
        return (RecipeExpressionFields) this.PropertyGet(nameof (RecipeExpressionFields));
      }
    }

    public new RevisionedObjectRef TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TaskList));
      }
    }

    public Enumeration<TaskUsageEnum, int> TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Enumeration<TaskUsageEnum, int>) this.PropertyGet(nameof (TaskUsage));
      }
    }

    public new RevisionedObjectRef ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Primitive<bool> CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
