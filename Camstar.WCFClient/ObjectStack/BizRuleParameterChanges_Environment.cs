// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleParameterChanges_Environment
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
  public class BizRuleParameterChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Environment_BusinessRuleHandler")]
    [Metadata("Business Rule Handler", "BusinessRuleHandler", false, false, true, "NamedObjectRef", 1051887, false, false, false, null)]
    protected Environment _BusinessRuleHandler;
    [Metadata("InSite Unified Expression", "", false, false, false, "String", 1049630, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Environment_ValueExpression")]
    protected Environment _ValueExpression;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Environment_ParamSpec")]
    [Metadata("Business Rule Handler Parameter", "BizRuleHandlerParameter", false, false, false, "NamedSubentityRef", 1051197, false, false, true, null)]
    protected Environment _ParamSpec;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Environment_HandlerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected Environment _HandlerName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Environment_ParamSpecName")]
    protected Environment _ParamSpecName;

    public Environment BusinessRuleHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleHandler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRuleHandler));
      }
    }

    public Environment ValueExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValueExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValueExpression));
      }
    }

    public Environment ParamSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpec), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParamSpec));
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

    public Environment HandlerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HandlerName));
      }
    }

    public Environment ParamSpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpecName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParamSpecName));
      }
    }
  }
}
