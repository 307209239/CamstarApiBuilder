// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProcessModelTemplateMaint
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
  public class ProcessModelTemplateMaint : RevisionedObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_RuleList")]
    protected Primitive<string> _RuleList;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_ObjectListInquiry")]
    protected new RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_BaseToChange")]
    protected new RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_BusinessRule")]
    protected NamedObjectRef _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_ObjectChanges")]
    protected ProcessModelTemplateChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_ProcessObjectTemplateDetails")]
    protected ProcessModelTemplate _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ProcessModelTemplateMaint_ValidChildTypes")]
    protected Primitive<string> _ValidChildTypes;

    public override bool Equals(object obj)
    {
      return obj is ProcessModelTemplateMaint && object.Equals((object) this._RuleList, (object) ((ProcessModelTemplateMaint) obj)._RuleList) && (object.Equals((object) this._ObjectToChange, (object) ((ProcessModelTemplateMaint) obj)._ObjectToChange) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((ProcessModelTemplateMaint) obj)._ObjectListInquiry)) && (object.Equals((object) this._BaseToChange, (object) ((ProcessModelTemplateMaint) obj)._BaseToChange) && object.Equals((object) this._BusinessRule, (object) ((ProcessModelTemplateMaint) obj)._BusinessRule) && (object.Equals((object) this._ObjectChanges, (object) ((ProcessModelTemplateMaint) obj)._ObjectChanges) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((ProcessModelTemplateMaint) obj)._ProcessObjectTemplateDetails))) && object.Equals((object) this._ValidChildTypes, (object) ((ProcessModelTemplateMaint) obj)._ValidChildTypes) && base.Equals(obj);
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

    public new RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
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

    public ProcessModelTemplateChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ProcessModelTemplateChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public ProcessModelTemplate ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ProcessModelTemplate) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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
