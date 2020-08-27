// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplate
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
  public class ActivityTemplate : ProcessObjectTemplate
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AssigneeRole")]
    protected new NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Organizations")]
    protected new NamedObjectRef[] _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AllowReassignment")]
    protected new Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Checklist")]
    protected new Checklist _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AssigneeOption")]
    protected new Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_CompleteWithinUOM")]
    protected new Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_onExecuteRules")]
    protected BusinessRuleData[] _onExecuteRules;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AutoExecute")]
    protected Primitive<bool> _AutoExecute;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_ApprovalRequired")]
    protected new Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_CompleteWithinQty")]
    protected new Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AutoComplete")]
    protected new Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_IsRequired")]
    protected new Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_DefaultAssigneeInfo")]
    protected new Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_AutoStart")]
    protected new Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Assignee")]
    protected new NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_DocumentSet")]
    protected new NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Status")]
    protected new Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplate_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ActivityTemplate && object.Equals((object) this._DataCollectionDef, (object) ((ActivityTemplate) obj)._DataCollectionDef) && (object.Equals((object) this._Description, (object) ((ActivityTemplate) obj)._Description) && object.Equals((object) this._AssigneeRole, (object) ((ActivityTemplate) obj)._AssigneeRole)) && (this.CompareArrays((Array) this._Organizations, (Array) ((ActivityTemplate) obj)._Organizations) && object.Equals((object) this._AllowReassignment, (object) ((ActivityTemplate) obj)._AllowReassignment) && (object.Equals((object) this._Checklist, (object) ((ActivityTemplate) obj)._Checklist) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((ActivityTemplate) obj)._ModelingInstanceLocks))) && (object.Equals((object) this._FilterTags, (object) ((ActivityTemplate) obj)._FilterTags) && object.Equals((object) this._AssigneeOption, (object) ((ActivityTemplate) obj)._AssigneeOption) && (object.Equals((object) this._CompleteWithinUOM, (object) ((ActivityTemplate) obj)._CompleteWithinUOM) && this.CompareArrays((Array) this._onExecuteRules, (Array) ((ActivityTemplate) obj)._onExecuteRules)) && (object.Equals((object) this._AssociatedPackages, (object) ((ActivityTemplate) obj)._AssociatedPackages) && object.Equals((object) this._AutoExecute, (object) ((ActivityTemplate) obj)._AutoExecute) && (object.Equals((object) this._ApprovalRequired, (object) ((ActivityTemplate) obj)._ApprovalRequired) && object.Equals((object) this._CompleteWithinQty, (object) ((ActivityTemplate) obj)._CompleteWithinQty)))) && (object.Equals((object) this._AutoComplete, (object) ((ActivityTemplate) obj)._AutoComplete) && object.Equals((object) this._InstanceLocked, (object) ((ActivityTemplate) obj)._InstanceLocked) && (object.Equals((object) this._IsRequired, (object) ((ActivityTemplate) obj)._IsRequired) && object.Equals((object) this._DefaultAssigneeInfo, (object) ((ActivityTemplate) obj)._DefaultAssigneeInfo)) && (object.Equals((object) this._AutoStart, (object) ((ActivityTemplate) obj)._AutoStart) && object.Equals((object) this._IconId, (object) ((ActivityTemplate) obj)._IconId) && (object.Equals((object) this._Assignee, (object) ((ActivityTemplate) obj)._Assignee) && object.Equals((object) this._DocumentSet, (object) ((ActivityTemplate) obj)._DocumentSet))) && (object.Equals((object) this._IsFrozen, (object) ((ActivityTemplate) obj)._IsFrozen) && object.Equals((object) this._ChangeHistory, (object) ((ActivityTemplate) obj)._ChangeHistory) && (object.Equals((object) this._Status, (object) ((ActivityTemplate) obj)._Status) && object.Equals((object) this._Notes, (object) ((ActivityTemplate) obj)._Notes)) && object.Equals((object) this._Name, (object) ((ActivityTemplate) obj)._Name))) && base.Equals(obj);
    }

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Primitive<string> Description
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

    public new NamedObjectRef AssigneeRole
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

    public new NamedObjectRef[] Organizations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organizations), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Organizations));
      }
    }

    public new Enumeration<ReassignmentRestrictionEnum, int> AllowReassignment
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

    public new Checklist Checklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (Checklist), (object) value);
      }
      get
      {
        return (Checklist) this.PropertyGet(nameof (Checklist));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Enumeration<AssigneeOptionEnum, int> AssigneeOption
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

    public new Enumeration<DurationUOMEnum, string> CompleteWithinUOM
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

    public BusinessRuleData[] onExecuteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onExecuteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData[]) this.PropertyGet(nameof (onExecuteRules));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public Primitive<bool> AutoExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AutoExecute), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AutoExecute));
      }
    }

    public new Primitive<bool> ApprovalRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ApprovalRequired));
      }
    }

    public new Primitive<int> CompleteWithinQty
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

    public new Primitive<bool> AutoComplete
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

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Primitive<bool> IsRequired
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

    public new Primitive<bool> DefaultAssigneeInfo
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

    public new Primitive<bool> AutoStart
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

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public new NamedObjectRef Assignee
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

    public new NamedObjectRef DocumentSet
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

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Enumeration<StatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<StatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public new Primitive<string> Notes
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
  }
}
