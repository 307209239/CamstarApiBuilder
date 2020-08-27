// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessListDetail_Info
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
  public class ProcessListDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TaskListName")]
    protected Info _TaskListName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_ExecutionMode")]
    protected Info _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TaskStatusText")]
    protected Info _TaskStatusText;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TaskInstruction")]
    protected Info _TaskInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TaskListInstruction")]
    protected Info _TaskListInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_ExecutionModeText")]
    protected Info _ExecutionModeText;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_ContainerCompletedTask")]
    protected Info _ContainerCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_ProcessList")]
    protected Info _ProcessList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_ProcessItem")]
    protected Info _ProcessItem;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_ProcessedCount")]
    protected Info _ProcessedCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_MaxIterations")]
    protected Info _MaxIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_LastExecutedOnGMT")]
    protected Info _LastExecutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_MinIterations")]
    protected Info _MinIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TasksCompleted")]
    protected Info _TasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TaskCount")]
    protected Info _TaskCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_RequiredTaskCount")]
    protected Info _RequiredTaskCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_LastExecutedOn")]
    protected Info _LastExecutedOn;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_RequiredTasksCompleted")]
    protected Info _RequiredTasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Info_TaskName")]
    protected Info _TaskName;

    public Info TaskListName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskListName));
      }
    }

    public Info ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Info TaskStatusText
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskStatusText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskStatusText));
      }
    }

    public Info TaskInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskInstruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskInstruction));
      }
    }

    public Info TaskListInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListInstruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskListInstruction));
      }
    }

    public Info ExecutionModeText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionModeText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionModeText));
      }
    }

    public Info ContainerCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerCompletedTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerCompletedTask));
      }
    }

    public Info ProcessList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessList));
      }
    }

    public Info ProcessItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessItem));
      }
    }

    public Info ProcessedCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessedCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessedCount));
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

    public Info LastExecutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastExecutedOnGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastExecutedOnGMT));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
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

    public Info TasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TasksCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TasksCompleted));
      }
    }

    public Info TaskCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskCount));
      }
    }

    public Info RequiredTaskCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredTaskCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequiredTaskCount));
      }
    }

    public Info LastExecutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastExecutedOn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastExecutedOn));
      }
    }

    public Info RequiredTasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredTasksCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequiredTasksCompleted));
      }
    }

    public Info TaskName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskName));
      }
    }
  }
}
