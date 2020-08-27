// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectMaint
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
  public class ProcessObjectMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ObjectListInquiry")]
    protected NamedSubentityRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ObjectChanges")]
    protected ProcessObjectChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_BusinessRule")]
    protected NamedObjectRef _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ValidChildTypes")]
    protected Primitive<string> _ValidChildTypes;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_Template")]
    protected BaseObjectRef _Template;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_StructureChanges")]
    protected BaseObjectRef _StructureChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectMaint_ParentDataObject")]
    protected new BaseObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectMaint && object.Equals((object) this._RuleList, (object) ((ProcessObjectMaint) obj)._RuleList) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ProcessObjectMaint) obj)._ObjectListInquiry) && object.Equals((object) this._ChecklistTemplate, (object) ((ProcessObjectMaint) obj)._ChecklistTemplate)) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((ProcessObjectMaint) obj)._ApprovalSheetTemplate) && object.Equals((object) this._ObjectToChange, (object) ((ProcessObjectMaint) obj)._ObjectToChange) && (object.Equals((object) this._ObjectChanges, (object) ((ProcessObjectMaint) obj)._ObjectChanges) && object.Equals((object) this._ExecuteChecklist, (object) ((ProcessObjectMaint) obj)._ExecuteChecklist))) && (object.Equals((object) this._BusinessRule, (object) ((ProcessObjectMaint) obj)._BusinessRule) && object.Equals((object) this._ValidChildTypes, (object) ((ProcessObjectMaint) obj)._ValidChildTypes) && (object.Equals((object) this._Template, (object) ((ProcessObjectMaint) obj)._Template) && object.Equals((object) this._StructureChanges, (object) ((ProcessObjectMaint) obj)._StructureChanges)) && object.Equals((object) this._ParentDataObject, (object) ((ProcessObjectMaint) obj)._ParentDataObject)) && base.Equals(obj);
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

    public NamedSubentityRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedSubentityRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
    }

    public NamedObjectRef ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovalSheetTemplate));
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

    public ProcessObjectChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ExecuteChecklist ExecuteChecklist
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecuteChecklist), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (ExecuteChecklist));
      }
    }

    public NamedObjectRef BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Primitive<string> ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ValidChildTypes));
      }
    }

    public BaseObjectRef Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Template));
      }
    }

    public BaseObjectRef StructureChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (StructureChanges), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (StructureChanges));
      }
    }

    public new BaseObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
