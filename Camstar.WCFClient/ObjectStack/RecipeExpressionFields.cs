// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeExpressionFields
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
  public class RecipeExpressionFields : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_Batch")]
    protected ContainerRef _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_RecipeIssueItem")]
    protected NamedSubentityRef _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_MaterialContainer")]
    protected ContainerRef _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_QtyRequired")]
    protected Primitive<double> _QtyRequired;

    public override bool Equals(object obj)
    {
      return obj is RecipeExpressionFields && object.Equals((object) this._MasterRecipe, (object) ((RecipeExpressionFields) obj)._MasterRecipe) && (object.Equals((object) this._Batch, (object) ((RecipeExpressionFields) obj)._Batch) && object.Equals((object) this._RecipeIssueItem, (object) ((RecipeExpressionFields) obj)._RecipeIssueItem)) && (object.Equals((object) this._MaterialContainer, (object) ((RecipeExpressionFields) obj)._MaterialContainer) && object.Equals((object) this._QtyRequired, (object) ((RecipeExpressionFields) obj)._QtyRequired)) && base.Equals(obj);
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

    public Primitive<double> QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyRequired));
      }
    }
  }
}
