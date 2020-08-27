// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRiskAssessmentHistory_Environment
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
  public class CompleteRiskAssessmentHistory_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052153, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_Severity")]
    protected Environment _Severity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_Detection")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052528, false, false, false, null)]
    protected Environment _Detection;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_Occurrence")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052469, false, false, false, null)]
    protected Environment _Occurrence;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_RiskAssessmentNotRequired")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052470, false, false, false, "0")]
    protected Environment _RiskAssessmentNotRequired;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Environment_RPN")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052529, false, false, false, null)]
    protected Environment _RPN;

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

    public Environment Severity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Severity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Severity));
      }
    }

    public Environment Detection
    {
      [param: In] set
      {
        this.PropertySet(nameof (Detection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Detection));
      }
    }

    public Environment Occurrence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occurrence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Occurrence));
      }
    }

    public Environment RiskAssessmentNotRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (RiskAssessmentNotRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RiskAssessmentNotRequired));
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

    public Environment RPN
    {
      [param: In] set
      {
        this.PropertySet(nameof (RPN), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RPN));
      }
    }
  }
}
