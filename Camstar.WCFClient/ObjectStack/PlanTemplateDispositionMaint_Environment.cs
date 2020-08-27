// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanTemplateDispositionMaint_Environment
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
  public class PlanTemplateDispositionMaint_Environment : PlanTemplateMaint_Environment
  {
    [Metadata("The template for disposition plans which record the disposition of material associated with QualityObject records.", "PlanTemplateDisposition", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("The template for disposition plans which record the disposition of material associated with QualityObject records.", "PlanTemplateDispositionChanges", false, false, false, "PlanTemplateDispositionChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_Environment_ObjectChanges")]
    protected PlanTemplateDispositionChanges_Environment _ObjectChanges;
    [Metadata("The template for disposition plans which record the disposition of material associated with QualityObject records.", "PlanTemplateDisposition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanTemplateDispositionMaint_Environment_ProcessObjectTemplateDetails")]
    [Metadata("The template for disposition plans which record the disposition of material associated with QualityObject records.", "PlanTemplateDisposition", false, false, false, "PlanTemplateDisposition", 1051576, false, false, false, null)]
    protected PlanTemplateDisposition_Environment _ProcessObjectTemplateDetails;

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

    public PlanTemplateDispositionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanTemplateDispositionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public PlanTemplateDisposition_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (PlanTemplateDisposition_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
