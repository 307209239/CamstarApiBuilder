// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleDataChanges_Environment
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
  public class BusinessRuleDataChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_Condition")]
    [Metadata("InSite Unified Expression", "", false, false, false, "String", 1051193, false, false, false, null)]
    protected Environment _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_BusinessRuleToLoad")]
    [Metadata("Business Rule", "BusinessRule", false, false, false, "NamedObjectRef", 1051287, false, false, true, null)]
    protected Environment _BusinessRuleToLoad;
    [Metadata("Business Rule Data", "BusinessRuleData", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Business Rule Parameter Changes", "BizRuleParameterChanges", false, false, false, "BizRuleParameterChanges", 1050947, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_Parameters")]
    protected BizRuleParameterChanges_Environment _Parameters;
    [Metadata("Business Rule Handler", "BusinessRuleHandler", false, false, false, "NamedObjectRef", 1051230, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_Handlers")]
    protected Environment _Handlers;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_ListItemToChange")]
    [Metadata("Business Rule Data Changes", "BusinessRuleDataChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_Scope")]
    [Metadata("Enumeration for the Biz Rule Scope:\r\n0 = Global\r\n1 = Local", "BizRuleScopeEnum", false, true, false, "Integer", 1051201, false, false, true, null)]
    protected Environment _Scope;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_ContextType")]
    [Metadata("Enumeration for the Biz Rule Holder Type:\r\nProcess\r\nPhase\r\nPlan\r\nActivity", "BizRuleHolderTypeEnum", false, true, false, "Integer", 1049631, false, false, true, null)]
    protected Environment _ContextType;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051191, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_AlwaysExecute")]
    protected Environment _AlwaysExecute;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleDataChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    protected new Environment _Name;

    public Environment Condition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Condition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Condition));
      }
    }

    public Environment BusinessRuleToLoad
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleToLoad), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRuleToLoad));
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

    public BizRuleParameterChanges_Environment Parameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parameters), (object) value);
      }
      get
      {
        return (BizRuleParameterChanges_Environment) this.PropertyGet(nameof (Parameters));
      }
    }

    public Environment Handlers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handlers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Handlers));
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

    public Environment Scope
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scope), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Scope));
      }
    }

    public Environment ContextType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContextType));
      }
    }

    public Environment AlwaysExecute
    {
      [param: In] set
      {
        this.PropertySet(nameof (AlwaysExecute), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AlwaysExecute));
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
