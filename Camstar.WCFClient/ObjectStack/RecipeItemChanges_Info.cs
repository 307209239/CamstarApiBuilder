// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RecipeIssueItemChanges_Info))]
  [Serializable]
  public class RecipeItemChanges_Info : ProcessItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_TaskType")]
    protected new Info _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_Sequence")]
    protected new Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_TaskUsage")]
    protected new Info _TaskUsage;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_PrerequisiteTasks")]
    protected new Info _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecipeItemChanges_Info_DocumentSet")]
    protected Info _DocumentSet;

    public new Info TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskType));
      }
    }

    public new Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Info TaskUsage
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

    public new Info PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }
  }
}
