// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskListChanges_Info
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
  public class TaskListChanges_Info : ProcessListChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Info_Tasks")]
    protected TaskItemChanges_Info _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Info_PrerequisiteTaskList")]
    protected new Info _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Info_IsRevOfRcd")]
    protected new Info _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Info_Name")]
    protected new Info _Name;

    public TaskItemChanges_Info Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (TaskItemChanges_Info) this.PropertyGet(nameof (Tasks));
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

    public new Info PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public new Info IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRevOfRcd));
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
