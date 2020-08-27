// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPSpecBizRuleTxnMapChanges
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
  public class BPSpecBizRuleTxnMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Event")]
    protected Enumeration<BPSpecBizRuleEventEnum, int> _Event;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_BusinessRule")]
    protected NamedObjectRef _BusinessRule;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_TxnToUse")]
    protected Primitive<int> _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is BPSpecBizRuleTxnMapChanges && object.Equals((object) this._Event, (object) ((BPSpecBizRuleTxnMapChanges) obj)._Event) && (object.Equals((object) this._ListItemToChange, (object) ((BPSpecBizRuleTxnMapChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((BPSpecBizRuleTxnMapChanges) obj)._ObjectToChange)) && (object.Equals((object) this._BusinessRule, (object) ((BPSpecBizRuleTxnMapChanges) obj)._BusinessRule) && object.Equals((object) this._TxnToUse, (object) ((BPSpecBizRuleTxnMapChanges) obj)._TxnToUse) && object.Equals((object) this._IsFrozen, (object) ((BPSpecBizRuleTxnMapChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public Enumeration<BPSpecBizRuleEventEnum, int> Event
    {
      [param: In] set
      {
        this.PropertySet(nameof (Event), (object) value);
      }
      get
      {
        return (Enumeration<BPSpecBizRuleEventEnum, int>) this.PropertyGet(nameof (Event));
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

    public NamedObjectRef BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Primitive<int> TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnToUse));
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
