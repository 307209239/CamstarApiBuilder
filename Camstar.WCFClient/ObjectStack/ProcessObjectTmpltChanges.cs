// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTmpltChanges
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
  public class ProcessObjectTmpltChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_ExecutionContextType")]
    protected Primitive<int> _ExecutionContextType;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_AssigneeRole")]
    protected NamedObjectRef _AssigneeRole;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Organizations")]
    protected NamedObjectRef[] _Organizations;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Checklist")]
    protected ChecklistChanges _Checklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_AllowReassignment")]
    protected Enumeration<ReassignmentRestrictionEnum, int> _AllowReassignment;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Details")]
    protected ProcessObjectChanges[] _Details;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_AssigneeOption")]
    protected Enumeration<AssigneeOptionEnum, int> _AssigneeOption;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_CompleteWithinUOM")]
    protected Enumeration<DurationUOMEnum, string> _CompleteWithinUOM;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_CompleteWithinQty")]
    protected Primitive<int> _CompleteWithinQty;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_AutoStart")]
    protected Primitive<bool> _AutoStart;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_DefaultAssigneeInfo")]
    protected Primitive<bool> _DefaultAssigneeInfo;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_ApprovalRequired")]
    protected Primitive<bool> _ApprovalRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_AutoComplete")]
    protected Primitive<bool> _AutoComplete;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_IsRequired")]
    protected Primitive<bool> _IsRequired;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_DocumentSet")]
    protected NamedObjectRef _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Assignee")]
    protected NamedObjectRef _Assignee;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTmpltChanges_Status")]
    protected Enumeration<StatusEnum, int> _Status;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectTmpltChanges && object.Equals((object) this._ExecutionContextType, (object) ((ProcessObjectTmpltChanges) obj)._ExecutionContextType) && (object.Equals((object) this._RuleList, (object) ((ProcessObjectTmpltChanges) obj)._RuleList) && object.Equals((object) this._Description, (object) ((ProcessObjectTmpltChanges) obj)._Description)) && (object.Equals((object) this._AssigneeRole, (object) ((ProcessObjectTmpltChanges) obj)._AssigneeRole) && this.CompareArrays((Array) this._Organizations, (Array) ((ProcessObjectTmpltChanges) obj)._Organizations) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessObjectTmpltChanges) obj)._ObjectToChange) && object.Equals((object) this._Checklist, (object) ((ProcessObjectTmpltChanges) obj)._Checklist))) && (object.Equals((object) this._AllowReassignment, (object) ((ProcessObjectTmpltChanges) obj)._AllowReassignment) && this.CompareArrays((Array) this._Details, (Array) ((ProcessObjectTmpltChanges) obj)._Details) && (object.Equals((object) this._AssigneeOption, (object) ((ProcessObjectTmpltChanges) obj)._AssigneeOption) && object.Equals((object) this._CompleteWithinUOM, (object) ((ProcessObjectTmpltChanges) obj)._CompleteWithinUOM)) && (object.Equals((object) this._CompleteWithinQty, (object) ((ProcessObjectTmpltChanges) obj)._CompleteWithinQty) && object.Equals((object) this._AutoStart, (object) ((ProcessObjectTmpltChanges) obj)._AutoStart) && (object.Equals((object) this._DefaultAssigneeInfo, (object) ((ProcessObjectTmpltChanges) obj)._DefaultAssigneeInfo) && object.Equals((object) this._ApprovalRequired, (object) ((ProcessObjectTmpltChanges) obj)._ApprovalRequired)))) && (object.Equals((object) this._AutoComplete, (object) ((ProcessObjectTmpltChanges) obj)._AutoComplete) && object.Equals((object) this._IsRequired, (object) ((ProcessObjectTmpltChanges) obj)._IsRequired) && (object.Equals((object) this._DocumentSet, (object) ((ProcessObjectTmpltChanges) obj)._DocumentSet) && object.Equals((object) this._Assignee, (object) ((ProcessObjectTmpltChanges) obj)._Assignee)) && (object.Equals((object) this._Name, (object) ((ProcessObjectTmpltChanges) obj)._Name) && object.Equals((object) this._Status, (object) ((ProcessObjectTmpltChanges) obj)._Status))) && base.Equals(obj);
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

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
