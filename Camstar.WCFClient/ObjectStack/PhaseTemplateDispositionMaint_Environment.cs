// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseTemplateDispositionMaint_Environment
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
  public class PhaseTemplateDispositionMaint_Environment : PhaseTemplateMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_Environment_ObjectChanges")]
    [Metadata("Phase Template Disposition", "PhaseTemplateDispositionChanges", false, false, false, "PhaseTemplateDispositionChanges", 1048873, true, false, false, null)]
    protected PhaseTemplateDispositionChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_Environment_ObjectToChange")]
    [Metadata("The template for disposition phases which record the disposition of material associated with QualityObject records.", "PhaseTemplateDisposition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_Environment_ObjectListInquiry")]
    [Metadata("The template for disposition phases which record the disposition of material associated with QualityObject records.", "PhaseTemplateDisposition", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("The template for disposition phases which record the disposition of material associated with QualityObject records.", "PhaseTemplateDisposition", false, false, false, "PhaseTemplateDisposition", 1051576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseTemplateDispositionMaint_Environment_ProcessObjectTemplateDetails")]
    protected PhaseTemplateDisposition_Environment _ProcessObjectTemplateDetails;

    public PhaseTemplateDispositionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseTemplateDispositionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public PhaseTemplateDisposition_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PhaseTemplateDisposition_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
