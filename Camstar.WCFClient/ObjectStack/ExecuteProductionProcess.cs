// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteProductionProcess
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
  public class ExecuteProductionProcess : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Instruction")]
    protected Primitive<string> _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_TaskType")]
    protected Enumeration<TaskTypeEnum, int> _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_CalledByTransactionTask")]
    protected new NamedSubentityRef _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_InstructionType")]
    protected Enumeration<InstructionTypeEnum, int> _InstructionType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_TaskComments")]
    protected Primitive<string> _TaskComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_PrerequisiteTasks")]
    protected NamedSubentityRef[] _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_ElectronicProcedure")]
    protected RevisionedObjectRef _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_TaskList")]
    protected RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Task")]
    protected NamedSubentityRef _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_ProcessSequenceValidation")]
    protected ProcessSequenceValidation _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_ProcessListDetails")]
    protected ProcessListDetail[] _ProcessListDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Pass")]
    protected Primitive<bool> _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_IsConfirmation")]
    protected new Primitive<bool> _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_TaskContainer")]
    protected new ContainerRef _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_WorkCell")]
    protected NamedObjectRef _WorkCell;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_DerivedWorkstation")]
    protected NamedObjectRef _DerivedWorkstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Workstation")]
    protected NamedObjectRef _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_DocumentEntries")]
    protected DocumentEntry[] _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_ParametricDataDef")]
    protected Primitive<string> _ParametricDataDef;

    public override bool Equals(object obj)
    {
      return obj is ExecuteProductionProcess && object.Equals((object) this._Instruction, (object) ((ExecuteProductionProcess) obj)._Instruction) && (object.Equals((object) this._TaskType, (object) ((ExecuteProductionProcess) obj)._TaskType) && object.Equals((object) this._Sequence, (object) ((ExecuteProductionProcess) obj)._Sequence)) && (object.Equals((object) this._CalledByTransactionTask, (object) ((ExecuteProductionProcess) obj)._CalledByTransactionTask) && object.Equals((object) this._InstructionType, (object) ((ExecuteProductionProcess) obj)._InstructionType) && (object.Equals((object) this._TaskComments, (object) ((ExecuteProductionProcess) obj)._TaskComments) && object.Equals((object) this._TrainingReqGroup, (object) ((ExecuteProductionProcess) obj)._TrainingReqGroup))) && (this.CompareArrays((Array) this._PrerequisiteTasks, (Array) ((ExecuteProductionProcess) obj)._PrerequisiteTasks) && object.Equals((object) this._Carrier, (object) ((ExecuteProductionProcess) obj)._Carrier) && (object.Equals((object) this._ElectronicProcedure, (object) ((ExecuteProductionProcess) obj)._ElectronicProcedure) && object.Equals((object) this._TaskList, (object) ((ExecuteProductionProcess) obj)._TaskList)) && (object.Equals((object) this._Task, (object) ((ExecuteProductionProcess) obj)._Task) && object.Equals((object) this._ProcessSequenceValidation, (object) ((ExecuteProductionProcess) obj)._ProcessSequenceValidation) && (this.CompareArrays((Array) this._ProcessListDetails, (Array) ((ExecuteProductionProcess) obj)._ProcessListDetails) && object.Equals((object) this._Container, (object) ((ExecuteProductionProcess) obj)._Container)))) && (object.Equals((object) this._Pass, (object) ((ExecuteProductionProcess) obj)._Pass) && object.Equals((object) this._IsConfirmation, (object) ((ExecuteProductionProcess) obj)._IsConfirmation) && (object.Equals((object) this._TaskContainer, (object) ((ExecuteProductionProcess) obj)._TaskContainer) && object.Equals((object) this._UseDispatch, (object) ((ExecuteProductionProcess) obj)._UseDispatch)) && (object.Equals((object) this._DocumentSet, (object) ((ExecuteProductionProcess) obj)._DocumentSet) && object.Equals((object) this._WorkCell, (object) ((ExecuteProductionProcess) obj)._WorkCell) && (object.Equals((object) this._DerivedWorkstation, (object) ((ExecuteProductionProcess) obj)._DerivedWorkstation) && object.Equals((object) this._Workstation, (object) ((ExecuteProductionProcess) obj)._Workstation))) && (this.CompareArrays((Array) this._DocumentEntries, (Array) ((ExecuteProductionProcess) obj)._DocumentEntries) && object.Equals((object) this._ParametricDataDef, (object) ((ExecuteProductionProcess) obj)._ParametricDataDef))) && base.Equals(obj);
    }

    public Primitive<string> Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Instruction));
      }
    }

    public Enumeration<TaskTypeEnum, int> TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Enumeration<TaskTypeEnum, int>) this.PropertyGet(nameof (TaskType));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public new NamedSubentityRef CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public Enumeration<InstructionTypeEnum, int> InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Enumeration<InstructionTypeEnum, int>) this.PropertyGet(nameof (InstructionType));
      }
    }

    public Primitive<string> TaskComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TaskComments));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NamedSubentityRef[] PrerequisiteTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTasks), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (PrerequisiteTasks));
      }
    }

    public new NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public RevisionedObjectRef ElectronicProcedure
    {
      [param: In] set
      {
        this.PropertySet(nameof (ElectronicProcedure), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ElectronicProcedure));
      }
    }

    public RevisionedObjectRef TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TaskList));
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

    public ProcessSequenceValidation ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (ProcessSequenceValidation) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public ProcessListDetail[] ProcessListDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessListDetails), (object) value);
      }
      get
      {
        return (ProcessListDetail[]) this.PropertyGet(nameof (ProcessListDetails));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
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

    public new Primitive<bool> IsConfirmation
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsConfirmation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsConfirmation));
      }
    }

    public new ContainerRef TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public NamedObjectRef DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public NamedObjectRef WorkCell
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCell), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkCell));
      }
    }

    public NamedObjectRef DerivedWorkstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DerivedWorkstation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DerivedWorkstation));
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

    public DocumentEntry[] DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry[]) this.PropertyGet(nameof (DocumentEntries));
      }
    }

    public Primitive<string> ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParametricDataDef));
      }
    }
  }
}
