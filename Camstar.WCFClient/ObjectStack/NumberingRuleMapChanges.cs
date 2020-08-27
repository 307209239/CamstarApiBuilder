// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleMapChanges
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
  public class NumberingRuleMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_NumberingRule")]
    protected NamedObjectRef _NumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Category")]
    protected Enumeration<NumberingRuleCategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is NumberingRuleMapChanges && object.Equals((object) this._NumberingRule, (object) ((NumberingRuleMapChanges) obj)._NumberingRule) && (object.Equals((object) this._ObjectToChange, (object) ((NumberingRuleMapChanges) obj)._ObjectToChange) && object.Equals((object) this._Category, (object) ((NumberingRuleMapChanges) obj)._Category)) && (object.Equals((object) this._ListItemToChange, (object) ((NumberingRuleMapChanges) obj)._ListItemToChange) && object.Equals((object) this._IsFrozen, (object) ((NumberingRuleMapChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public NamedObjectRef NumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NumberingRule));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Enumeration<NumberingRuleCategoryEnum, int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Enumeration<NumberingRuleCategoryEnum, int>) this.PropertyGet(nameof (Category));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
