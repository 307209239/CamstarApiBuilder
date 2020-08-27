// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.Maintenance_VerifyPasswordSignature_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Maintenance_VerifyPasswordSignature_Parameters : Maintenance_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetail")]
    protected string _ESigReqDetail;
    [DataMember(EmitDefaultValue = false, Name = "CSPassword")]
    protected string _CSPassword;
    [DataMember(EmitDefaultValue = false, Name = "Cosigner")]
    protected string _Cosigner;
    [DataMember(EmitDefaultValue = false, Name = "Signer")]
    protected string _Signer;
    [DataMember(EmitDefaultValue = false, Name = "Password")]
    protected string _Password;

    public string ESigReqDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetail), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ESigReqDetail));
      }
    }

    public string CSPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (CSPassword), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (CSPassword));
      }
    }

    public string Cosigner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cosigner), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Cosigner));
      }
    }

    public string Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Signer));
      }
    }

    public string Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Password));
      }
    }
  }
}
