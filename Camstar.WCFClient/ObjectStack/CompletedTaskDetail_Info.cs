// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompletedTaskDetail_Info
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
  public class CompletedTaskDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Info_NbrTimesProcessed")]
    protected Info _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Info_TaskIsMarkedCompleted")]
    protected Info _TaskIsMarkedCompleted;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Info_Pass")]
    protected Info _Pass;

    public Info Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Task));
      }
    }

    public Info NbrTimesProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (NbrTimesProcessed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NbrTimesProcessed));
      }
    }

    public Info TaskIsMarkedCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskIsMarkedCompleted), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskIsMarkedCompleted));
      }
    }

    public Info Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Pass));
      }
    }
  }
}
