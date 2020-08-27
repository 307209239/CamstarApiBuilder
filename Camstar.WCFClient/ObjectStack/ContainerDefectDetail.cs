// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerDefectDetail
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
  public class ContainerDefectDetail : DefectDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectDetail_ReasonCode")]
    protected new NamedObjectRef _ReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerDefectDetail_Container")]
    protected new ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is ContainerDefectDetail && object.Equals((object) this._ReasonCode, (object) ((ContainerDefectDetail) obj)._ReasonCode) && object.Equals((object) this._Container, (object) ((ContainerDefectDetail) obj)._Container) && base.Equals(obj);
    }

    public new NamedObjectRef ReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReasonCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReasonCode));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }
  }
}
