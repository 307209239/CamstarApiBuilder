// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeDispenseHistory_Info
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
  public class RecipeDispenseHistory_Info : ComponentIssueHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Info_RecipeIssueItem")]
    protected Info _RecipeIssueItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Info_RecipeList")]
    protected Info _RecipeList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Info_Batch")]
    protected Info _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Info_MasterRecipe")]
    protected Info _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Info_BypassExpirationCheck")]
    protected Info _BypassExpirationCheck;

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
  }
}
