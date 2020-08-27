// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplateMaint_Environment
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
  public class PhaseTemplateMaint_Environment : ProcessObjectTemplateMaint_Environment
  {
    [Metadata("A phase describes different stages of the process, e.g. Triage, Investigation, Implementation, Review.", "PhaseTemplateChanges", false, false, false, "PhaseTemplateChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Environment_ObjectChanges")]
    protected PhaseTemplateChanges_Environment _ObjectChanges;
    [Metadata("An approval sheet is used to collect signatures of approvers who are making decisions regarding the status of an object.  The template is used to pre-define the sheets that will be attached to the object.", "ApprovalSheetTemplate", false, false, false, "NamedObjectRef", 1051618, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Environment_ApprovalSheetTemplate")]
    protected Environment _ApprovalSheetTemplate;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Environment_ObjectListInquiry")]
    [Metadata("A template of a Phase.  A phase describes different stages of the process, e.g. Triage, Investigation, Implementation, Review.", "PhaseTemplate", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Environment_ObjectToChange")]
    [Metadata("A template of a Phase.  A phase describes different stages of the process, e.g. Triage, Investigation, Implementation, Review.", "PhaseTemplate", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("A template of a Phase.  A phase describes different stages of the process, e.g. Triage, Investigation, Implementation, Review.", "PhaseTemplate", false, false, false, "PhaseTemplate", 1051576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Environment_ProcessObjectTemplateDetails")]
    protected PhaseTemplate_Environment _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateMaint_Environment_ValidChildTypes")]
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    protected new Environment _ValidChildTypes;

    public PhaseTemplateChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseTemplateChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public PhaseTemplate_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PhaseTemplate_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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
