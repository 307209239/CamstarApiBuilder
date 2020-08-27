// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeDispenseHistory
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
  public class RecipeDispenseHistory : ComponentIssueHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_RecipeIssueItem")]
    protected NamedSubentityRef _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_RecipeList")]
    protected RevisionedObjectRef _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Batch")]
    protected ContainerRef _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_MasterRecipe")]
    protected RevisionedObjectRef _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_BypassExpirationCheck")]
    protected Primitive<bool> _BypassExpirationCheck;

    public override bool Equals(object obj)
    {
      return obj is RecipeDispenseHistory && object.Equals((object) this._RecipeIssueItem, (object) ((RecipeDispenseHistory) obj)._RecipeIssueItem) && (object.Equals((object) this._RecipeList, (object) ((RecipeDispenseHistory) obj)._RecipeList) && object.Equals((object) this._Batch, (object) ((RecipeDispenseHistory) obj)._Batch)) && (object.Equals((object) this._MasterRecipe, (object) ((RecipeDispenseHistory) obj)._MasterRecipe) && object.Equals((object) this._BypassExpirationCheck, (object) ((RecipeDispenseHistory) obj)._BypassExpirationCheck)) && base.Equals(obj);
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
  }
}
