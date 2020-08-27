// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoteStart_Info
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
  public class RemoteStart_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemoteStart_Info_IsRemoteService")]
    protected new Info _IsRemoteService;

    public new Info IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRemoteService));
      }
    }
  }
}
