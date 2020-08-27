// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeDispense
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
  public class RecipeDispense : ComponentIssue
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_MaterialList")]
    protected NamedSubentityRef[] _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_RecipeExpressionFields")]
    protected RecipeExpressionFields _RecipeExpressionFields;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_RecipeIssueItem")]
    protected NamedSubentityRef _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_RecipeSequenceValidation")]
    protected RecipeSequenceValidation _RecipeSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_RecipeList")]
    protected RevisionedObjectRef _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Batch")]
    protected ContainerRef _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_FEFOFlag")]
    protected Enumeration<FEFOEnum, int> _FEFOFlag;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_CatchQtyErrors")]
    protected Primitive<bool> _CatchQtyErrors;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_UseMaterialFromBatch")]
    protected Primitive<bool> _UseMaterialFromBatch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_BypassExpirationCheck")]
    protected Primitive<bool> _BypassExpirationCheck;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_AreRequiredTasksCompleted")]
    protected Primitive<bool> _AreRequiredTasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_OverrideUOMMismatch")]
    protected Primitive<bool> _OverrideUOMMismatch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispense_Operation")]
    protected new NamedObjectRef _Operation;

    public override bool Equals(object obj)
    {
      return obj is RecipeDispense && object.Equals((object) this._Spec, (object) ((RecipeDispense) obj)._Spec) && (this.CompareArrays((Array) this._MaterialList, (Array) ((RecipeDispense) obj)._MaterialList) && object.Equals((object) this._MasterRecipe, (object) ((RecipeDispense) obj)._MasterRecipe)) && (object.Equals((object) this._RecipeExpressionFields, (object) ((RecipeDispense) obj)._RecipeExpressionFields) && object.Equals((object) this._RecipeIssueItem, (object) ((RecipeDispense) obj)._RecipeIssueItem) && (object.Equals((object) this._RecipeSequenceValidation, (object) ((RecipeDispense) obj)._RecipeSequenceValidation) && object.Equals((object) this._RecipeList, (object) ((RecipeDispense) obj)._RecipeList))) && (object.Equals((object) this._Container, (object) ((RecipeDispense) obj)._Container) && object.Equals((object) this._Batch, (object) ((RecipeDispense) obj)._Batch) && (object.Equals((object) this._FEFOFlag, (object) ((RecipeDispense) obj)._FEFOFlag) && object.Equals((object) this._CatchQtyErrors, (object) ((RecipeDispense) obj)._CatchQtyErrors)) && (object.Equals((object) this._UseMaterialFromBatch, (object) ((RecipeDispense) obj)._UseMaterialFromBatch) && object.Equals((object) this._BypassExpirationCheck, (object) ((RecipeDispense) obj)._BypassExpirationCheck) && (object.Equals((object) this._AreRequiredTasksCompleted, (object) ((RecipeDispense) obj)._AreRequiredTasksCompleted) && object.Equals((object) this._OverrideUOMMismatch, (object) ((RecipeDispense) obj)._OverrideUOMMismatch)))) && object.Equals((object) this._Operation, (object) ((RecipeDispense) obj)._Operation) && base.Equals(obj);
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

    public NamedSubentityRef[] MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (MaterialList));
      }
    }

    public RevisionedObjectRef MasterRecipe
    {
      [param: In] set
      {
        this.PropertySet(nameof (MasterRecipe), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MasterRecipe));
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

    public NamedSubentityRef RecipeIssueItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeIssueItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (RecipeIssueItem));
      }
    }

    public RecipeSequenceValidation RecipeSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeSequenceValidation), (object) value);
      }
      get
      {
        return (RecipeSequenceValidation) this.PropertyGet(nameof (RecipeSequenceValidation));
      }
    }

    public RevisionedObjectRef RecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RecipeList));
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

    public ContainerRef Batch
    {
      [param: In] set
      {
        this.PropertySet(nameof (Batch), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Batch));
      }
    }

    public Enumeration<FEFOEnum, int> FEFOFlag
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOFlag), (object) value);
      }
      get
      {
        return (Enumeration<FEFOEnum, int>) this.PropertyGet(nameof (FEFOFlag));
      }
    }

    public Primitive<bool> CatchQtyErrors
    {
      [param: In] set
      {
        this.PropertySet(nameof (CatchQtyErrors), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CatchQtyErrors));
      }
    }

    public Primitive<bool> UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Primitive<bool> BypassExpirationCheck
    {
      [param: In] set
      {
        this.PropertySet(nameof (BypassExpirationCheck), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BypassExpirationCheck));
      }
    }

    public Primitive<bool> AreRequiredTasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (AreRequiredTasksCompleted), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AreRequiredTasksCompleted));
      }
    }

    public Primitive<bool> OverrideUOMMismatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideUOMMismatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OverrideUOMMismatch));
      }
    }

    public new NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }
  }
}
