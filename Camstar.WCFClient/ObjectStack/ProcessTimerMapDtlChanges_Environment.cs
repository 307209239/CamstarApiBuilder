// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessTimerMapDtlChanges_Environment
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
  public class ProcessTimerMapDtlChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("ProcessTimerMapDtlChanges", "ProcessTimerMapDtlChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_ObjectToChange")]
    [Metadata("ProcessTimerMapDtl", "ProcessTimerMapDtl", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049033, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_Spec")]
    protected Environment _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_Step")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049032, false, false, false, null)]
    protected Environment _Step;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_Task")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050503, false, false, false, null)]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_Workflow")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048654, false, false, false, null)]
    protected Environment _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_TaskList")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16778413, false, false, false, null)]
    protected Environment _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16778414, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProcessTimerMapDtlChanges_Environment_Txn")]
    protected Environment _Txn;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Spec));
      }
    }

    public Environment Step
    {
      [param: In] set
      {
        this.PropertySet(nameof (Step), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Step));
      }
    }

    public Environment Task
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

    public Environment Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Workflow));
      }
    }

    public Environment TaskList
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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment Txn
    {
      [param: In] set
      {
        this.PropertySet(nameof (Txn), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Txn));
      }
    }
  }
}
