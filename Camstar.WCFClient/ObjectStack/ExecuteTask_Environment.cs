// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteTask_Environment
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
  public class ExecuteTask_Environment : ExecuteProductionProcess_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_ElectronicProcedure")]
    [Metadata("Provides the framework for executing a series of Tasks at the Spec.  An Electronic Procedure defines a set of instructions (a checklisst for performing a set of tasks), and is compose of one ore more TaskLists.", "ElectronicProcedure", false, false, true, "RevisionedObjectRef", 1050523, false, false, false, null)]
    protected new Environment _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_TaskList")]
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskList", false, true, false, "RevisionedObjectRef", 1050520, false, false, true, null)]
    protected new Environment _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_PrerequisiteTasks")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, false, true, "NamedSubentityRef", 1050549, false, true, false, null)]
    protected new Environment _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_Task")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItem", false, true, false, "NamedSubentityRef", 1050503, false, false, true, null)]
    protected new Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_ProcessSequenceValidation")]
    [Metadata("Extends TaskList/Task validation logic to verify they have been completed in the correct sequence.", "TaskSequenceValidation", false, false, true, "TaskSequenceValidation", 1052217, true, false, false, null)]
    protected TaskSequenceValidation_Environment _ProcessSequenceValidation;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, true, false, "ContainerRef", 1049043, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_Container")]
    protected new Environment _Container;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778944, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Environment_IsConfirmation")]
    protected new Environment _IsConfirmation;

    public new Environment ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ElectronicProcedure));
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

    public new Environment PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new Environment Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Task));
      }
    }

    public TaskSequenceValidation_Environment ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (TaskSequenceValidation_Environment) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public new Environment Container
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

    public new Environment IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsConfirmation));
      }
    }
  }
}
