// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleMaint
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
  public class NumberingRuleMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_ObjectChanges")]
    protected NumberingRuleChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMaint_ResetLastAssignedSequence")]
    protected Primitive<bool> _ResetLastAssignedSequence;

    public override bool Equals(object obj)
    {
      return obj is NumberingRuleMaint && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((NumberingRuleMaint) obj)._ObjectListInquiry) && (object.Equals((object) this._ObjectToChange, (object) ((NumberingRuleMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((NumberingRuleMaint) obj)._ObjectChanges)) && object.Equals((object) this._ResetLastAssignedSequence, (object) ((NumberingRuleMaint) obj)._ResetLastAssignedSequence) && base.Equals(obj);
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
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

    public NumberingRuleChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NumberingRuleChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<bool> ResetLastAssignedSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResetLastAssignedSequence), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ResetLastAssignedSequence));
      }
    }
  }
}
