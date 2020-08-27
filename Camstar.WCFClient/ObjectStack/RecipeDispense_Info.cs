// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeDispense_Info
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
  public class RecipeDispense_Info : ComponentIssue_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_MaterialList")]
    protected Info _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_RecipeExpressionFields")]
    protected RecipeExpressionFields_Info _RecipeExpressionFields;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_RecipeIssueItem")]
    protected Info _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_RecipeSequenceValidation")]
    protected RecipeSequenceValidation_Info _RecipeSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_RecipeList")]
    protected Info _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_Batch")]
    protected Info _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_FEFOFlag")]
    protected Info _FEFOFlag;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_CatchQtyErrors")]
    protected Info _CatchQtyErrors;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_UseMaterialFromBatch")]
    protected Info _UseMaterialFromBatch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_BypassExpirationCheck")]
    protected Info _BypassExpirationCheck;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_AreRequiredTasksCompleted")]
    protected Info _AreRequiredTasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_OverrideUOMMismatch")]
    protected Info _OverrideUOMMismatch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Info_Operation")]
    protected new Info _Operation;

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

    public Info MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaterialList));
      }
    }

    public Info MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MasterRecipe));
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

    public Info RecipeIssueItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeIssueItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeIssueItem));
      }
    }

    public RecipeSequenceValidation_Info RecipeSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeSequenceValidation), (object) value);
      }
      get
      {
        return (RecipeSequenceValidation_Info) this.PropertyGet(nameof (RecipeSequenceValidation));
      }
    }

    public Info RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeList));
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

    public Info Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Batch));
      }
    }

    public Info FEFOFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOFlag), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FEFOFlag));
      }
    }

    public Info CatchQtyErrors
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatchQtyErrors), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CatchQtyErrors));
      }
    }

    public Info UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Info BypassExpirationCheck
    {
      [param: In] set
      {
        this.PropertySet(nameof (BypassExpirationCheck), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BypassExpirationCheck));
      }
    }

    public Info AreRequiredTasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (AreRequiredTasksCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AreRequiredTasksCompleted));
      }
    }

    public Info OverrideUOMMismatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideUOMMismatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OverrideUOMMismatch));
      }
    }

    public new Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
