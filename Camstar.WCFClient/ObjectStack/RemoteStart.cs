// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoteStart
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
  public class RemoteStart : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RemoteStart_IsRemoteService")]
    protected new Primitive<bool> _IsRemoteService;

    public override bool Equals(object obj)
    {
      return obj is RemoteStart && object.Equals((object) this._IsRemoteService, (object) ((RemoteStart) obj)._IsRemoteService) && base.Equals(obj);
    }

    public new Primitive<bool> IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRemoteService));
      }
    }
  }
}
