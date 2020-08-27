// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTemplate
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
  public class ProcessObjectTemplate : NamedDataObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Organizations")]
    protected NamedObjectRef[] _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Details")]
    protected ProcessObject[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Checklist")]
    protected Checklist _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_AllowReassignment")]
    protected Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_AutoStart")]
    protected Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_AutoComplete")]
    protected Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_DefaultAssigneeInfo")]
    protected Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Assignee")]
    protected NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplate_Status")]
    protected Enumeration<StatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectTemplate && this.CompareArrays((Array) this._Organizations, (Array) ((ProcessObjectTemplate) obj)._Organizations) && (object.Equals((object) this._AssigneeRole, (object) ((ProcessObjectTemplate) obj)._AssigneeRole) && object.Equals((object) this._Description, (object) ((ProcessObjectTemplate) obj)._Description)) && (this.CompareArrays((Array) this._Details, (Array) ((ProcessObjectTemplate) obj)._Details) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((ProcessObjectTemplate) obj)._ModelingInstanceLocks) && (object.Equals((object) this._AssigneeOption, (object) ((ProcessObjectTemplate) obj)._AssigneeOption) && object.Equals((object) this._Checklist, (object) ((ProcessObjectTemplate) obj)._Checklist))) && (object.Equals((object) this._AllowReassignment, (object) ((ProcessObjectTemplate) obj)._AllowReassignment) && object.Equals((object) this._FilterTags, (object) ((ProcessObjectTemplate) obj)._FilterTags) && (object.Equals((object) this._CompleteWithinUOM, (object) ((ProcessObjectTemplate) obj)._CompleteWithinUOM) && object.Equals((object) this._AutoStart, (object) ((ProcessObjectTemplate) obj)._AutoStart)) && (object.Equals((object) this._AutoComplete, (object) ((ProcessObjectTemplate) obj)._AutoComplete) && object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessObjectTemplate) obj)._DefaultAssigneeInfo) && (object.Equals((object) this._IsRequired, (object) ((ProcessObjectTemplate) obj)._IsRequired) && object.Equals((object) this._AssociatedPackages, (object) ((ProcessObjectTemplate) obj)._AssociatedPackages)))) && (object.Equals((object) this._InstanceLocked, (object) ((ProcessObjectTemplate) obj)._InstanceLocked) && object.Equals((object) this._CompleteWithinQty, (object) ((ProcessObjectTemplate) obj)._CompleteWithinQty) && (object.Equals((object) this._ApprovalRequired, (object) ((ProcessObjectTemplate) obj)._ApprovalRequired) && object.Equals((object) this._ChangeHistory, (object) ((ProcessObjectTemplate) obj)._ChangeHistory)) && (object.Equals((object) this._IconId, (object) ((ProcessObjectTemplate) obj)._IconId) && object.Equals((object) this._Notes, (object) ((ProcessObjectTemplate) obj)._Notes) && (object.Equals((object) this._IsFrozen, (object) ((ProcessObjectTemplate) obj)._IsFrozen) && object.Equals((object) this._Name, (object) ((ProcessObjectTemplate) obj)._Name))) && (object.Equals((object) this._DocumentSet, (object) ((ProcessObjectTemplate) obj)._DocumentSet) && object.Equals((object) this._Assignee, (object) ((ProcessObjectTemplate) obj)._Assignee) && object.Equals((object) this._Status, (object) ((ProcessObjectTemplate) obj)._Status))) && base.Equals(obj);
    }

    public NamedObjectRef[] Organizations
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

    public ProcessObject[] Details
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

    public Checklist Checklist
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

    public Primitive<bool> ApprovalRequired
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

    public Enumeration<StatusEnum, int> Status
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
