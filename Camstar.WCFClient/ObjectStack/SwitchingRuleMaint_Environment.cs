// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SwitchingRuleMaint_Environment
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
  public class SwitchingRuleMaint_Environment : RevisionedObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_Environment_ObjectListInquiry")]
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRuleBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRuleBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_Environment_ObjectToChange")]
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRule", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SwitchingRuleMaint_Environment_ObjectChanges")]
    [Metadata("Object used to define the Switching Rules for an AQL Sampling plan.  Defines the rule for switching between inspection levels.", "SwitchingRuleChanges", false, false, false, "SwitchingRuleChanges", 1048873, true, false, false, null)]
    protected SwitchingRuleChanges_Environment _ObjectChanges;

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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public SwitchingRuleChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SwitchingRuleChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
