// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleParameterValues_Environment
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
  public class BusinessRuleParameterValues_Environment : HistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("Business Rule Handler Data", "BusinessRuleHandlerData", false, false, true, "NamedSubentityRef", 1051230, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_Handler")]
    protected Environment _Handler;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_ParameterExpression")]
    [Metadata("InSite Unified Expression", "", false, false, true, "String", 1050882, false, false, false, null)]
    protected Environment _ParameterExpression;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_HandlerType")]
    [Metadata("Enumeration for the Biz Rule Handler Type:\r\n1 = Script\r\n2 = Service\r\n3 = CLF\r\n4 = Method", "BizRuleHandlerTypeEnum", false, false, true, "Integer", 1051232, false, false, false, null)]
    protected Environment _HandlerType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;
    [Metadata("Generic String", "", false, false, true, "String", 1051233, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_ParameterValue")]
    protected Environment _ParameterValue;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050881, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_ParameterName")]
    protected Environment _ParameterName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Environment_HandlerName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051231, false, false, false, null)]
    protected Environment _HandlerName;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Environment Handler
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Handler));
      }
    }

    public Environment ParameterExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterExpression), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParameterExpression));
      }
    }

    public Environment HandlerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HandlerType));
      }
    }

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Environment ParameterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParameterValue));
      }
    }

    public Environment ParameterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParameterName));
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
  }
}
