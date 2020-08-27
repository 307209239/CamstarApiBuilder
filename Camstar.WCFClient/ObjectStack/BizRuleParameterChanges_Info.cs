// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleParameterChanges_Info
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
  public class BizRuleParameterChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Info_BusinessRuleHandler")]
    protected Info _BusinessRuleHandler;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Info_ValueExpression")]
    protected Info _ValueExpression;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Info_ParamSpec")]
    protected Info _ParamSpec;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Info_HandlerName")]
    protected Info _HandlerName;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_Info_ParamSpecName")]
    protected Info _ParamSpecName;

    public Info BusinessRuleHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleHandler), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRuleHandler));
      }
    }

    public Info ValueExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValueExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ValueExpression));
      }
    }

    public Info ParamSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParamSpec));
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

    public Info HandlerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HandlerName));
      }
    }

    public Info ParamSpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpecName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParamSpecName));
      }
    }
  }
}
