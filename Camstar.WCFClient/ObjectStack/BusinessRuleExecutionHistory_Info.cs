// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleExecutionHistory_Info
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
  public class BusinessRuleExecutionHistory_Info : HistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_ContextDisplayName")]
    protected Info _ContextDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_HistoryDetails")]
    protected BusinessRuleParameterValues_Info _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_Condition")]
    protected Info _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_ExecutionTime")]
    protected Info _ExecutionTime;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_Context")]
    protected Info _Context;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_ExecutionTimeGMT")]
    protected Info _ExecutionTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_ContextTypeName")]
    protected Info _ContextTypeName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Info_BusinessRuleName")]
    protected Info _BusinessRuleName;

    public Info ContextDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContextDisplayName));
      }
    }

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

    public BusinessRuleParameterValues_Info HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (BusinessRuleParameterValues_Info) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Info Condition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Condition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Condition));
      }
    }

    public Info ExecutionTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionTime), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionTime));
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

    public Info Context
    {
      [param: In] set
      {
        this.PropertySet(nameof (Context), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Context));
      }
    }

    public Info ExecutionTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionTimeGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExecutionTimeGMT));
      }
    }

    public Info ContextTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContextTypeName));
      }
    }

    public Info BusinessRuleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BusinessRuleName));
      }
    }
  }
}
