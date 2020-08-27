// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigCaptureDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ESigPasswordCapture_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigCaptureDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Environment_Comments")]
    protected Environment _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Environment_CosignReason")]
    [Metadata("The reasons by which an Employee can sign off on an Electronic Signature requirement for another Employee.", "ESigCosignReason", false, false, false, "NamedObjectRef", 1050364, false, false, true, null)]
    protected Environment _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Environment_Cosigner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1050358, false, false, false, null)]
    protected Environment _Cosigner;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1050361, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Environment_Signer")]
    protected Environment _Signer;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1050365, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Environment_SignerFullName")]
    protected Environment _SignerFullName;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1050363, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Environment_CosignerFullName")]
    protected Environment _CosignerFullName;

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
  }
}
