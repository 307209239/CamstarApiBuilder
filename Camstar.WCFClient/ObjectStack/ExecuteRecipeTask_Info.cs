// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteRecipeTask_Info
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
  public class ExecuteRecipeTask_Info : ExecuteProductionProcess_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_IssueDifferenceReason")]
    protected Info _IssueDifferenceReason;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_MaterialContainer")]
    protected Info _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_ProcessSequenceValidation")]
    protected RecipeSequenceValidation_Info _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_Task")]
    protected new Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_RecipeExpressionFields")]
    protected RecipeExpressionFields_Info _RecipeExpressionFields;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_TaskList")]
    protected new Info _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_TaskUsage")]
    protected Info _TaskUsage;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_ElectronicProcedure")]
    protected new Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteRecipeTask_Info_CompleteTaskForBatch")]
    protected Info _CompleteTaskForBatch;

    public Info IssueDifferenceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueDifferenceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueDifferenceReason));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public Info MaterialContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaterialContainer));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public RecipeSequenceValidation_Info ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (RecipeSequenceValidation_Info) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public new Info Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Task));
      }
    }

    public RecipeExpressionFields_Info RecipeExpressionFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeExpressionFields), (object) value);
      }
      get
      {
        return (RecipeExpressionFields_Info) this.PropertyGet(nameof (RecipeExpressionFields));
      }
    }

    public new Info TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskList));
      }
    }

    public Info TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskUsage));
      }
    }

    public new Info ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public Info CompleteTaskForBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteTaskForBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteTaskForBatch));
      }
    }
  }
}
