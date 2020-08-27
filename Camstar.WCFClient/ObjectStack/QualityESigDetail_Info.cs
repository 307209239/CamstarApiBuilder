// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityESigDetail_Info
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
  public class QualityESigDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Info_SignerPassword")]
    protected Info _SignerPassword;
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Info_UserRequired")]
    protected Info _UserRequired;
    [DataMember(EmitDefaultValue = false, Name = "QualityESigDetail_Info_Signer")]
    protected Info _Signer;

    public Info SignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerPassword), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignerPassword));
      }
    }

    public Info UserRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserRequired));
      }
    }

    public Info Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Signer));
      }
    }
  }
}
