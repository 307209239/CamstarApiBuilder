// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterRecipeDetailChanges_Environment
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
  public class MasterRecipeDetailChanges_Environment : ProductionProcessDetailChanges_Environment
  {
    [Metadata("Relative sequence number", "", false, true, false, "Integer", 1051839, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_Environment_SubSequence")]
    protected Environment _SubSequence;
    [Metadata("A specification (Spec) describes the processing that takes place at a Step within a Workflow. It references many other Modeling components including an Operation, Setup, Data Collection Definitions and Resources. Specs also include detailed scheduling and processing parameter information. A Spec is referenced (used) by a Step within a Workflow. Many Workflow Steps can use one Spec.\r\n\r\nA Spec is used to define the processing that is to be performed. An Operation is used to define (rules for) the flow or movement of Material through the Factory.\r\n\r\nSee the Operation Definition for Scheduling Details information.", "Spec", false, true, false, "RevisionedObjectRef", 1049033, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_Environment_Spec")]
    protected Environment _Spec;
    [Metadata("The equivalent of TaskList for MasterRecipe.", "RecipeList", false, true, false, "RevisionedObjectRef", 1051849, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_Environment_TaskList")]
    protected new Environment _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_Environment_ListItemToChange")]
    [Metadata("Master Recipe Detail", "MasterRecipeDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Master Recipe Detail", "MasterRecipeDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public Environment SubSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubSequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubSequence));
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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
