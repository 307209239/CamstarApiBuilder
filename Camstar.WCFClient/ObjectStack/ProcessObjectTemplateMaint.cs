// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessObjectTemplateMaint
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
  public class ProcessObjectTemplateMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ObjectChanges")]
    protected ProcessObjectTmpltChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ProcessObjectTemplateDetails")]
    protected ProcessObjectTemplate _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_BusinessRule")]
    protected NamedObjectRef _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ExecuteChecklist")]
    protected ExecuteChecklist _ExecuteChecklist;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_Templates")]
    protected Primitive<string> _Templates;
    [DataMember(EmitDefaultValue = false, Name = "ProcessObjectTemplateMaint_ValidChildTypes")]
    protected Primitive<string> _ValidChildTypes;

    public override bool Equals(object obj)
    {
      return obj is ProcessObjectTemplateMaint && object.Equals((object) this._RuleList, (object) ((ProcessObjectTemplateMaint) obj)._RuleList) && (object.Equals((object) this._ObjectChanges, (object) ((ProcessObjectTemplateMaint) obj)._ObjectChanges) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((ProcessObjectTemplateMaint) obj)._ProcessObjectTemplateDetails)) && (object.Equals((object) this._BusinessRule, (object) ((ProcessObjectTemplateMaint) obj)._BusinessRule) && object.Equals((object) this._ChecklistTemplate, (object) ((ProcessObjectTemplateMaint) obj)._ChecklistTemplate) && (object.Equals((object) this._ExecuteChecklist, (object) ((ProcessObjectTemplateMaint) obj)._ExecuteChecklist) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ProcessObjectTemplateMaint) obj)._ObjectListInquiry))) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessObjectTemplateMaint) obj)._ObjectToChange) && object.Equals((object) this._Templates, (object) ((ProcessObjectTemplateMaint) obj)._Templates) && object.Equals((object) this._ValidChildTypes, (object) ((ProcessObjectTemplateMaint) obj)._ValidChildTypes)) && base.Equals(obj);
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

    public ProcessObjectTmpltChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessObjectTmpltChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ProcessObjectTemplate ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ProcessObjectTemplate) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
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

    public Primitive<string> Templates
    {
      [param: In] set
      {
        this.PropertySet(nameof (Templates), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Templates));
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
  }
}
