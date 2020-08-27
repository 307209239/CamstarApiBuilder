// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchInquiry_Info
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
  public class BatchInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Info_CurrentContainerStatus")]
    protected CurrentContainerStatus_Info _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Info_Containers")]
    protected BatchInquiryDetail_Info _Containers;

    public CurrentContainerStatus_Info CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus_Info) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public BatchInquiryDetail_Info Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (BatchInquiryDetail_Info) this.PropertyGet(nameof (Containers));
      }
    }
  }
}
