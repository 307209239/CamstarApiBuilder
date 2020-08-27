// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NumberingRuleMapChanges_Info
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
  public class NumberingRuleMapChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Info_NumberingRule")]
    protected Info _NumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Info_Category")]
    protected Info _Category;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "NumberingRuleMapChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info NumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NumberingRule));
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

    public Info Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Category));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
