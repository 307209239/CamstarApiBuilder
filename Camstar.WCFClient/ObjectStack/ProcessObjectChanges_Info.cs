// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (PlanChanges_Info))]
  [KnownType(typeof (ActivityChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PhaseChanges_Info))]
  [KnownType(typeof (ProcessModelChanges_Info))]
  [Serializable]
  public class ProcessObjectChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_AssigneeRole")]
    protected Info _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_ReassignmentComments")]
    protected Info _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_RuleList")]
    protected Info _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_ExecutionContextType")]
    protected Info _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_ChangeHistory")]
    protected ChangeHistoryChanges_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Prerequisites")]
    protected Info _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_AllowReassignment")]
    protected Info _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_DataPointCollection")]
    protected DataPointCollectionChanges_Info _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_LastStage")]
    protected Info _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_AssigneeOption")]
    protected Info _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_CompleteWithinUOM")]
    protected Info _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Checklist")]
    protected ChecklistChanges_Info _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Details")]
    protected ProcessObjectChanges_Info _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_AutoStart")]
    protected Info _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_AutoComplete")]
    protected Info _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_CompleteWithinQty")]
    protected Info _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_OnHold")]
    protected Info _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_DefaultAssigneeInfo")]
    protected Info _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_IsRequired")]
    protected Info _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Assignee")]
    protected Info _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Notes")]
    protected Info _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Info_DocumentSet")]
    protected Info _DocumentSet;

    public Info AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Info ReassignmentComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReassignmentComments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReassignmentComments));
      }
    }

    public Info RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RuleList));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public ChangeHistoryChanges_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public Info AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public DataPointCollectionChanges_Info DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (DataPointCollectionChanges_Info) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info LastStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastStage));
      }
    }

    public Info AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public Info CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public ChecklistChanges_Info Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (ChecklistChanges_Info) this.PropertyGet(nameof (Checklist));
      }
    }

    public ProcessObjectChanges_Info Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges_Info) this.PropertyGet(nameof (Details));
      }
    }

    public Info AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Info AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public Info CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public Info OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OnHold));
      }
    }

    public Info DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultAssigneeInfo));
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

    public Info IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRequired));
      }
    }

    public Info Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Assignee));
      }
    }

    public Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
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
  }
}
