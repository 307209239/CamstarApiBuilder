// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityESigDetail
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
  public class QualityESigDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_SignerPassword")]
    protected EncryptedField _SignerPassword;
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_UserRequired")]
    protected Primitive<bool> _UserRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Signer")]
    protected NamedObjectRef _Signer;

    public override bool Equals(object obj)
    {
      return obj is QualityESigDetail && object.Equals((object) this._SignerPassword, (object) ((QualityESigDetail) obj)._SignerPassword) && (object.Equals((object) this._UserRequired, (object) ((QualityESigDetail) obj)._UserRequired) && object.Equals((object) this._Signer, (object) ((QualityESigDetail) obj)._Signer)) && base.Equals(obj);
    }

    public EncryptedField SignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerPassword), (object) value);
      }
      get
      {
        return (EncryptedField) this.PropertyGet(nameof (SignerPassword));
      }
    }

    public Primitive<bool> UserRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserRequired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UserRequired));
      }
    }

    public NamedObjectRef Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Signer));
      }
    }
  }
}
