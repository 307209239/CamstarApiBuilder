// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleMapChanges_Environment
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
  public class NumberingRuleMapChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Environment_NumberingRule")]
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, true, false, "NamedObjectRef", 1051465, false, false, true, null)]
    protected Environment _NumberingRule;
    [Metadata("A mapping from a QualityObject (Category) to a numbering rule that will be used to auto generate names.", "NumberingRuleMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("NumberingRuleCategory", "NumberingRuleCategoryEnum", false, true, false, "Integer", 1051206, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Environment_Category")]
    protected Environment _Category;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Environment_ListItemToChange")]
    [Metadata("Changes for mapping from a QualityObject (Category) to a numbering rule that will be used to auto generate names.", "NumberingRuleMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment NumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NumberingRule));
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

    public Environment Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Category));
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
