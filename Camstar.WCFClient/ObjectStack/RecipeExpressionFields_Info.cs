// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeExpressionFields_Info
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
  public class RecipeExpressionFields_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_Info_Batch")]
    protected Info _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_Info_RecipeIssueItem")]
    protected Info _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_Info_MaterialContainer")]
    protected Info _MaterialContainer;
    [DataMember(EmitDefaultValue = false, Name = "RecipeExpressionFields_Info_QtyRequired")]
    protected Info _QtyRequired;

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

    public Info QtyRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequired));
      }
    }
  }
}
