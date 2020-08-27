// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateMaint
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
  public class PlanTemplateMaint : ProcessObjectTemplateMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_ProcessObjectTemplateDetails")]
    protected PlanTemplate _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_ObjectChanges")]
    protected PlanTemplateChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_ApprovalSheetTemplate")]
    protected NamedObjectRef _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_ValidChildTypes")]
    protected new Primitive<string> _ValidChildTypes;

    public override bool Equals(object obj)
    {
      return obj is PlanTemplateMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((PlanTemplateMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectToChange, (object) ((PlanTemplateMaint) obj)._ObjectToChange) && object.Equals((object) this._ProcessObjectTemplateDetails, (object) ((PlanTemplateMaint) obj)._ProcessObjectTemplateDetails)) && (object.Equals((object) this._ObjectChanges, (object) ((PlanTemplateMaint) obj)._ObjectChanges) && object.Equals((object) this._ApprovalSheetTemplate, (object) ((PlanTemplateMaint) obj)._ApprovalSheetTemplate) && object.Equals((object) this._ValidChildTypes, (object) ((PlanTemplateMaint) obj)._ValidChildTypes)) && base.Equals(obj);
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

    public PlanTemplate ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PlanTemplate) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public PlanTemplateChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanTemplateChanges) this.PropertyGet(nameof (ObjectChanges));
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
