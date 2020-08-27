// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RiskAssessment_Info
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
  public class RiskAssessment_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_RiskAssessmentNotRequired")]
    protected Info _RiskAssessmentNotRequired;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_Occurrence")]
    protected Info _Occurrence;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_Severity")]
    protected Info _Severity;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_Detection")]
    protected Info _Detection;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Info_RPN")]
    protected Info _RPN;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
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

    public Info RiskAssessmentNotRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (RiskAssessmentNotRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RiskAssessmentNotRequired));
      }
    }

    public Info Occurrence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occurrence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Occurrence));
      }
    }

    public Info Severity
    {
      [param: In] set
      {
        this.PropertySet(nameof (Severity), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Severity));
      }
    }

    public Info Detection
    {
      [param: In] set
      {
        this.PropertySet(nameof (Detection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Detection));
      }
    }

    public Info RPN
    {
      [param: In] set
      {
        this.PropertySet(nameof (RPN), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RPN));
      }
    }
  }
}
