// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteProductionProcess_Info
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
  public class ExecuteProductionProcess_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Instruction")]
    protected Info _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_TaskType")]
    protected Info _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_CalledByTransactionTask")]
    protected new Info _CalledByTransactionTask;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_InstructionType")]
    protected Info _InstructionType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_TaskComments")]
    protected Info _TaskComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_PrerequisiteTasks")]
    protected Info _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_ElectronicProcedure")]
    protected Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_TaskList")]
    protected Info _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_ProcessSequenceValidation")]
    protected ProcessSequenceValidation_Info _ProcessSequenceValidation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_ProcessListDetails")]
    protected ProcessListDetail_Info _ProcessListDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Pass")]
    protected Info _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_IsConfirmation")]
    protected new Info _IsConfirmation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_TaskContainer")]
    protected new Info _TaskContainer;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_WorkCell")]
    protected Info _WorkCell;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_DerivedWorkstation")]
    protected Info _DerivedWorkstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_DocumentEntries")]
    protected DocumentEntry_Info _DocumentEntries;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteProductionProcess_Info_ParametricDataDef")]
    protected Info _ParametricDataDef;

    public Info Instruction
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instruction), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Instruction));
      }
    }

    public Info TaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskType));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public new Info CalledByTransactionTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CalledByTransactionTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CalledByTransactionTask));
      }
    }

    public Info InstructionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstructionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstructionType));
      }
    }

    public Info TaskComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskComments));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info PrerequisiteTasks
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

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info ElectronicProcedure
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

    public Info TaskList
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

    public ProcessSequenceValidation_Info ProcessSequenceValidation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessSequenceValidation), (object) value);
      }
      get
      {
        return (ProcessSequenceValidation_Info) this.PropertyGet(nameof (ProcessSequenceValidation));
      }
    }

    public ProcessListDetail_Info ProcessListDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessListDetails), (object) value);
      }
      get
      {
        return (ProcessListDetail_Info) this.PropertyGet(nameof (ProcessListDetails));
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

    public new Info TaskContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskContainer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskContainer));
      }
    }

    public new Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public Info WorkCell
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkCell), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkCell));
      }
    }

    public Info DerivedWorkstation
    {
      [param: In] set
      {
        this.PropertySet(nameof (DerivedWorkstation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DerivedWorkstation));
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

    public DocumentEntry_Info DocumentEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentEntries), (object) value);
      }
      get
      {
        return (DocumentEntry_Info) this.PropertyGet(nameof (DocumentEntries));
      }
    }

    public Info ParametricDataDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParametricDataDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParametricDataDef));
      }
    }
  }
}
