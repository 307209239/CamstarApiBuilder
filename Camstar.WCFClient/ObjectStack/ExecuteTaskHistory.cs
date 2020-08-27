// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteTaskHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ExecuteRecipeTaskHistory))]
  [Serializable]
  public class ExecuteTaskHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_TaskType")]
    protected Enumeration<TaskTypeEnum, int> _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_HistoryDetails")]
    protected new ServiceHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_TaskComments")]
    protected Primitive<string> _TaskComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_TaskListSequence")]
    protected Primitive<int> _TaskListSequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Instruction")]
    protected Primitive<string> _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_TaskList")]
    protected RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_ElectronicProcedure")]
    protected RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_PrerequisiteTasks")]
    protected NamedSubentityRef[] _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Pass")]
    protected Primitive<bool> _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_WorkCell")]
    protected NamedObjectRef _WorkCell;

    public override bool Equals(object obj)
    {
      return obj is ExecuteTaskHistory && object.Equals((object) this._ExportImportKey, (object) ((ExecuteTaskHistory) obj)._ExportImportKey) && (object.Equals((object) this._TaskType, (object) ((ExecuteTaskHistory) obj)._TaskType) && object.Equals((object) this._TrainingReqGroup, (object) ((ExecuteTaskHistory) obj)._TrainingReqGroup)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ExecuteTaskHistory) obj)._HistoryDetails) && object.Equals((object) this._TaskComments, (object) ((ExecuteTaskHistory) obj)._TaskComments) && (object.Equals((object) this._Sequence, (object) ((ExecuteTaskHistory) obj)._Sequence) && object.Equals((object) this._TaskListSequence, (object) ((ExecuteTaskHistory) obj)._TaskListSequence))) && (object.Equals((object) this._Instruction, (object) ((ExecuteTaskHistory) obj)._Instruction) && object.Equals((object) this._TaskList, (object) ((ExecuteTaskHistory) obj)._TaskList) && (object.Equals((object) this._ElectronicProcedure, (object) ((ExecuteTaskHistory) obj)._ElectronicProcedure) && object.Equals((object) this._Task, (object) ((ExecuteTaskHistory) obj)._Task)) && (this.CompareArrays((Array) this._PrerequisiteTasks, (Array) ((ExecuteTaskHistory) obj)._PrerequisiteTasks) && object.Equals((object) this._HistoryId, (object) ((ExecuteTaskHistory) obj)._HistoryId) && (object.Equals((object) this._Pass, (object) ((ExecuteTaskHistory) obj)._Pass) && object.Equals((object) this._Workstation, (object) ((ExecuteTaskHistory) obj)._Workstation)))) && (object.Equals((object) this._DocumentSet, (object) ((ExecuteTaskHistory) obj)._DocumentSet) && object.Equals((object) this._WorkCell, (object) ((ExecuteTaskHistory) obj)._WorkCell)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
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

    public new ServiceHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Primitive<string> TaskComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskComments));
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

    public Primitive<int> TaskListSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListSequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TaskListSequence));
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

    public RevisionedObjectRef TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TaskList));
      }
    }

    public RevisionedObjectRef ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public NamedSubentityRef Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Task));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<bool> Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Pass));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public NamedObjectRef WorkCell
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCell), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCell));
      }
    }
  }
}
