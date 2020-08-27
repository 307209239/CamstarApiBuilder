// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseMaint_Environment
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
  public class PhaseMaint_Environment : ProcessObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Environment_Template")]
    [Metadata("A template of a Phase.  A phase describes different stages of the process, e.g. Triage, Investigation, Implementation, Review.", "PhaseTemplate", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    protected new Environment _Template;
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "Phase", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Environment_ObjectChanges")]
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "PhaseChanges", false, false, false, "PhaseChanges", 1048873, true, false, false, null)]
    protected PhaseChanges_Environment _ObjectChanges;
    [Metadata("A phase describes the general stages that a Quality object goes through during processing.", "Phase", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseMaint_Environment_ValidChildTypes")]
    protected new Environment _ValidChildTypes;

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

    public PhaseChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PhaseChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
