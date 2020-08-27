// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleParameterChanges
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
  public class BizRuleParameterChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_BusinessRuleHandler")]
    protected NamedObjectRef _BusinessRuleHandler;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_ValueExpression")]
    protected Primitive<string> _ValueExpression;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_ParamSpec")]
    protected NamedSubentityRef _ParamSpec;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_HandlerName")]
    protected Primitive<string> _HandlerName;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameterChanges_ParamSpecName")]
    protected Primitive<string> _ParamSpecName;

    public override bool Equals(object obj)
    {
      return obj is BizRuleParameterChanges && object.Equals((object) this._BusinessRuleHandler, (object) ((BizRuleParameterChanges) obj)._BusinessRuleHandler) && (object.Equals((object) this._ValueExpression, (object) ((BizRuleParameterChanges) obj)._ValueExpression) && object.Equals((object) this._ParamSpec, (object) ((BizRuleParameterChanges) obj)._ParamSpec)) && (object.Equals((object) this._IsFrozen, (object) ((BizRuleParameterChanges) obj)._IsFrozen) && object.Equals((object) this._HandlerName, (object) ((BizRuleParameterChanges) obj)._HandlerName) && object.Equals((object) this._ParamSpecName, (object) ((BizRuleParameterChanges) obj)._ParamSpecName)) && base.Equals(obj);
    }

    public NamedObjectRef BusinessRuleHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleHandler), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (BusinessRuleHandler));
      }
    }

    public Primitive<string> ValueExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValueExpression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ValueExpression));
      }
    }

    public NamedSubentityRef ParamSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpec), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ParamSpec));
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

    public Primitive<string> HandlerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HandlerName));
      }
    }

    public Primitive<string> ParamSpecName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamSpecName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParamSpecName));
      }
    }
  }
}
