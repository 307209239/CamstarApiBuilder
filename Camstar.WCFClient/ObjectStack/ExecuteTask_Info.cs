// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteTask_Info
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
  public class ExecuteTask_Info : ExecuteProductionProcess_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_ElectronicProcedure")]
    protected new Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_TaskList")]
    protected new Info _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_PrerequisiteTasks")]
    protected new Info _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_Task")]
    protected new Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_ProcessSequenceValidation")]
    protected TaskSequenceValidation_Info _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTask_Info_IsConfirmation")]
    protected new Info _IsConfirmation;

    public new Info ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public new Info TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskList));
      }
    }

    public new Info PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new Info Task
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

    public TaskSequenceValidation_Info ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (TaskSequenceValidation_Info) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsConfirmation));
      }
    }
  }
}
