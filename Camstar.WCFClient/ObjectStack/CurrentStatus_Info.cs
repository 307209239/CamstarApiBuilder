// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentStatus_Info
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
  public class CurrentStatus_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_ContainerCompletedTasks")]
    protected ContainerCompletedTask_Info _ContainerCompletedTasks;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_ReworkStatus")]
    protected ReworkStatus_Info _ReworkStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_WorkflowStack")]
    protected SubWorkflowStep_Info _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_StepPassCounts")]
    protected StepPassCount_Info _StepPassCounts;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Timers")]
    protected Timer_Info _Timers;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_InitialRecipeList")]
    protected Info _InitialRecipeList;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_LastCompletedTask")]
    protected Info _LastCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_CurrentStepPass")]
    protected Info _CurrentStepPass;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_ReworkTotalCount")]
    protected Info _ReworkTotalCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_LastMoveDateGMT")]
    protected Info _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_InProcess")]
    protected Info _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_TimersCount")]
    protected Info _TimersCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_InRework")]
    protected Info _InRework;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_LastMoveDate")]
    protected Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_ClearanceWorkstations")]
    protected Info _ClearanceWorkstations;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Operation")]
    protected Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Info_Resource")]
    protected Info _Resource;

    public ContainerCompletedTask_Info ContainerCompletedTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerCompletedTasks), (object) value);
      }
      get
      {
        return (ContainerCompletedTask_Info) this.PropertyGet(nameof (ContainerCompletedTasks));
      }
    }

    public ReworkStatus_Info ReworkStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkStatus), (object) value);
      }
      get
      {
        return (ReworkStatus_Info) this.PropertyGet(nameof (ReworkStatus));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public SubWorkflowStep_Info WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (SubWorkflowStep_Info) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public StepPassCount_Info StepPassCounts
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPassCounts), (object) value);
      }
      get
      {
        return (StepPassCount_Info) this.PropertyGet(nameof (StepPassCounts));
      }
    }

    public Timer_Info Timers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timers), (object) value);
      }
      get
      {
        return (Timer_Info) this.PropertyGet(nameof (Timers));
      }
    }

    public Info InitialRecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitialRecipeList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitialRecipeList));
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

    public Info CurrentStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStepPass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentStepPass));
      }
    }

    public Info ReworkTotalCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkTotalCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReworkTotalCount));
      }
    }

    public Info LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Info InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InProcess));
      }
    }

    public Info TimersCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimersCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TimersCount));
      }
    }

    public Info InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InRework));
      }
    }

    public Info LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Info ClearanceWorkstations
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearanceWorkstations), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClearanceWorkstations));
      }
    }

    public Info Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workstation));
      }
    }

    public Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
