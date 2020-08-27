// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompletedTaskDetail
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
  public class CompletedTaskDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_NbrTimesProcessed")]
    protected Primitive<int> _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_TaskIsMarkedCompleted")]
    protected Primitive<bool> _TaskIsMarkedCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Pass")]
    protected Primitive<bool> _Pass;

    public override bool Equals(object obj)
    {
      return obj is CompletedTaskDetail && object.Equals((object) this._Task, (object) ((CompletedTaskDetail) obj)._Task) && (object.Equals((object) this._NbrTimesProcessed, (object) ((CompletedTaskDetail) obj)._NbrTimesProcessed) && object.Equals((object) this._TaskIsMarkedCompleted, (object) ((CompletedTaskDetail) obj)._TaskIsMarkedCompleted)) && object.Equals((object) this._Pass, (object) ((CompletedTaskDetail) obj)._Pass) && base.Equals(obj);
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
  }
}
