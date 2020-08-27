// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleChanges_Environment
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
  public class NumberingRuleChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_Suffix")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051459, false, false, false, null)]
    protected Environment _Suffix;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_Prefix")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051457, false, false, false, null)]
    protected Environment _Prefix;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_NumberingRuleType")]
    [Metadata("Enumeration for the Numbering Rule Type:\r\n0 = AllowSkipping\r\n1 = DisallowSkipping", "NumberingRuleTypeEnum", false, true, false, "Integer", 1051903, false, false, true, null)]
    protected Environment _NumberingRuleType;
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_SequenceLength")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1051458, false, false, false, null)]
    protected Environment _SequenceLength;
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1051463, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_LastAssignedSequence")]
    protected Environment _LastAssignedSequence;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051469, false, false, false, null)]
    protected new Environment _Name;

    public Environment Suffix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Suffix), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Suffix));
      }
    }

    public Environment Prefix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prefix), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Prefix));
      }
    }

    public Environment NumberingRuleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NumberingRuleType));
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

    public Environment SequenceLength
    {
      [param: In] set
      {
        this.PropertySet(nameof (SequenceLength), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SequenceLength));
      }
    }

    public Environment LastAssignedSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastAssignedSequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastAssignedSequence));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
