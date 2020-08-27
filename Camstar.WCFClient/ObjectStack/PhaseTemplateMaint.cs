// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplateMaint
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
  public class PhaseTemplateMaint : ProcessObjectTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_ObjectChanges")]
    protected PhaseTemplateChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_ProcessObjectTemplateDetails")]
    protected PhaseTemplate _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_ValidChildTypes")]
    protected new Primitive<string> _ValidChildTypes;

    public override bool Equals(object obj)
    {
      return obj is PhaseTemplateMaint && object.Equals((object) this._ObjectChanges, (object) ((PhaseTemplateMaint) obj)._ObjectChanges) && (object.Equals((object) this._ApprovalSheetTemplate, (object) ((PhaseTemplateMaint) obj)._ApprovalSheetTemplate) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PhaseTemplateMaint) obj)._ObjectListInquiry)) && (object.Equals((object) this._ObjectToChange, (object) ((PhaseTemplateMaint) obj)._ObjectToChange) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((PhaseTemplateMaint) obj)._ProcessObjectTemplateDetails) && object.Equals((object) this._ValidChildTypes, (object) ((PhaseTemplateMaint) obj)._ValidChildTypes)) && base.Equals(obj);
    }

    public PhaseTemplateChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseTemplateChanges) this.PropertyGet(nameof (ObjectChanges));
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

    public PhaseTemplate ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PhaseTemplate) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public new Primitive<string> ValidChildTypes
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
