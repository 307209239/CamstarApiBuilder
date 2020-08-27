// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplateChanges
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
  public class ProcessModelTemplateChanges : RevisionedObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_WIPMsgDefMgr")]
    protected new WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_ExecutionContextType")]
    protected Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_EffectiveFromDateGMT")]
    protected Primitive<DateTime> _EffectiveFromDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Organizations")]
    protected NamedObjectRef[] _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_onCompleteRules")]
    protected BusinessRuleDataChanges[] _onCompleteRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_onStartRules")]
    protected BusinessRuleDataChanges[] _onStartRules;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_AllowReassignment")]
    protected Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Details")]
    protected ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_EffectiveThruDate")]
    protected Primitive<DateTime> _EffectiveThruDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_EffectiveFromDate")]
    protected Primitive<DateTime> _EffectiveFromDate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_EffectiveThruDateGMT")]
    protected Primitive<DateTime> _EffectiveThruDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_AutoComplete")]
    protected Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_DefaultAssigneeInfo")]
    protected Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Assignee")]
    protected NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ProcessModelTemplateChanges && object.Equals((object) this._Description, (object) ((ProcessModelTemplateChanges) obj)._Description) && (object.Equals((object) this._WIPMsgDefMgr, (object) ((ProcessModelTemplateChanges) obj)._WIPMsgDefMgr) && object.Equals((object) this._ExecutionContextType, (object) ((ProcessModelTemplateChanges) obj)._ExecutionContextType)) && (object.Equals((object) this._RuleList, (object) ((ProcessModelTemplateChanges) obj)._RuleList) && object.Equals((object) this._AssigneeRole, (object) ((ProcessModelTemplateChanges) obj)._AssigneeRole) && (object.Equals((object) this._EffectiveFromDateGMT, (object) ((ProcessModelTemplateChanges) obj)._EffectiveFromDateGMT) && this.CompareArrays((Array) this._Organizations, (Array) ((ProcessModelTemplateChanges) obj)._Organizations))) && (this.CompareArrays((Array) this._onCompleteRules, (Array) ((ProcessModelTemplateChanges) obj)._onCompleteRules) && object.Equals((object) this._AssigneeOption, (object) ((ProcessModelTemplateChanges) obj)._AssigneeOption) && (this.CompareArrays((Array) this._onStartRules, (Array) ((ProcessModelTemplateChanges) obj)._onStartRules) && object.Equals((object) this._AllowReassignment, (object) ((ProcessModelTemplateChanges) obj)._AllowReassignment)) && (this.CompareArrays((Array) this._Details, (Array) ((ProcessModelTemplateChanges) obj)._Details) && object.Equals((object) this._EffectiveThruDate, (object) ((ProcessModelTemplateChanges) obj)._EffectiveThruDate) && (object.Equals((object) this._EffectiveFromDate, (object) ((ProcessModelTemplateChanges) obj)._EffectiveFromDate) && object.Equals((object) this._Base, (object) ((ProcessModelTemplateChanges) obj)._Base)))) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessModelTemplateChanges) obj)._ObjectToChange) && object.Equals((object) this._EffectiveThruDateGMT, (object) ((ProcessModelTemplateChanges) obj)._EffectiveThruDateGMT) && (object.Equals((object) this._AutoComplete, (object) ((ProcessModelTemplateChanges) obj)._AutoComplete) && object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessModelTemplateChanges) obj)._DefaultAssigneeInfo)) && (object.Equals((object) this._DocumentSet, (object) ((ProcessModelTemplateChanges) obj)._DocumentSet) && object.Equals((object) this._Assignee, (object) ((ProcessModelTemplateChanges) obj)._Assignee) && object.Equals((object) this._Name, (object) ((ProcessModelTemplateChanges) obj)._Name))) && base.Equals(obj);
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

    public new WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
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

    public BusinessRuleDataChanges[] onCompleteRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onCompleteRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onCompleteRules));
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

    public BusinessRuleDataChanges[] onStartRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (onStartRules), (object) value);
      }
      get
      {
        return (BusinessRuleDataChanges[]) this.PropertyGet(nameof (onStartRules));
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

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
