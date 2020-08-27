// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInfo
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
  public class ContainerInfo : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfo_CurrentStatus")]
    protected CurrentStatus _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfo_Container")]
    protected Container _Container;

    public override bool Equals(object obj)
    {
      return obj is ContainerInfo && object.Equals((object) this._CurrentStatus, (object) ((ContainerInfo) obj)._CurrentStatus) && object.Equals((object) this._Container, (object) ((ContainerInfo) obj)._Container) && base.Equals(obj);
    }

    public CurrentStatus CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (CurrentStatus) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Container Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Container) this.PropertyGet(nameof (Container));
      }
    }
  }
}
