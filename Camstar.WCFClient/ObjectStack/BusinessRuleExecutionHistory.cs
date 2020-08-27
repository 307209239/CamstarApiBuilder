// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleExecutionHistory
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
  public class BusinessRuleExecutionHistory : Camstar.WCF.ObjectStack.HistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_ContextDisplayName")]
    protected Primitive<string> _ContextDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_HistoryDetails")]
    protected BusinessRuleParameterValues[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Condition")]
    protected Primitive<string> _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_ExecutionTime")]
    protected Primitive<DateTime> _ExecutionTime;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Context")]
    protected BaseObjectRef _Context;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_ExecutionTimeGMT")]
    protected Primitive<DateTime> _ExecutionTimeGMT;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_ContextTypeName")]
    protected Primitive<string> _ContextTypeName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_BusinessRuleName")]
    protected Primitive<string> _BusinessRuleName;

    public override bool Equals(object obj)
    {
      return obj is BusinessRuleExecutionHistory && object.Equals((object) this._ContextDisplayName, (object) ((BusinessRuleExecutionHistory) obj)._ContextDisplayName) && (object.Equals((object) this._ExportImportKey, (object) ((BusinessRuleExecutionHistory) obj)._ExportImportKey) && this.CompareArrays((Array) this._HistoryDetails, (Array) ((BusinessRuleExecutionHistory) obj)._HistoryDetails)) && (object.Equals((object) this._Condition, (object) ((BusinessRuleExecutionHistory) obj)._Condition) && object.Equals((object) this._ExecutionTime, (object) ((BusinessRuleExecutionHistory) obj)._ExecutionTime) && (object.Equals((object) this._HistoryId, (object) ((BusinessRuleExecutionHistory) obj)._HistoryId) && object.Equals((object) this._Context, (object) ((BusinessRuleExecutionHistory) obj)._Context))) && (object.Equals((object) this._ExecutionTimeGMT, (object) ((BusinessRuleExecutionHistory) obj)._ExecutionTimeGMT) && object.Equals((object) this._ContextTypeName, (object) ((BusinessRuleExecutionHistory) obj)._ContextTypeName) && object.Equals((object) this._BusinessRuleName, (object) ((BusinessRuleExecutionHistory) obj)._BusinessRuleName)) && base.Equals(obj);
    }

    public Primitive<string> ContextDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContextDisplayName));
      }
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

    public BusinessRuleParameterValues[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (BusinessRuleParameterValues[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public Primitive<string> Condition
    {
      [param: In] set
      {
        this.PropertySet(nameof (Condition), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Condition));
      }
    }

    public Primitive<DateTime> ExecutionTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionTime), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExecutionTime));
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

    public BaseObjectRef Context
    {
      [param: In] set
      {
        this.PropertySet(nameof (Context), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Context));
      }
    }

    public Primitive<DateTime> ExecutionTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionTimeGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExecutionTimeGMT));
      }
    }

    public Primitive<string> ContextTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ContextTypeName));
      }
    }

    public Primitive<string> BusinessRuleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (BusinessRuleName));
      }
    }
  }
}
