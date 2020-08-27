// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleParameterValues
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
  public class BusinessRuleParameterValues : HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Handler")]
    protected NamedSubentityRef _Handler;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_ParameterExpression")]
    protected Primitive<string> _ParameterExpression;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_HandlerType")]
    protected Enumeration<BizRuleHandlerTypeEnum, int> _HandlerType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_ParameterValue")]
    protected Primitive<string> _ParameterValue;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_ParameterName")]
    protected Primitive<string> _ParameterName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_HandlerName")]
    protected Primitive<string> _HandlerName;

    public override bool Equals(object obj)
    {
      return obj is BusinessRuleParameterValues && object.Equals((object) this._ExportImportKey, (object) ((BusinessRuleParameterValues) obj)._ExportImportKey) && (object.Equals((object) this._Handler, (object) ((BusinessRuleParameterValues) obj)._Handler) && object.Equals((object) this._ParameterExpression, (object) ((BusinessRuleParameterValues) obj)._ParameterExpression)) && (object.Equals((object) this._HandlerType, (object) ((BusinessRuleParameterValues) obj)._HandlerType) && object.Equals((object) this._HistoryId, (object) ((BusinessRuleParameterValues) obj)._HistoryId) && (object.Equals((object) this._ParameterValue, (object) ((BusinessRuleParameterValues) obj)._ParameterValue) && object.Equals((object) this._ParameterName, (object) ((BusinessRuleParameterValues) obj)._ParameterName))) && object.Equals((object) this._HandlerName, (object) ((BusinessRuleParameterValues) obj)._HandlerName) && base.Equals(obj);
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

    public NamedSubentityRef Handler
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handler), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Handler));
      }
    }

    public Primitive<string> ParameterExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterExpression), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParameterExpression));
      }
    }

    public Enumeration<BizRuleHandlerTypeEnum, int> HandlerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerType), (object) value);
      }
      get
      {
        return (Enumeration<BizRuleHandlerTypeEnum, int>) this.PropertyGet(nameof (HandlerType));
      }
    }

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<string> ParameterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParameterValue));
      }
    }

    public Primitive<string> ParameterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParameterName));
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
  }
}
