// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigHistoryDetail_Environment
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
  public class ModelingESigHistoryDetail_Environment : Subentity_Environment
  {
    [Metadata("The reasons by which an Employee can sign off on an Electronic Signature requirement for another Employee.", "ESigCosignReason", false, false, true, "NamedObjectRef", 1050364, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_CosignReason")]
    protected Environment _CosignReason;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_SignerRole")]
    protected Environment _SignerRole;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050340, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_CosignerRole")]
    protected Environment _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_Meaning")]
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaning", false, false, true, "NamedObjectRef", 1050341, false, false, false, null)]
    protected Environment _Meaning;
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("The type of verification that must occur to validate an Electronic Signature.\r\n1 = Password Verification\r\n2 = Badge Verification (future enhancement)\r\n3 = Biometric Verification (future enhancement)", "ESigVerificationMethodEnum", false, false, true, "Integer", 1050344, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_VerificationMethod")]
    protected Environment _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1050363, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_CosignerFullName")]
    protected Environment _CosignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Environment_SignerFullName")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1050365, false, false, false, null)]
    protected Environment _SignerFullName;

    public Environment CosignReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignReason));
      }
    }

    public Environment SignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SignerRole));
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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Environment CosignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerFullName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignerFullName));
      }
    }

    public Environment SignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerFullName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SignerFullName));
      }
    }
  }
}
