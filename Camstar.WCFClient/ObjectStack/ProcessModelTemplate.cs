// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplate
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
  public class ProcessModelTemplate : RevisionedObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_onCompleteRules")]
    protected BusinessRuleData[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Organizations")]
    protected NamedObjectRef[] _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_onStartRules")]
    protected BusinessRuleData[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Details")]
    protected ProcessObject[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_AllowReassignment")]
    protected Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_DefaultAssigneeInfo")]
    protected Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_AutoComplete")]
    protected Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Assignee")]
    protected NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Status")]
    protected new Enumeration<StatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplate_Revision")]
    protected new Primitive<string> _Revision;

    public override bool Equals(object obj)
    {
      return obj is ProcessModelTemplate && object.Equals((object) this._AssigneeRole, (object) ((ProcessModelTemplate) obj)._AssigneeRole) && (object.Equals((object) this._Description, (object) ((ProcessModelTemplate) obj)._Description) && object.Equals((object) this._EffectiveFromDate, (object) ((ProcessModelTemplate) obj)._EffectiveFromDate)) && (object.Equals((object) this._EffectiveFromDateGMT, (object) ((ProcessModelTemplate) obj)._EffectiveFromDateGMT) && this.CompareArrays((Array) this._onCompleteRules, (Array) ((ProcessModelTemplate) obj)._onCompleteRules) && (this.CompareArrays((Array) this._Organizations, (Array) ((ProcessModelTemplate) obj)._Organizations) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((ProcessModelTemplate) obj)._ModelingInstanceLocks))) && (object.Equals((object) this._FilterTags, (object) ((ProcessModelTemplate) obj)._FilterTags) && this.CompareArrays((Array) this._onStartRules, (Array) ((ProcessModelTemplate) obj)._onStartRules) && (this.CompareArrays((Array) this._Details, (Array) ((ProcessModelTemplate) obj)._Details) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((ProcessModelTemplate) obj)._EffectiveThruDateGMT)) && (object.Equals((object) this._AssigneeOption, (object) ((ProcessModelTemplate) obj)._AssigneeOption) && object.Equals((object) this._AllowReassignment, (object) ((ProcessModelTemplate) obj)._AllowReassignment) && (object.Equals((object) this._Base, (object) ((ProcessModelTemplate) obj)._Base) && object.Equals((object) this._EffectiveThruDate, (object) ((ProcessModelTemplate) obj)._EffectiveThruDate)))) && (object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessModelTemplate) obj)._DefaultAssigneeInfo) && object.Equals((object) this._AutoComplete, (object) ((ProcessModelTemplate) obj)._AutoComplete) && (object.Equals((object) this._AssociatedPackages, (object) ((ProcessModelTemplate) obj)._AssociatedPackages) && object.Equals((object) this._InstanceLocked, (object) ((ProcessModelTemplate) obj)._InstanceLocked)) && (object.Equals((object) this._IsFrozen, (object) ((ProcessModelTemplate) obj)._IsFrozen) && object.Equals((object) this._IconId, (object) ((ProcessModelTemplate) obj)._IconId) && (object.Equals((object) this._DocumentSet, (object) ((ProcessModelTemplate) obj)._DocumentSet) && object.Equals((object) this._Assignee, (object) ((ProcessModelTemplate) obj)._Assignee))) && (object.Equals((object) this._Status, (object) ((ProcessModelTemplate) obj)._Status) && object.Equals((object) this._Notes, (object) ((ProcessModelTemplate) obj)._Notes) && (object.Equals((object) this._Name, (object) ((ProcessModelTemplate) obj)._Name) && object.Equals((object) this._ChangeHistory, (object) ((ProcessModelTemplate) obj)._ChangeHistory)) && object.Equals((object) this._Revision, (object) ((ProcessModelTemplate) obj)._Revision))) && base.Equals(obj);
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

    public Primitive<DateTime> EffectiveFromDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDate));
      }
    }

    public Primitive<DateTime> EffectiveFromDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveFromDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveFromDateGMT));
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

    public Primitive<DateTime> EffectiveThruDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDateGMT));
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

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public Primitive<DateTime> EffectiveThruDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (EffectiveThruDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EffectiveThruDate));
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

    public new Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }
  }
}
