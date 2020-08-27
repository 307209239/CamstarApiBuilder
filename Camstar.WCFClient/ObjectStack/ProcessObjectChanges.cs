// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ActivityChanges))]
  [KnownType(typeof (PlanChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (PhaseChanges))]
  [KnownType(typeof (ProcessModelChanges))]
  [Serializable]
  public class ProcessObjectChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_ReassignmentComments")]
    protected Primitive<string> _ReassignmentComments;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_ExecutionContextType")]
    protected Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Prerequisites")]
    protected NamedSubentityRef[] _Prerequisites;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_AllowReassignment")]
    protected Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_DataPointCollection")]
    protected DataPointCollectionChanges _DataPointCollection;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_LastStage")]
    protected Enumeration<StageEnum, int> _LastStage;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Checklist")]
    protected ChecklistChanges _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Details")]
    protected ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_AutoStart")]
    protected Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_AutoComplete")]
    protected Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_OnHold")]
    protected Primitive<bool> _OnHold;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_DefaultAssigneeInfo")]
    protected Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Assignee")]
    protected NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Notes")]
    protected Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectChanges && object.Equals((object) this._AssigneeRole, (object) ((ProcessObjectChanges) obj)._AssigneeRole) && (object.Equals((object) this._ReassignmentComments, (object) ((ProcessObjectChanges) obj)._ReassignmentComments) && object.Equals((object) this._RuleList, (object) ((ProcessObjectChanges) obj)._RuleList)) && (object.Equals((object) this._Description, (object) ((ProcessObjectChanges) obj)._Description) && object.Equals((object) this._ExecutionContextType, (object) ((ProcessObjectChanges) obj)._ExecutionContextType) && (object.Equals((object) this._ChangeHistory, (object) ((ProcessObjectChanges) obj)._ChangeHistory) && object.Equals((object) this._ObjectToChange, (object) ((ProcessObjectChanges) obj)._ObjectToChange))) && (this.CompareArrays((Array) this._Prerequisites, (Array) ((ProcessObjectChanges) obj)._Prerequisites) && object.Equals((object) this._AllowReassignment, (object) ((ProcessObjectChanges) obj)._AllowReassignment) && (object.Equals((object) this._DataPointCollection, (object) ((ProcessObjectChanges) obj)._DataPointCollection) && object.Equals((object) this._ListItemToChange, (object) ((ProcessObjectChanges) obj)._ListItemToChange)) && (object.Equals((object) this._LastStage, (object) ((ProcessObjectChanges) obj)._LastStage) && object.Equals((object) this._AssigneeOption, (object) ((ProcessObjectChanges) obj)._AssigneeOption) && (object.Equals((object) this._CompleteWithinUOM, (object) ((ProcessObjectChanges) obj)._CompleteWithinUOM) && object.Equals((object) this._Checklist, (object) ((ProcessObjectChanges) obj)._Checklist)))) && (this.CompareArrays((Array) this._Details, (Array) ((ProcessObjectChanges) obj)._Details) && object.Equals((object) this._AutoStart, (object) ((ProcessObjectChanges) obj)._AutoStart) && (object.Equals((object) this._AutoComplete, (object) ((ProcessObjectChanges) obj)._AutoComplete) && object.Equals((object) this._CompleteWithinQty, (object) ((ProcessObjectChanges) obj)._CompleteWithinQty)) && (object.Equals((object) this._OnHold, (object) ((ProcessObjectChanges) obj)._OnHold) && object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessObjectChanges) obj)._DefaultAssigneeInfo) && (object.Equals((object) this._Sequence, (object) ((ProcessObjectChanges) obj)._Sequence) && object.Equals((object) this._IsRequired, (object) ((ProcessObjectChanges) obj)._IsRequired))) && (object.Equals((object) this._Assignee, (object) ((ProcessObjectChanges) obj)._Assignee) && object.Equals((object) this._Notes, (object) ((ProcessObjectChanges) obj)._Notes) && (object.Equals((object) this._Name, (object) ((ProcessObjectChanges) obj)._Name) && object.Equals((object) this._DocumentSet, (object) ((ProcessObjectChanges) obj)._DocumentSet)))) && base.Equals(obj);
    }

    public NamedObjectRef AssigneeRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssigneeRole));
      }
    }

    public Primitive<string> ReassignmentComments
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReassignmentComments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReassignmentComments));
      }
    }

    public Primitive<string> RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RuleList));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<int> ExecutionContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionContextType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExecutionContextType));
      }
    }

    public ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedSubentityRef[] Prerequisites
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prerequisites), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (Prerequisites));
      }
    }

    public Enumeration<ReassignmentRestrictionEnum, int> AllowReassignment
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowReassignment), (object) value);
      }
      get
      {
        return (Enumeration<ReassignmentRestrictionEnum, int>) this.PropertyGet(nameof (AllowReassignment));
      }
    }

    public DataPointCollectionChanges DataPointCollection
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointCollection), (object) value);
      }
      get
      {
        return (DataPointCollectionChanges) this.PropertyGet(nameof (DataPointCollection));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Enumeration<StageEnum, int> LastStage
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastStage), (object) value);
      }
      get
      {
        return (Enumeration<StageEnum, int>) this.PropertyGet(nameof (LastStage));
      }
    }

    public Enumeration<AssigneeOptionEnum, int> AssigneeOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssigneeOption), (object) value);
      }
      get
      {
        return (Enumeration<AssigneeOptionEnum, int>) this.PropertyGet(nameof (AssigneeOption));
      }
    }

    public Enumeration<DurationUOMEnum, string> CompleteWithinUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinUOM), (object) value);
      }
      get
      {
        return (Enumeration<DurationUOMEnum, string>) this.PropertyGet(nameof (CompleteWithinUOM));
      }
    }

    public ChecklistChanges Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (ChecklistChanges) this.PropertyGet(nameof (Checklist));
      }
    }

    public ProcessObjectChanges[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObjectChanges[]) this.PropertyGet(nameof (Details));
      }
    }

    public Primitive<bool> AutoStart
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoStart), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoStart));
      }
    }

    public Primitive<bool> AutoComplete
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoComplete), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoComplete));
      }
    }

    public Primitive<int> CompleteWithinQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompleteWithinQty), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CompleteWithinQty));
      }
    }

    public Primitive<bool> OnHold
    {
      [param: In] set
      {
        this.PropertySet(nameof (OnHold), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OnHold));
      }
    }

    public Primitive<bool> DefaultAssigneeInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultAssigneeInfo), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DefaultAssigneeInfo));
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

    public Primitive<bool> IsRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRequired));
      }
    }

    public NamedObjectRef Assignee
    {
      [param: In] set
      {
        this.PropertySet(nameof (Assignee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Assignee));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
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
  }
}
