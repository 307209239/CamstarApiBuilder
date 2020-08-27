// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RiskAssessment_Environment
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
  public class RiskAssessment_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052470, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_RiskAssessmentNotRequired")]
    protected Environment _RiskAssessmentNotRequired;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_Occurrence")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052469, false, false, false, null)]
    protected Environment _Occurrence;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_Severity")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052153, false, false, false, null)]
    protected Environment _Severity;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052528, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_Detection")]
    protected Environment _Detection;
    [DataMember(EmitDefaultValue = false, Name = "RiskAssessment_Environment_RPN")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052529, false, false, false, null)]
    protected Environment _RPN;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
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
