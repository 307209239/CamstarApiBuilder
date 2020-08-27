// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskListChanges
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
  public class TaskListChanges : ProcessListChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Tasks")]
    protected TaskItemChanges[] _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_PrerequisiteTaskList")]
    protected new RevisionedObjectRef _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "TaskListChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TaskListChanges && this.CompareArrays((Array) this._Tasks, (Array) ((TaskListChanges) obj)._Tasks) && (object.Equals((object) this._ObjectToChange, (object) ((TaskListChanges) obj)._ObjectToChange) && object.Equals((object) this._PrerequisiteTaskList, (object) ((TaskListChanges) obj)._PrerequisiteTaskList)) && (object.Equals((object) this._Base, (object) ((TaskListChanges) obj)._Base) && object.Equals((object) this._IsRevOfRcd, (object) ((TaskListChanges) obj)._IsRevOfRcd) && object.Equals((object) this._Name, (object) ((TaskListChanges) obj)._Name)) && base.Equals(obj);
    }

    public TaskItemChanges[] Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (TaskItemChanges[]) this.PropertyGet(nameof (Tasks));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new RevisionedObjectRef PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
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
