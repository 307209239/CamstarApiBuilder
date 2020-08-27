// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TaskListMaint_Environment
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
  public class TaskListMaint_Environment : ProcessListMaint_Environment
  {
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskListChanges", false, false, false, "TaskListChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TaskListMaint_Environment_ObjectChanges")]
    protected TaskListChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "TaskListMaint_Environment_BaseToChange")]
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskListBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskListMaint_Environment_ObjectToChange")]
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskList", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TaskListMaint_Environment_ObjectListInquiry")]
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskListBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;

    public TaskListChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (TaskListChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
