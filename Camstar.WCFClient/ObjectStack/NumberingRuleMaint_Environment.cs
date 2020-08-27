// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleMaint_Environment
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
  public class NumberingRuleMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_Environment_ObjectListInquiry")]
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_Environment_ObjectChanges")]
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRuleChanges", false, false, false, "NumberingRuleChanges", 1048873, true, false, false, null)]
    protected NumberingRuleChanges_Environment _ObjectChanges;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051464, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_Environment_ResetLastAssignedSequence")]
    protected Environment _ResetLastAssignedSequence;

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

    public NumberingRuleChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NumberingRuleChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment ResetLastAssignedSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetLastAssignedSequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ResetLastAssignedSequence));
      }
    }
  }
}
