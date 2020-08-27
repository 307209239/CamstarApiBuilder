// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ExecuteTaskHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ExecuteRecipeTaskHistory_Info))]
  [Serializable]
  public class ExecuteTaskHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_TaskType")]
    protected Info _TaskType;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_HistoryDetails")]
    protected new ServiceHistoryDetail_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_TaskComments")]
    protected Info _TaskComments;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_TaskListSequence")]
    protected Info _TaskListSequence;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_Instruction")]
    protected Info _Instruction;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_TaskList")]
    protected Info _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_ElectronicProcedure")]
    protected Info _ElectronicProcedure;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_Task")]
    protected Info _Task;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_PrerequisiteTasks")]
    protected Info _PrerequisiteTasks;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_Pass")]
    protected Info _Pass;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_Workstation")]
    protected Info _Workstation;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ExecuteTaskHistory_Info_WorkCell")]
    protected Info _WorkCell;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
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

    public new ServiceHistoryDetail_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ServiceHistoryDetail_Info) this.PropertyGet(nameof (HistoryDetails));
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

    public Info TaskListSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskListSequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskListSequence));
      }
    }

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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
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
  }
}
