// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleChanges_Info
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
  public class NumberingRuleChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_Suffix")]
    protected Info _Suffix;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_Prefix")]
    protected Info _Prefix;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_NumberingRuleType")]
    protected Info _NumberingRuleType;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_SequenceLength")]
    protected Info _SequenceLength;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_LastAssignedSequence")]
    protected Info _LastAssignedSequence;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleChanges_Info_Name")]
    protected new Info _Name;

    public Info Suffix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Suffix), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Suffix));
      }
    }

    public Info Prefix
    {
      [param: In] set
      {
        this.PropertySet(nameof (Prefix), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Prefix));
      }
    }

    public Info NumberingRuleType
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NumberingRuleType));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info SequenceLength
    {
      [param: In] set
      {
        this.PropertySet(nameof (SequenceLength), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SequenceLength));
      }
    }

    public Info LastAssignedSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastAssignedSequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastAssignedSequence));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
