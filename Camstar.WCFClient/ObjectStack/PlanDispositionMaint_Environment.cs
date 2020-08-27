// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanDispositionMaint_Environment
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
  public class PlanDispositionMaint_Environment : PlanMaint_Environment
  {
    [Metadata("This plan is used to disposition material reported in the quality system.", "PlanDisposition", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionMaint_Environment_Template")]
    [Metadata("The template for disposition plans which record the disposition of material associated with QualityObject records.", "PlanTemplateDisposition", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    protected new Environment _Template;
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionMaint_Environment_ObjectChanges")]
    [Metadata("Plan Disposition Changes", "PlanDispositionChanges", false, false, false, "PlanDispositionChanges", 1048873, true, false, false, null)]
    protected PlanDispositionChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionMaint_Environment_ObjectToChange")]
    [Metadata("This plan is used to disposition material reported in the quality system.", "PlanDisposition", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;

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

    public new Environment Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Template));
      }
    }

    public PlanDispositionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanDispositionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
