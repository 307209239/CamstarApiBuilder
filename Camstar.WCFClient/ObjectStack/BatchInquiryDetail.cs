// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchInquiryDetail
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
  public class BatchInquiryDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiryDetail_CurrentContainerStatus")]
    protected CurrentContainerStatus _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiryDetail_Container")]
    protected ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is BatchInquiryDetail && object.Equals((object) this._CurrentContainerStatus, (object) ((BatchInquiryDetail) obj)._CurrentContainerStatus) && object.Equals((object) this._Container, (object) ((BatchInquiryDetail) obj)._Container) && base.Equals(obj);
    }

    public CurrentContainerStatus CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public ContainerRef Container
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
