// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompleteRiskAssessmentHistory
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
  public class CompleteRiskAssessmentHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Severity")]
    protected Primitive<int> _Severity;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Detection")]
    protected Primitive<int> _Detection;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_Occurrence")]
    protected Primitive<int> _Occurrence;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_RiskAssessmentNotRequired")]
    protected Primitive<bool> _RiskAssessmentNotRequired;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "CompleteRiskAssessmentHistory_RPN")]
    protected Primitive<int> _RPN;

    public override bool Equals(object obj)
    {
      return obj is CompleteRiskAssessmentHistory && object.Equals((object) this._ExportImportKey, (object) ((CompleteRiskAssessmentHistory) obj)._ExportImportKey) && (object.Equals((object) this._Severity, (object) ((CompleteRiskAssessmentHistory) obj)._Severity) && object.Equals((object) this._Detection, (object) ((CompleteRiskAssessmentHistory) obj)._Detection)) && (object.Equals((object) this._Occurrence, (object) ((CompleteRiskAssessmentHistory) obj)._Occurrence) && object.Equals((object) this._RiskAssessmentNotRequired, (object) ((CompleteRiskAssessmentHistory) obj)._RiskAssessmentNotRequired) && (object.Equals((object) this._HistoryId, (object) ((CompleteRiskAssessmentHistory) obj)._HistoryId) && object.Equals((object) this._RPN, (object) ((CompleteRiskAssessmentHistory) obj)._RPN))) && base.Equals(obj);
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
  }
}
