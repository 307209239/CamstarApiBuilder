// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRiskAssessment_Environment
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
  public class CompleteRiskAssessment_Environment : QualityTxn_Environment
  {
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052153, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Environment_Severity")]
    protected Environment _Severity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Environment_RPN")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1052529, false, false, false, null)]
    protected Environment _RPN;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Environment_Detection")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052528, false, false, false, null)]
    protected Environment _Detection;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052470, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Environment_RiskAssessmentNotRequired")]
    protected Environment _RiskAssessmentNotRequired;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052469, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Environment_Occurrence")]
    protected Environment _Occurrence;

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
  }
}
