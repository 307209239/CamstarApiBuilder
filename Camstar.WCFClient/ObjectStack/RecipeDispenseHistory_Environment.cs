// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeDispenseHistory_Environment
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
  public class RecipeDispenseHistory_Environment : ComponentIssueHistory_Environment
  {
    [Metadata("One of the three possible types of Tasks in a RecipeList, this is a new TaskItem type. A RecipeIssueItem is used to define a component material to be issued to a RecipeList's Target Container.", "RecipeIssueItem", false, false, true, "NamedSubentityRef", 1051859, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Environment_RecipeIssueItem")]
    protected Environment _RecipeIssueItem;
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, false, true, "RevisionedObjectRef", 1051849, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Environment_RecipeList")]
    protected Environment _RecipeList;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, false, true, "ContainerRef", 1051854, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Environment_Batch")]
    protected Environment _Batch;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Environment_MasterRecipe")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, true, "RevisionedObjectRef", 1051846, false, false, false, null)]
    protected Environment _MasterRecipe;
    [DataMember(EmitDefaultValue = false, Name = "RecipeDispenseHistory_Environment_BypassExpirationCheck")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051857, false, false, false, "0")]
    protected Environment _BypassExpirationCheck;

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
  }
}
