// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteTask
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
  public class ExecuteTask : ExecuteProductionProcess
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_ElectronicProcedure")]
    protected new RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_TaskList")]
    protected new RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_PrerequisiteTasks")]
    protected new NamedSubentityRef[] _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Task")]
    protected new NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_ProcessSequenceValidation")]
    protected TaskSequenceValidation _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_IsConfirmation")]
    protected new Primitive<bool> _IsConfirmation;

    public override bool Equals(object obj)
    {
      return obj is ExecuteTask && object.Equals((object) this._ElectronicProcedure, (object) ((ExecuteTask) obj)._ElectronicProcedure) && (object.Equals((object) this._TaskList, (object) ((ExecuteTask) obj)._TaskList) && this.CompareArrays((Array) this._PrerequisiteTasks, (Array) ((ExecuteTask) obj)._PrerequisiteTasks)) && (object.Equals((object) this._Task, (object) ((ExecuteTask) obj)._Task) && object.Equals((object) this._ProcessSequenceValidation, (object) ((ExecuteTask) obj)._ProcessSequenceValidation) && (object.Equals((object) this._Container, (object) ((ExecuteTask) obj)._Container) && object.Equals((object) this._IsConfirmation, (object) ((ExecuteTask) obj)._IsConfirmation))) && base.Equals(obj);
    }

    public new RevisionedObjectRef ElectronicProcedure
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

    public new RevisionedObjectRef TaskList
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

    public new NamedSubentityRef[] PrerequisiteTasks
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

    public new NamedSubentityRef Task
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

    public TaskSequenceValidation ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (TaskSequenceValidation) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public new ContainerRef Container
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

    public new Primitive<bool> IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsConfirmation));
      }
    }
  }
}
