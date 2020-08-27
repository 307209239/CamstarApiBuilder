// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchInquiry
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
  public class BatchInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_CurrentContainerStatus")]
    protected CurrentContainerStatus _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Containers")]
    protected BatchInquiryDetail[] _Containers;

    public override bool Equals(object obj)
    {
      return obj is BatchInquiry && object.Equals((object) this._CurrentContainerStatus, (object) ((BatchInquiry) obj)._CurrentContainerStatus) && (object.Equals((object) this._Container, (object) ((BatchInquiry) obj)._Container) && this.CompareArrays((Array) this._Containers, (Array) ((BatchInquiry) obj)._Containers)) && base.Equals(obj);
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

    public BatchInquiryDetail[] Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (BatchInquiryDetail[]) this.PropertyGet(nameof (Containers));
      }
    }
  }
}
