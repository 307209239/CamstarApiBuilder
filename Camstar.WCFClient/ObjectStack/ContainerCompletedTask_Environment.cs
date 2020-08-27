// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerCompletedTask_Environment
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
  public class ContainerCompletedTask_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_CompletedSubTasks")]
    [Metadata("Details of sub tasks that are completed.", "ContainerCompletedSubTask", false, false, true, "ContainerCompletedSubTask", 1051874, false, true, false, null)]
    protected ContainerCompletedSubTask_Environment _CompletedSubTasks;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_Task")]
    [Metadata("ProcessItem encapsulates different types of Tasks that could be completed in a TaskList.", "ProcessItem", false, false, true, "NamedSubentityRef", 1050503, false, false, false, null)]
    protected Environment _Task;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_Pass")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050546, false, false, false, "0")]
    protected Environment _Pass;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1052241, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_CompletionTimestampGMT")]
    protected Environment _CompletionTimestampGMT;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_TaskIsMarkedCompleted")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051868, false, false, false, "0")]
    protected Environment _TaskIsMarkedCompleted;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_NbrTimesProcessed")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050552, false, false, false, null)]
    protected Environment _NbrTimesProcessed;
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_CompletionTimestamp")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050553, false, false, false, null)]
    protected Environment _CompletionTimestamp;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerCompletedTask_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public ContainerCompletedSubTask_Environment CompletedSubTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedSubTasks), (object) value);
      }
      get
      {
        return (ContainerCompletedSubTask_Environment) this.PropertyGet(nameof (CompletedSubTasks));
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

    public Environment CompletionTimestampGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestampGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionTimestampGMT));
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

    public Environment CompletionTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionTimestamp), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionTimestamp));
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
  }
}
