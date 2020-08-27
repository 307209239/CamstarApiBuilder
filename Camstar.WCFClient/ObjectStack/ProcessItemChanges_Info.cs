// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TaskItemChanges_Info))]
  [KnownType(typeof (RecipeItemChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ProcessItemChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_TaskType")]
    protected Info _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_Instruction")]
    protected Info _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_ReportInstruction")]
    protected Info _ReportInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_TaskUsage")]
    protected Info _TaskUsage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_PrerequisiteTasks")]
    protected Info _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_MinIterations")]
    protected Info _MinIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_MaxIterations")]
    protected Info _MaxIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_AdvanceToNextTask")]
    protected Info _AdvanceToNextTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Info_Name")]
    protected new Info _Name;

    public Info TaskType
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

    public Info Sequence
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

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info ESigRequirement
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

    public Info Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instruction));
      }
    }

    public Info ReportInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportInstruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportInstruction));
      }
    }

    public Info TaskUsage
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

    public Info PrerequisiteTasks
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

    public Info MinIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinIterations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MinIterations));
      }
    }

    public Info MaxIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxIterations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxIterations));
      }
    }

    public Info AdvanceToNextTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdvanceToNextTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AdvanceToNextTask));
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
