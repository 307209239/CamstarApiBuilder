// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CurrentStatus
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
  public class CurrentStatus : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_ContainerCompletedTasks")]
    protected ContainerCompletedTask[] _ContainerCompletedTasks;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_ReworkStatus")]
    protected Camstar.WCF.ObjectStack.ReworkStatus[] _ReworkStatus;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_WorkflowStep")]
    protected NamedSubentityRef _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_WorkflowStack")]
    protected SubWorkflowStep[] _WorkflowStack;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_StepPassCounts")]
    protected StepPassCount[] _StepPassCounts;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Timers")]
    protected Timer[] _Timers;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_InitialRecipeList")]
    protected RevisionedObjectRef _InitialRecipeList;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_LastCompletedTask")]
    protected NamedSubentityRef _LastCompletedTask;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_CurrentStepPass")]
    protected Primitive<int> _CurrentStepPass;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_ReworkTotalCount")]
    protected Primitive<int> _ReworkTotalCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_LastMoveDateGMT")]
    protected Primitive<DateTime> _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_InProcess")]
    protected Primitive<bool> _InProcess;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_TimersCount")]
    protected Primitive<int> _TimersCount;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_InRework")]
    protected Primitive<bool> _InRework;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_LastMoveDate")]
    protected Primitive<DateTime> _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_ClearanceWorkstations")]
    protected NamedObjectRef[] _ClearanceWorkstations;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Location")]
    protected NamedSubentityRef _Location;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Operation")]
    protected NamedObjectRef _Operation;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "CurrentStatus_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is CurrentStatus && this.CompareArrays((Array) this._ContainerCompletedTasks, (Array) ((CurrentStatus) obj)._ContainerCompletedTasks) && (this.CompareArrays((Array) this._ReworkStatus, (Array) ((CurrentStatus) obj)._ReworkStatus) && object.Equals((object) this._Spec, (object) ((CurrentStatus) obj)._Spec)) && (object.Equals((object) this._WorkflowStep, (object) ((CurrentStatus) obj)._WorkflowStep) && this.CompareArrays((Array) this._WorkflowStack, (Array) ((CurrentStatus) obj)._WorkflowStack) && (this.CompareArrays((Array) this._StepPassCounts, (Array) ((CurrentStatus) obj)._StepPassCounts) && this.CompareArrays((Array) this._Timers, (Array) ((CurrentStatus) obj)._Timers))) && (object.Equals((object) this._InitialRecipeList, (object) ((CurrentStatus) obj)._InitialRecipeList) && object.Equals((object) this._LastCompletedTask, (object) ((CurrentStatus) obj)._LastCompletedTask) && (object.Equals((object) this._CurrentStepPass, (object) ((CurrentStatus) obj)._CurrentStepPass) && object.Equals((object) this._ReworkTotalCount, (object) ((CurrentStatus) obj)._ReworkTotalCount)) && (object.Equals((object) this._LastMoveDateGMT, (object) ((CurrentStatus) obj)._LastMoveDateGMT) && object.Equals((object) this._InProcess, (object) ((CurrentStatus) obj)._InProcess) && (object.Equals((object) this._TimersCount, (object) ((CurrentStatus) obj)._TimersCount) && object.Equals((object) this._InRework, (object) ((CurrentStatus) obj)._InRework)))) && (object.Equals((object) this._LastMoveDate, (object) ((CurrentStatus) obj)._LastMoveDate) && this.CompareArrays((Array) this._ClearanceWorkstations, (Array) ((CurrentStatus) obj)._ClearanceWorkstations) && (object.Equals((object) this._Workstation, (object) ((CurrentStatus) obj)._Workstation) && object.Equals((object) this._Factory, (object) ((CurrentStatus) obj)._Factory)) && (object.Equals((object) this._Location, (object) ((CurrentStatus) obj)._Location) && object.Equals((object) this._Operation, (object) ((CurrentStatus) obj)._Operation) && (object.Equals((object) this._Workflow, (object) ((CurrentStatus) obj)._Workflow) && object.Equals((object) this._Resource, (object) ((CurrentStatus) obj)._Resource)))) && base.Equals(obj);
    }

    public ContainerCompletedTask[] ContainerCompletedTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerCompletedTasks), (object) value);
      }
      get
      {
        return (ContainerCompletedTask[]) this.PropertyGet(nameof (ContainerCompletedTasks));
      }
    }

    public Camstar.WCF.ObjectStack.ReworkStatus[] ReworkStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkStatus), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ReworkStatus[]) this.PropertyGet(nameof (ReworkStatus));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public NamedSubentityRef WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public SubWorkflowStep[] WorkflowStack
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStack), (object) value);
      }
      get
      {
        return (SubWorkflowStep[]) this.PropertyGet(nameof (WorkflowStack));
      }
    }

    public StepPassCount[] StepPassCounts
    {
      [param: In] set
      {
        this.PropertySet(nameof (StepPassCounts), (object) value);
      }
      get
      {
        return (StepPassCount[]) this.PropertyGet(nameof (StepPassCounts));
      }
    }

    public Timer[] Timers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Timers), (object) value);
      }
      get
      {
        return (Timer[]) this.PropertyGet(nameof (Timers));
      }
    }

    public RevisionedObjectRef InitialRecipeList
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitialRecipeList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (InitialRecipeList));
      }
    }

    public NamedSubentityRef LastCompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastCompletedTask), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (LastCompletedTask));
      }
    }

    public Primitive<int> CurrentStepPass
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStepPass), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentStepPass));
      }
    }

    public Primitive<int> ReworkTotalCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkTotalCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ReworkTotalCount));
      }
    }

    public Primitive<DateTime> LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Primitive<bool> InProcess
    {
      [param: In] set
      {
        this.PropertySet(nameof (InProcess), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InProcess));
      }
    }

    public Primitive<int> TimersCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (TimersCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TimersCount));
      }
    }

    public Primitive<bool> InRework
    {
      [param: In] set
      {
        this.PropertySet(nameof (InRework), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InRework));
      }
    }

    public Primitive<DateTime> LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public NamedObjectRef[] ClearanceWorkstations
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearanceWorkstations), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ClearanceWorkstations));
      }
    }

    public NamedObjectRef Workstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Workstation));
      }
    }

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }

    public NamedObjectRef Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Operation));
      }
    }

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }
  }
}
