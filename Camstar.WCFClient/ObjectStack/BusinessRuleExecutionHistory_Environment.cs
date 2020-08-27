// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BusinessRuleExecutionHistory_Environment
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
  public class BusinessRuleExecutionHistory_Environment : HistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_ContextDisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1051235, false, false, false, null)]
    protected Environment _ContextDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_HistoryDetails")]
    [Metadata("Business Rule Parameter Values", "BusinessRuleParameterValues", false, false, true, "BusinessRuleParameterValues", 1051416, false, true, false, null)]
    protected BusinessRuleParameterValues_Environment _HistoryDetails;
    [Metadata("InSite Unified Expression", "", false, false, true, "String", 1051193, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_Condition")]
    protected Environment _Condition;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_ExecutionTime")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050952, false, false, false, null)]
    protected Environment _ExecutionTime;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_Context")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1051234, false, false, false, null)]
    protected Environment _Context;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_ExecutionTimeGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1050953, false, false, false, null)]
    protected Environment _ExecutionTimeGMT;
    [Metadata("Name of the CDO Definition for this instance", "", false, false, true, "String", 1051415, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_ContextTypeName")]
    protected Environment _ContextTypeName;
    [DataMember(EmitDefaultValue = false, Name = "BusinessRuleExecutionHistory_Environment_BusinessRuleName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1051186, false, false, false, null)]
    protected Environment _BusinessRuleName;

    public Environment ContextDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContextDisplayName));
      }
    }

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

    public BusinessRuleParameterValues_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (BusinessRuleParameterValues_Environment) this.PropertyGet(nameof (HistoryDetails));
      }
    }

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

    public Environment ExecutionTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionTime));
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

    public Environment Context
    {
      [param: In] set
      {
        this.PropertySet(nameof (Context), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Context));
      }
    }

    public Environment ExecutionTimeGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExecutionTimeGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExecutionTimeGMT));
      }
    }

    public Environment ContextTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContextTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContextTypeName));
      }
    }

    public Environment BusinessRuleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (BusinessRuleName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BusinessRuleName));
      }
    }
  }
}
