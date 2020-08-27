// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerCompletedTask
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
  public class ContainerCompletedTask : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_CompletedSubTasks")]
    protected ContainerCompletedSubTask[] _CompletedSubTasks;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Pass")]
    protected Primitive<bool> _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_CompletionTimestampGMT")]
    protected Primitive<DateTime> _CompletionTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_TaskIsMarkedCompleted")]
    protected Primitive<bool> _TaskIsMarkedCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_NbrTimesProcessed")]
    protected Primitive<int> _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_CompletionTimestamp")]
    protected Primitive<DateTime> _CompletionTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ContainerCompletedTask && object.Equals((object) this._ExportImportKey, (object) ((ContainerCompletedTask) obj)._ExportImportKey) && (this.CompareArrays((Array) this._CompletedSubTasks, (Array) ((ContainerCompletedTask) obj)._CompletedSubTasks) && object.Equals((object) this._Task, (object) ((ContainerCompletedTask) obj)._Task)) && (object.Equals((object) this._Pass, (object) ((ContainerCompletedTask) obj)._Pass) && object.Equals((object) this._CompletionTimestampGMT, (object) ((ContainerCompletedTask) obj)._CompletionTimestampGMT) && (object.Equals((object) this._TaskIsMarkedCompleted, (object) ((ContainerCompletedTask) obj)._TaskIsMarkedCompleted) && object.Equals((object) this._NbrTimesProcessed, (object) ((ContainerCompletedTask) obj)._NbrTimesProcessed))) && (object.Equals((object) this._CompletionTimestamp, (object) ((ContainerCompletedTask) obj)._CompletionTimestamp) && object.Equals((object) this._IsFrozen, (object) ((ContainerCompletedTask) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ContainerCompletedSubTask[] CompletedSubTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSubTasks), (object) value);
      }
      get
      {
        return (ContainerCompletedSubTask[]) this.PropertyGet(nameof (CompletedSubTasks));
      }
    }

    public NamedSubentityRef Task
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

    public Primitive<bool> Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Pass));
      }
    }

    public Primitive<DateTime> CompletionTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestampGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionTimestampGMT));
      }
    }

    public Primitive<bool> TaskIsMarkedCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskIsMarkedCompleted), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TaskIsMarkedCompleted));
      }
    }

    public Primitive<int> NbrTimesProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (NbrTimesProcessed), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (NbrTimesProcessed));
      }
    }

    public Primitive<DateTime> CompletionTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CompletionTimestamp));
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
  }
}
