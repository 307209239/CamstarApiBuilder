// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityESigDetail_Environment
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
  public class QualityESigDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Environment_SignerPassword")]
    [Metadata("Password", "", false, false, false, "EncryptedField", 1050362, false, false, false, null)]
    protected Environment _SignerPassword;
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Environment_UserRequired")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051790, false, false, false, "0")]
    protected Environment _UserRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Environment_Signer")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1050361, false, false, false, null)]
    protected Environment _Signer;

    public Environment SignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerPassword), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SignerPassword));
      }
    }

    public Environment UserRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserRequired));
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
  }
}
