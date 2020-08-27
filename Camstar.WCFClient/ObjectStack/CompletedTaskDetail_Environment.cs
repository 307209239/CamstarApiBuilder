// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompletedTaskDetail_Environment
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
  public class CompletedTaskDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Environment_Task")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1051870, false, false, false, null)]
    protected Environment _Task;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1051871, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Environment_NbrTimesProcessed")]
    protected Environment _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Environment_TaskIsMarkedCompleted")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051886, false, false, false, "0")]
    protected Environment _TaskIsMarkedCompleted;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050546, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CompletedTaskDetail_Environment_Pass")]
    protected Environment _Pass;

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

    public Environment NbrTimesProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (NbrTimesProcessed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NbrTimesProcessed));
      }
    }

    public Environment TaskIsMarkedCompleted
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskIsMarkedCompleted), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskIsMarkedCompleted));
      }
    }

    public Environment Pass
    {
      [param: In] set
      {
        this.PropertySet(nameof (Pass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Pass));
      }
    }
  }
}
