// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BPSpecBizRuleTxnMapChanges_Environment
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
  public class BPSpecBizRuleTxnMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Environment_Event")]
    [Metadata("An enumeration that contains the event during which a business rule should fire.", "BPSpecBizRuleEventEnum", false, true, false, "Integer", 1051042, false, false, true, null)]
    protected Environment _Event;
    [Metadata("An enumeration that contains the event during which a business rule should fire.", "BPSpecBizRuleTxnMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Environment_ObjectToChange")]
    [Metadata("Contains a lisf ot business ruiles to fire at this spec.  It also includes the container txn that should do the firing and when in that txn the rule should fire.", "BPSpecBizRuleTxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Environment_BusinessRule")]
    [Metadata("Business Rule", "BusinessRule", false, true, false, "NamedObjectRef", 1051287, false, false, true, null)]
    protected Environment _BusinessRule;
    [Metadata("CDO Definition Id", "", false, true, false, "Integer", 1049647, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Environment_TxnToUse")]
    protected Environment _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "BPSpecBizRuleTxnMapChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public Environment Event
    {
      [param: In] set
      {
        this.PropertySet(nameof (Event), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Event));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment BusinessRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRule));
      }
    }

    public Environment TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnToUse));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
