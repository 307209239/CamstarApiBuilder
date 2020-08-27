// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessSequenceValidation_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (TaskSequenceValidation_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (RecipeSequenceValidation_Info))]
  [Serializable]
  public class ProcessSequenceValidation_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_CompletedTaskDetails")]
    protected CompletedTaskDetail_Info _CompletedTaskDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_LastCompletedTask")]
    protected Info _LastCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_LastCompletedTaskInTaskList")]
    protected Info _LastCompletedTaskInTaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_ProcessItem")]
    protected Info _ProcessItem;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_ProductionProcess")]
    protected Info _ProductionProcess;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_ProcessList")]
    protected Info _ProcessList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessSequenceValidation_Info_Container")]
    protected Info _Container;

    public CompletedTaskDetail_Info CompletedTaskDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedTaskDetails), (object) value);
      }
      get
      {
        return (CompletedTaskDetail_Info) this.PropertyGet(nameof (CompletedTaskDetails));
      }
    }

    public Info LastCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedTask));
      }
    }

    public Info LastCompletedTaskInTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTaskInTaskList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastCompletedTaskInTaskList));
      }
    }

    public Info ProcessItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessItem));
      }
    }

    public Info ProductionProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductionProcess));
      }
    }

    public Info ProcessList
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessList));
      }
    }

    public Info Container
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
  }
}
