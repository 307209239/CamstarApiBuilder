// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplate
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
  public class PhaseTemplate : ProcessObjectTemplate
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_AssigneeRole")]
    protected new NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Organizations")]
    protected new NamedObjectRef[] _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_CompleteWithinUOM")]
    protected new Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_onStartRules")]
    protected BusinessRuleData[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_onCompleteRules")]
    protected BusinessRuleData[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Checklist")]
    protected new Checklist _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Details")]
    protected new ProcessObject[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_AllowReassignment")]
    protected new Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_ApprovalSheets")]
    protected ApprovalSheet[] _ApprovalSheets;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_AssigneeOption")]
    protected new Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_IsRequired")]
    protected new Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_AutoStart")]
    protected new Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_CompleteWithinQty")]
    protected new Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_DefaultAssigneeInfo")]
    protected new Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_ApprovalRequired")]
    protected new Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_AutoComplete")]
    protected new Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Assignee")]
    protected new NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_DocumentSet")]
    protected new NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplate_Status")]
    protected new Enumeration<StatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is PhaseTemplate && object.Equals((object) this._Description, (object) ((PhaseTemplate) obj)._Description) && (object.Equals((object) this._AssigneeRole, (object) ((PhaseTemplate) obj)._AssigneeRole) && this.CompareArrays((Array) this._Organizations, (Array) ((PhaseTemplate) obj)._Organizations)) && (object.Equals((object) this._CompleteWithinUOM, (object) ((PhaseTemplate) obj)._CompleteWithinUOM) && this.CompareArrays((Array) this._onStartRules, (Array) ((PhaseTemplate) obj)._onStartRules) && (this.CompareArrays((Array) this._onCompleteRules, (Array) ((PhaseTemplate) obj)._onCompleteRules) && object.Equals((object) this._Checklist, (object) ((PhaseTemplate) obj)._Checklist))) && (object.Equals((object) this._FilterTags, (object) ((PhaseTemplate) obj)._FilterTags) && this.CompareArrays((Array) this._Details, (Array) ((PhaseTemplate) obj)._Details) && (object.Equals((object) this._AllowReassignment, (object) ((PhaseTemplate) obj)._AllowReassignment) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((PhaseTemplate) obj)._ModelingInstanceLocks)) && (this.CompareArrays((Array) this._ApprovalSheets, (Array) ((PhaseTemplate) obj)._ApprovalSheets) && object.Equals((object) this._AssigneeOption, (object) ((PhaseTemplate) obj)._AssigneeOption) && (object.Equals((object) this._IsRequired, (object) ((PhaseTemplate) obj)._IsRequired) && object.Equals((object) this._AssociatedPackages, (object) ((PhaseTemplate) obj)._AssociatedPackages)))) && (object.Equals((object) this._AutoStart, (object) ((PhaseTemplate) obj)._AutoStart) && object.Equals((object) this._CompleteWithinQty, (object) ((PhaseTemplate) obj)._CompleteWithinQty) && (object.Equals((object) this._DefaultAssigneeInfo, (object) ((PhaseTemplate) obj)._DefaultAssigneeInfo) && object.Equals((object) this._InstanceLocked, (object) ((PhaseTemplate) obj)._InstanceLocked)) && (object.Equals((object) this._ApprovalRequired, (object) ((PhaseTemplate) obj)._ApprovalRequired) && object.Equals((object) this._AutoComplete, (object) ((PhaseTemplate) obj)._AutoComplete) && (object.Equals((object) this._IconId, (object) ((PhaseTemplate) obj)._IconId) && object.Equals((object) this._Assignee, (object) ((PhaseTemplate) obj)._Assignee))) && (object.Equals((object) this._Name, (object) ((PhaseTemplate) obj)._Name) && object.Equals((object) this._DocumentSet, (object) ((PhaseTemplate) obj)._DocumentSet) && (object.Equals((object) this._Notes, (object) ((PhaseTemplate) obj)._Notes) && object.Equals((object) this._ChangeHistory, (object) ((PhaseTemplate) obj)._ChangeHistory)) && (object.Equals((object) this._IsFrozen, (object) ((PhaseTemplate) obj)._IsFrozen) && object.Equals((object) this._Status, (object) ((PhaseTemplate) obj)._Status)))) && base.Equals(obj);
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

    public BusinessRuleData[] onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleData[]) this.PropertyGet(nameof (onStartRules));
      }
    }

    public BusinessRuleData[] onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleData[]) this.PropertyGet(nameof (onCompleteRules));
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

    public new ProcessObject[] Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (ProcessObject[]) this.PropertyGet(nameof (Details));
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

    public ApprovalSheet[] ApprovalSheets
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheets), (object) value);
      }
      get
      {
        return (ApprovalSheet[]) this.PropertyGet(nameof (ApprovalSheets));
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
  }
}
