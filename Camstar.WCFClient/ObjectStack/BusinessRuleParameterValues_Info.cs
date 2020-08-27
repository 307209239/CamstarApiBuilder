// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleParameterValues_Info
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
  public class BusinessRuleParameterValues_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_Handler")]
    protected Info _Handler;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_ParameterExpression")]
    protected Info _ParameterExpression;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_HandlerType")]
    protected Info _HandlerType;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_ParameterValue")]
    protected Info _ParameterValue;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_ParameterName")]
    protected Info _ParameterName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleParameterValues_Info_HandlerName")]
    protected Info _HandlerName;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Handler
    {
      [param: In] set
      {
        this.PropertySet(nameof (Handler), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Handler));
      }
    }

    public Info ParameterExpression
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterExpression), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParameterExpression));
      }
    }

    public Info HandlerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (HandlerType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HandlerType));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info ParameterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParameterValue));
      }
    }

    public Info ParameterName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParameterName));
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
  }
}
