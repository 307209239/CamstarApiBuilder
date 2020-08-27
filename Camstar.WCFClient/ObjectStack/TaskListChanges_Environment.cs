// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskListChanges_Environment
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
  public class TaskListChanges_Environment : ProcessListChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Environment_Tasks")]
    [Metadata("The TaskListDetail identifies a specific Task to be completed for a TaskList.", "TaskItemChanges", false, true, false, "TaskItemChanges", 1050574, false, true, false, null)]
    protected TaskItemChanges_Environment _Tasks;
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskList", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskList", false, false, false, "RevisionedObjectRef", 1050516, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Environment_PrerequisiteTaskList")]
    protected new Environment _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Environment_Base")]
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskListBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Environment_IsRevOfRcd")]
    protected new Environment _IsRevOfRcd;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050502, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Environment_Name")]
    protected new Environment _Name;

    public TaskItemChanges_Environment Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (TaskItemChanges_Environment) this.PropertyGet(nameof (Tasks));
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

    public new Environment PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
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
