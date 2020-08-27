// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessListDetail_Environment
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
  public class ProcessListDetail_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TaskListName")]
    [Metadata("DisplayName", "", false, false, false, "String", 1050502, false, false, false, null)]
    protected Environment _TaskListName;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_ExecutionMode")]
    [Metadata("Enumeration for Execution Mode.\r\n1 = Sequential\r\n2 = Non-Sequential", "ExecutionModeEnum", false, false, false, "Integer", 1050512, false, false, false, null)]
    protected Environment _ExecutionMode;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TaskStatusText")]
    [Metadata("Caption", "", false, false, false, "String", 1052695, false, false, false, null)]
    protected Environment _TaskStatusText;
    [Metadata("Instruction", "", false, false, false, "String", 1052657, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TaskInstruction")]
    protected Environment _TaskInstruction;
    [Metadata("Instruction", "", false, false, false, "String", 1052659, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TaskListInstruction")]
    protected Environment _TaskListInstruction;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_ExecutionModeText")]
    [Metadata("Caption", "", false, false, false, "String", 1050515, false, false, false, null)]
    protected Environment _ExecutionModeText;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_ContainerCompletedTask")]
    [Metadata("Used to build the list of completed Tasks for the Container at its current step.  The list is cleared when the Container leaves the step.", "ContainerCompletedTask", false, false, false, "SubentityRef", 1052650, false, false, false, null)]
    protected Environment _ContainerCompletedTask;
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, false, false, "RevisionedObjectRef", 1051890, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_ProcessList")]
    protected Environment _ProcessList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_ProcessItem")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, false, "NamedSubentityRef", 1051870, false, false, false, null)]
    protected Environment _ProcessItem;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_ProcessedCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052654, false, false, false, null)]
    protected Environment _ProcessedCount;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052652, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_MaxIterations")]
    protected Environment _MaxIterations;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052651, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_LastExecutedOnGMT")]
    protected Environment _LastExecutedOnGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_MinIterations")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052653, false, false, false, null)]
    protected Environment _MinIterations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TasksCompleted")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052662, false, false, false, null)]
    protected Environment _TasksCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TaskCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052656, false, false, false, null)]
    protected Environment _TaskCount;
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_RequiredTaskCount")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052655, false, false, false, null)]
    protected Environment _RequiredTaskCount;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1052651, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_LastExecutedOn")]
    protected Environment _LastExecutedOn;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052698, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_RequiredTasksCompleted")]
    protected Environment _RequiredTasksCompleted;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052661, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessListDetail_Environment_TaskName")]
    protected Environment _TaskName;

    public Environment TaskListName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskListName));
      }
    }

    public Environment ExecutionMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionMode));
      }
    }

    public Environment TaskStatusText
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskStatusText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskStatusText));
      }
    }

    public Environment TaskInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskInstruction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskInstruction));
      }
    }

    public Environment TaskListInstruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListInstruction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskListInstruction));
      }
    }

    public Environment ExecutionModeText
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionModeText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionModeText));
      }
    }

    public Environment ContainerCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerCompletedTask), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerCompletedTask));
      }
    }

    public Environment ProcessList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessList));
      }
    }

    public Environment ProcessItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessItem));
      }
    }

    public Environment ProcessedCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessedCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessedCount));
      }
    }

    public Environment MaxIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxIterations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaxIterations));
      }
    }

    public Environment LastExecutedOnGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastExecutedOnGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastExecutedOnGMT));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public Environment MinIterations
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinIterations), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinIterations));
      }
    }

    public Environment TasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TasksCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TasksCompleted));
      }
    }

    public Environment TaskCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskCount));
      }
    }

    public Environment RequiredTaskCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredTaskCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequiredTaskCount));
      }
    }

    public Environment LastExecutedOn
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastExecutedOn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastExecutedOn));
      }
    }

    public Environment RequiredTasksCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequiredTasksCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequiredTasksCompleted));
      }
    }

    public Environment TaskName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskName));
      }
    }
  }
}
