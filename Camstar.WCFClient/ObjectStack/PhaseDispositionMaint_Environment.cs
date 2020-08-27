// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseDispositionMaint_Environment
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
  public class PhaseDispositionMaint_Environment : PhaseMaint_Environment
  {
    [Metadata("This phase is used to disposition material reported in the quality system.", "PhaseDisposition", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("PhaseDispositionChanges", "PhaseDispositionChanges", false, false, false, "PhaseDispositionChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_Environment_ObjectChanges")]
    protected PhaseDispositionChanges_Environment _ObjectChanges;
    [Metadata("The template for disposition phases which record the disposition of material associated with QualityObject records.", "PhaseTemplateDisposition", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_Environment_Template")]
    protected new Environment _Template;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionMaint_Environment_ObjectToChange")]
    [Metadata("This phase is used to disposition material reported in the quality system.", "PhaseDisposition", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
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

    public PhaseDispositionChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseDispositionChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
