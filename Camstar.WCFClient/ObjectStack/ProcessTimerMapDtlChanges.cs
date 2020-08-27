// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerMapDtlChanges
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
  public class ProcessTimerMapDtlChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Spec")]
    protected Primitive<string> _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Step")]
    protected Primitive<string> _Step;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Task")]
    protected Primitive<string> _Task;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Workflow")]
    protected Primitive<string> _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_TaskList")]
    protected Primitive<string> _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Txn")]
    protected Primitive<string> _Txn;

    public override bool Equals(object obj)
    {
      return obj is ProcessTimerMapDtlChanges && object.Equals((object) this._ListItemToChange, (object) ((ProcessTimerMapDtlChanges) obj)._ListItemToChange) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessTimerMapDtlChanges) obj)._ObjectToChange) && object.Equals((object) this._Spec, (object) ((ProcessTimerMapDtlChanges) obj)._Spec)) && (object.Equals((object) this._Step, (object) ((ProcessTimerMapDtlChanges) obj)._Step) && object.Equals((object) this._Task, (object) ((ProcessTimerMapDtlChanges) obj)._Task) && (object.Equals((object) this._Workflow, (object) ((ProcessTimerMapDtlChanges) obj)._Workflow) && object.Equals((object) this._TaskList, (object) ((ProcessTimerMapDtlChanges) obj)._TaskList))) && (object.Equals((object) this._IsFrozen, (object) ((ProcessTimerMapDtlChanges) obj)._IsFrozen) && object.Equals((object) this._Txn, (object) ((ProcessTimerMapDtlChanges) obj)._Txn)) && base.Equals(obj);
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

    public Primitive<string> Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Spec));
      }
    }

    public Primitive<string> Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Step));
      }
    }

    public Primitive<string> Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Task));
      }
    }

    public Primitive<string> Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Workflow));
      }
    }

    public Primitive<string> TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskList));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Primitive<string> Txn
    {
      [param: In] set
      {
        this.PropertySet(nameof (Txn), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Txn));
      }
    }
  }
}
