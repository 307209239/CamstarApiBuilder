// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleChanges
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
  public class NumberingRuleChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Suffix")]
    protected Primitive<string> _Suffix;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Prefix")]
    protected Primitive<string> _Prefix;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_NumberingRuleType")]
    protected Enumeration<NumberingRuleTypeEnum, int> _NumberingRuleType;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_SequenceLength")]
    protected Primitive<int> _SequenceLength;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_LastAssignedSequence")]
    protected Primitive<int> _LastAssignedSequence;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is NumberingRuleChanges && object.Equals((object) this._Suffix, (object) ((NumberingRuleChanges) obj)._Suffix) && (object.Equals((object) this._Prefix, (object) ((NumberingRuleChanges) obj)._Prefix) && object.Equals((object) this._NumberingRuleType, (object) ((NumberingRuleChanges) obj)._NumberingRuleType)) && (object.Equals((object) this._ObjectToChange, (object) ((NumberingRuleChanges) obj)._ObjectToChange) && object.Equals((object) this._SequenceLength, (object) ((NumberingRuleChanges) obj)._SequenceLength) && (object.Equals((object) this._LastAssignedSequence, (object) ((NumberingRuleChanges) obj)._LastAssignedSequence) && object.Equals((object) this._Name, (object) ((NumberingRuleChanges) obj)._Name))) && base.Equals(obj);
    }

    public Primitive<string> Suffix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Suffix), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Suffix));
      }
    }

    public Primitive<string> Prefix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prefix), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Prefix));
      }
    }

    public Enumeration<NumberingRuleTypeEnum, int> NumberingRuleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleType), (object) value);
      }
      get
      {
        return (Enumeration<NumberingRuleTypeEnum, int>) this.PropertyGet(nameof (NumberingRuleType));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<int> SequenceLength
    {
      [param: In] set
      {
        this.PropertySet(nameof (SequenceLength), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SequenceLength));
      }
    }

    public Primitive<int> LastAssignedSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastAssignedSequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LastAssignedSequence));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
