// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ComputationItemChanges_Info))]
  [KnownType(typeof (TransactionItemChanges_Info))]
  [KnownType(typeof (InstructionItemChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TaskItemChanges_Info : ProcessItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_ESigRequirement")]
    protected new Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_PrerequisiteTasks")]
    protected new Info _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_InstructionType")]
    protected Info _InstructionType;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_StartTimerTaskDtl")]
    protected StartTimerTaskDtlChanges_Info _StartTimerTaskDtl;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_EndTimerTaskDtl")]
    protected EndTimerTaskDtlChanges_Info _EndTimerTaskDtl;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "TaskItemChanges_Info_Name")]
    protected new Info _Name;

    public new Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
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

    public Info InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstructionType));
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

    public StartTimerTaskDtlChanges_Info StartTimerTaskDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimerTaskDtl), (object) value);
      }
      get
      {
        return (StartTimerTaskDtlChanges_Info) this.PropertyGet(nameof (StartTimerTaskDtl));
      }
    }

    public EndTimerTaskDtlChanges_Info EndTimerTaskDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimerTaskDtl), (object) value);
      }
      get
      {
        return (EndTimerTaskDtlChanges_Info) this.PropertyGet(nameof (EndTimerTaskDtl));
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
  }
}
