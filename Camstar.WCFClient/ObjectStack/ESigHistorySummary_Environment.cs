// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigHistorySummary_Environment
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
  public class ESigHistorySummary_Environment : ServiceHistorySummary_Environment
  {
    [Metadata("The detail history for the collection of ESignatures.", "ESigHistoryDetail", false, false, false, "ESigHistoryDetail", 1049096, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_HistoryDetails")]
    protected ESigHistoryDetail_Environment _HistoryDetails;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_DisplayName")]
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_CosignerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050340, false, false, false, null)]
    protected Environment _CosignerRole;
    [Metadata("The detailed requirements for an Electronic Signature requirement.  Each detail will require a unique signature when the requirement is implemented in a service.", "ESigReqDetail", false, false, true, "NamedSubentityRef", 1050360, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_ESigReqDetail")]
    protected Environment _ESigReqDetail;
    [Metadata("The type of verification that must occur to validate an Electronic Signature.\r\n1 = Password Verification\r\n2 = Badge Verification (future enhancement)\r\n3 = Biometric Verification (future enhancement)", "ESigVerificationMethodEnum", false, false, true, "Integer", 1050344, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_VerificationMethod")]
    protected Environment _VerificationMethod;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_Role")]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_Meaning")]
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaning", false, false, true, "NamedObjectRef", 1050341, false, false, false, null)]
    protected Environment _Meaning;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1050343, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Environment_SignatureCount")]
    protected Environment _SignatureCount;

    public ESigHistoryDetail_Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ESigHistoryDetail_Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public new Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public Environment CosignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignerRole));
      }
    }

    public Environment ESigReqDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetail), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigReqDetail));
      }
    }

    public Environment VerificationMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (VerificationMethod), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VerificationMethod));
      }
    }

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment Meaning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Meaning), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Meaning));
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

    public Environment SignatureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignatureCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SignatureCount));
      }
    }
  }
}
