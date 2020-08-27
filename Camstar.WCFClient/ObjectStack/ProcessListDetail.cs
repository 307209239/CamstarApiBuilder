// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessListDetail
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
  public class ProcessListDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TaskListName")]
    protected Primitive<string> _TaskListName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_ExecutionMode")]
    protected Enumeration<ExecutionModeEnum, int> _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TaskStatusText")]
    protected Primitive<string> _TaskStatusText;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TaskInstruction")]
    protected Primitive<string> _TaskInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TaskListInstruction")]
    protected Primitive<string> _TaskListInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_ExecutionModeText")]
    protected Primitive<string> _ExecutionModeText;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_ContainerCompletedTask")]
    protected SubentityRef _ContainerCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_ProcessList")]
    protected RevisionedObjectRef _ProcessList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_ProcessItem")]
    protected NamedSubentityRef _ProcessItem;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_ProcessedCount")]
    protected Primitive<int> _ProcessedCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_MaxIterations")]
    protected Primitive<int> _MaxIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_LastExecutedOnGMT")]
    protected Primitive<DateTime> _LastExecutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_MinIterations")]
    protected Primitive<int> _MinIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TasksCompleted")]
    protected Primitive<int> _TasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TaskCount")]
    protected Primitive<int> _TaskCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_RequiredTaskCount")]
    protected Primitive<int> _RequiredTaskCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_LastExecutedOn")]
    protected Primitive<DateTime> _LastExecutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_RequiredTasksCompleted")]
    protected Primitive<int> _RequiredTasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_TaskName")]
    protected Primitive<string> _TaskName;

    public override bool Equals(object obj)
    {
      return obj is ProcessListDetail && object.Equals((object) this._TaskListName, (object) ((ProcessListDetail) obj)._TaskListName) && (object.Equals((object) this._ExecutionMode, (object) ((ProcessListDetail) obj)._ExecutionMode) && object.Equals((object) this._TaskStatusText, (object) ((ProcessListDetail) obj)._TaskStatusText)) && (object.Equals((object) this._TaskInstruction, (object) ((ProcessListDetail) obj)._TaskInstruction) && object.Equals((object) this._TaskListInstruction, (object) ((ProcessListDetail) obj)._TaskListInstruction) && (object.Equals((object) this._ExecutionModeText, (object) ((ProcessListDetail) obj)._ExecutionModeText) && object.Equals((object) this._ContainerCompletedTask, (object) ((ProcessListDetail) obj)._ContainerCompletedTask))) && (object.Equals((object) this._ProcessList, (object) ((ProcessListDetail) obj)._ProcessList) && object.Equals((object) this._ProcessItem, (object) ((ProcessListDetail) obj)._ProcessItem) && (object.Equals((object) this._ProcessedCount, (object) ((ProcessListDetail) obj)._ProcessedCount) && object.Equals((object) this._MaxIterations, (object) ((ProcessListDetail) obj)._MaxIterations)) && (object.Equals((object) this._LastExecutedOnGMT, (object) ((ProcessListDetail) obj)._LastExecutedOnGMT) && object.Equals((object) this._Container, (object) ((ProcessListDetail) obj)._Container) && (object.Equals((object) this._MinIterations, (object) ((ProcessListDetail) obj)._MinIterations) && object.Equals((object) this._TasksCompleted, (object) ((ProcessListDetail) obj)._TasksCompleted)))) && (object.Equals((object) this._TaskCount, (object) ((ProcessListDetail) obj)._TaskCount) && object.Equals((object) this._RequiredTaskCount, (object) ((ProcessListDetail) obj)._RequiredTaskCount) && (object.Equals((object) this._LastExecutedOn, (object) ((ProcessListDetail) obj)._LastExecutedOn) && object.Equals((object) this._RequiredTasksCompleted, (object) ((ProcessListDetail) obj)._RequiredTasksCompleted)) && object.Equals((object) this._TaskName, (object) ((ProcessListDetail) obj)._TaskName)) && base.Equals(obj);
    }

    public Primitive<string> TaskListName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskListName));
      }
    }

    public Enumeration<ExecutionModeEnum, int> ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Enumeration<ExecutionModeEnum, int>) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Primitive<string> TaskStatusText
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskStatusText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskStatusText));
      }
    }

    public Primitive<string> TaskInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskInstruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskInstruction));
      }
    }

    public Primitive<string> TaskListInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListInstruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskListInstruction));
      }
    }

    public Primitive<string> ExecutionModeText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionModeText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExecutionModeText));
      }
    }

    public SubentityRef ContainerCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerCompletedTask), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ContainerCompletedTask));
      }
    }

    public RevisionedObjectRef ProcessList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessList));
      }
    }

    public NamedSubentityRef ProcessItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessItem), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ProcessItem));
      }
    }

    public Primitive<int> ProcessedCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessedCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ProcessedCount));
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

    public Primitive<DateTime> LastExecutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastExecutedOnGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastExecutedOnGMT));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public Primitive<int> TasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TasksCompleted), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TasksCompleted));
      }
    }

    public Primitive<int> TaskCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TaskCount));
      }
    }

    public Primitive<int> RequiredTaskCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredTaskCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RequiredTaskCount));
      }
    }

    public Primitive<DateTime> LastExecutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastExecutedOn), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastExecutedOn));
      }
    }

    public Primitive<int> RequiredTasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredTasksCompleted), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RequiredTasksCompleted));
      }
    }

    public Primitive<string> TaskName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskName));
      }
    }
  }
}
