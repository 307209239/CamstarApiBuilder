// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateMaint_Environment
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
  public class PlanTemplateMaint_Environment : ProcessObjectTemplateMaint_Environment
  {
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplate", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_Environment_ObjectToChange")]
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_Environment_ProcessObjectTemplateDetails")]
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplate", false, false, false, "PlanTemplate", 1051576, false, false, false, null)]
    protected PlanTemplate_Environment _ProcessObjectTemplateDetails;
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplateChanges", false, false, false, "PlanTemplateChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_Environment_ObjectChanges")]
    protected PlanTemplateChanges_Environment _ObjectChanges;
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051618, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_Environment_ApprovalSheetTemplate")]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateMaint_Environment_ValidChildTypes")]
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    protected new Environment _ValidChildTypes;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public PlanTemplate_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PlanTemplate_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }

    public PlanTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment ApprovalSheetTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetTemplate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApprovalSheetTemplate));
      }
    }

    public new Environment ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
