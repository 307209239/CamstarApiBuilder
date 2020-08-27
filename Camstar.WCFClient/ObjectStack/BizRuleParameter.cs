// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BizRuleParameter
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
  public class BizRuleParameter : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_BusinessRuleHandler")]
    protected NamedObjectRef _BusinessRuleHandler;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_ValueExpression")]
    protected Primitive<string> _ValueExpression;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_ParamSpec")]
    protected NamedSubentityRef _ParamSpec;
    [DataMember(EmitDefaultValue = false, Name = "BizRuleParameter_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is BizRuleParameter && object.Equals((object) this._ExportImportKey, (object) ((BizRuleParameter) obj)._ExportImportKey) && (object.Equals((object) this._BusinessRuleHandler, (object) ((BizRuleParameter) obj)._BusinessRuleHandler) && object.Equals((object) this._ValueExpression, (object) ((BizRuleParameter) obj)._ValueExpression)) && (object.Equals((object) this._ParamSpec, (object) ((BizRuleParameter) obj)._ParamSpec) && object.Equals((object) this._IsFrozen, (object) ((BizRuleParameter) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
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
  }
}
