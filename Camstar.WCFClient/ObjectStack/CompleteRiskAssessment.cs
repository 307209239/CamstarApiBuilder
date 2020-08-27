// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRiskAssessment
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
  public class CompleteRiskAssessment : QualityTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Severity")]
    protected Primitive<int> _Severity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_RPN")]
    protected Primitive<int> _RPN;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Detection")]
    protected Primitive<int> _Detection;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_RiskAssessmentNotRequired")]
    protected Primitive<bool> _RiskAssessmentNotRequired;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessment_Occurrence")]
    protected Primitive<int> _Occurrence;

    public override bool Equals(object obj)
    {
      return obj is CompleteRiskAssessment && object.Equals((object) this._Severity, (object) ((CompleteRiskAssessment) obj)._Severity) && (object.Equals((object) this._RPN, (object) ((CompleteRiskAssessment) obj)._RPN) && object.Equals((object) this._Detection, (object) ((CompleteRiskAssessment) obj)._Detection)) && (object.Equals((object) this._RiskAssessmentNotRequired, (object) ((CompleteRiskAssessment) obj)._RiskAssessmentNotRequired) && object.Equals((object) this._Occurrence, (object) ((CompleteRiskAssessment) obj)._Occurrence)) && base.Equals(obj);
    }

    public Primitive<int> Severity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Severity), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Severity));
      }
    }

    public Primitive<int> RPN
    {
      [param: In] set
      {
        this.PropertySet(nameof (RPN), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RPN));
      }
    }

    public Primitive<int> Detection
    {
      [param: In] set
      {
        this.PropertySet(nameof (Detection), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Detection));
      }
    }

    public Primitive<bool> RiskAssessmentNotRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (RiskAssessmentNotRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RiskAssessmentNotRequired));
      }
    }

    public Primitive<int> Occurrence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occurrence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Occurrence));
      }
    }
  }
}
