// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigHistoryDetail_Environment
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
  public class ESigHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("The reasons by which an Employee can sign off on an Electronic Signature requirement for another Employee.", "ESigCosignReason", false, false, true, "NamedObjectRef", 1050364, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_CosignReason")]
    protected Environment _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_VerificationMethod")]
    [Metadata("The type of verification that must occur to validate an Electronic Signature.\r\n1 = Password Verification\r\n2 = Badge Verification (future enhancement)\r\n3 = Biometric Verification (future enhancement)", "ESigVerificationMethodEnum", false, false, true, "Integer", 1050344, false, false, false, null)]
    protected Environment _VerificationMethod;
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1051895, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_ESigRequirement")]
    protected Environment _ESigRequirement;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_DisplayName")]
    protected new Environment _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1048866, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_Signer")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1050361, false, false, false, null)]
    protected Environment _Signer;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_CosignerRoleName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050340, false, false, false, null)]
    protected Environment _CosignerRoleName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052237, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_CosignReasonName")]
    protected Environment _CosignReasonName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050341, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_MeaningName")]
    protected Environment _MeaningName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050342, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_RoleName")]
    protected Environment _RoleName;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1050363, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_CosignerFullName")]
    protected Environment _CosignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_SignerFullName")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1050365, false, false, false, null)]
    protected Environment _SignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Environment_Cosigner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1050358, false, false, false, null)]
    protected Environment _Cosigner;

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

    public Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
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

    public Environment Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Signer));
      }
    }

    public Environment CosignerRoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRoleName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignerRoleName));
      }
    }

    public Environment CosignReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReasonName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignReasonName));
      }
    }

    public Environment MeaningName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MeaningName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MeaningName));
      }
    }

    public Environment RoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RoleName));
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

    public Environment Cosigner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cosigner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Cosigner));
      }
    }
  }
}
