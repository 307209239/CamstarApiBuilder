// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.Maintenance_AuthorizeSigner_Parameters
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
  public class Maintenance_AuthorizeSigner_Parameters : Maintenance_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "IsCosigner")]
    protected string _IsCosigner;
    [DataMember(EmitDefaultValue = false, Name = "User")]
    protected string _User;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetail")]
    protected string _ESigReqDetail;

    public string IsCosigner
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsCosigner), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (IsCosigner));
      }
    }

    public string User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (User));
      }
    }

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
  }
}
