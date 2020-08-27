// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeIssueItemChanges_Environment
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
  public class RecipeIssueItemChanges_Environment : RecipeItemChanges_Environment
  {
    [Metadata("Enumeration for TaskType.\r\n1 = Start Process Task\r\n2 = End Process Task\r\n3 = Regular Process Task", "TaskTypeEnum", false, false, false, "Integer", 1050512, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_TaskType")]
    protected new Environment _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected new Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_ManualWeighESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1051819, false, false, true, null)]
    protected Environment _ManualWeighESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_RecipeMaterialListItem")]
    [Metadata("A single entry MaterialListItem of type RecipeMaterialListItem.", "RecipeMaterialListItemChanges", false, false, false, "RecipeMaterialListItemChanges", 1051820, true, false, false, null)]
    protected RecipeMaterialListItemChanges_Environment _RecipeMaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_ObjectToChange")]
    [Metadata("One of the three possible types of Tasks in a RecipeList, this is a new TaskItem type. A RecipeIssueItem is used to define a component material to be issued to a RecipeList's Target Container.", "RecipeIssueItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A Named Object Group that represents a group of Scales", "ScaleGroup", false, false, false, "NamedObjectRef", 1051811, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_Scales")]
    protected Environment _Scales;
    [Metadata("One of the three possible types of Tasks in a RecipeList, this is a new TaskItem type. A RecipeIssueItem is used to define a component material to be issued to a RecipeList's Target Container.", "RecipeIssueItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051821, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_UseMaterialFromBatch")]
    protected Environment _UseMaterialFromBatch;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051817, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_AllowManualWeighOverride")]
    protected Environment _AllowManualWeighOverride;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051832, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_IsManualReadingOnly")]
    protected Environment _IsManualReadingOnly;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050503, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeIssueItemChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskType));
      }
    }

    public new Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment ManualWeighESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ManualWeighESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ManualWeighESigRequirement));
      }
    }

    public RecipeMaterialListItemChanges_Environment RecipeMaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeMaterialListItem), (object) value);
      }
      get
      {
        return (RecipeMaterialListItemChanges_Environment) this.PropertyGet(nameof (RecipeMaterialListItem));
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

    public Environment Scales
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scales), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Scales));
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

    public Environment UseMaterialFromBatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseMaterialFromBatch), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseMaterialFromBatch));
      }
    }

    public Environment AllowManualWeighOverride
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowManualWeighOverride), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowManualWeighOverride));
      }
    }

    public Environment IsManualReadingOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsManualReadingOnly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsManualReadingOnly));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
