// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TaskItemChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RecipeItemChanges))]
  [Serializable]
  public class ProcessItemChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_TaskType")]
    protected Enumeration<TaskTypeEnum, int> _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Instruction")]
    protected Primitive<string> _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_ReportInstruction")]
    protected Primitive<string> _ReportInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_TaskUsage")]
    protected Enumeration<TaskUsageEnum, int> _TaskUsage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_PrerequisiteTasks")]
    protected NamedSubentityRef[] _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_MinIterations")]
    protected Primitive<int> _MinIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_MaxIterations")]
    protected Primitive<int> _MaxIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_AdvanceToNextTask")]
    protected Primitive<bool> _AdvanceToNextTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessItemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ProcessItemChanges && object.Equals((object) this._TaskType, (object) ((ProcessItemChanges) obj)._TaskType) && (object.Equals((object) this._Sequence, (object) ((ProcessItemChanges) obj)._Sequence) && object.Equals((object) this._ListItemToChange, (object) ((ProcessItemChanges) obj)._ListItemToChange)) && (object.Equals((object) this._TrainingReqGroup, (object) ((ProcessItemChanges) obj)._TrainingReqGroup) && object.Equals((object) this._ESigRequirement, (object) ((ProcessItemChanges) obj)._ESigRequirement) && (object.Equals((object) this._Instruction, (object) ((ProcessItemChanges) obj)._Instruction) && object.Equals((object) this._ReportInstruction, (object) ((ProcessItemChanges) obj)._ReportInstruction))) && (object.Equals((object) this._TaskUsage, (object) ((ProcessItemChanges) obj)._TaskUsage) && this.CompareArrays((Array) this._PrerequisiteTasks, (Array) ((ProcessItemChanges) obj)._PrerequisiteTasks) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessItemChanges) obj)._ObjectToChange) && object.Equals((object) this._MinIterations, (object) ((ProcessItemChanges) obj)._MinIterations)) && (object.Equals((object) this._MaxIterations, (object) ((ProcessItemChanges) obj)._MaxIterations) && object.Equals((object) this._AdvanceToNextTask, (object) ((ProcessItemChanges) obj)._AdvanceToNextTask) && object.Equals((object) this._Name, (object) ((ProcessItemChanges) obj)._Name))) && base.Equals(obj);
    }

    public Enumeration<TaskTypeEnum, int> TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Enumeration<TaskTypeEnum, int>) this.PropertyGet(nameof (TaskType));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Primitive<string> Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instruction));
      }
    }

    public Primitive<string> ReportInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportInstruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportInstruction));
      }
    }

    public Enumeration<TaskUsageEnum, int> TaskUsage
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskUsage), (object) value);
      }
      get
      {
        return (Enumeration<TaskUsageEnum, int>) this.PropertyGet(nameof (TaskUsage));
      }
    }

    public NamedSubentityRef[] PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<int> MinIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinIterations), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MinIterations));
      }
    }

    public Primitive<int> MaxIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxIterations), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MaxIterations));
      }
    }

    public Primitive<bool> AdvanceToNextTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (AdvanceToNextTask), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AdvanceToNextTask));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
