// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqDetailChanges_Environment
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
  public class ESigReqDetailChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_ObjectToChange")]
    [Metadata("The detailed requirements for an Electronic Signature requirement.  Each detail will require a unique signature when the requirement is implemented in a service.", "ESigReqDetail", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("The type of verification that must occur to validate an Electronic Signature.\r\n1 = Password Verification\r\n2 = Badge Verification (future enhancement)\r\n3 = Biometric Verification (future enhancement)", "ESigVerificationMethodEnum", false, true, false, "Integer", 1050344, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_VerificationMethod")]
    protected Environment _VerificationMethod;
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, true, false, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_Role")]
    protected Environment _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_CosignerRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1050340, false, false, true, null)]
    protected Environment _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_Meaning")]
    [Metadata("Descriptive meaning for an Electronic Signature requirement.", "ESigMeaning", false, true, false, "NamedObjectRef", 1050341, false, false, true, null)]
    protected Environment _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_SignatureCount")]
    [Metadata("Generic Integer", "", false, true, false, "Integer", 1050343, false, false, false, null)]
    protected Environment _SignatureCount;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050345, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Environment_Name")]
    protected new Environment _Name;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
