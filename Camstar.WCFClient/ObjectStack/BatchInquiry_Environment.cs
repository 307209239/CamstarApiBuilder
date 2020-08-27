// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchInquiry_Environment
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
  public class BatchInquiry_Environment : Inquiry_Environment
  {
    [Metadata("Current status information of a Container", "CurrentContainerStatus", false, false, true, "CurrentContainerStatus", 1050388, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Environment_CurrentContainerStatus")]
    protected CurrentContainerStatus_Environment _CurrentContainerStatus;
    [Metadata("A Batch represents the materials that are the final result of the production process. The Batch contains or references all the information about the specific Containers that represent the tracked materials that are the final result of the process.", "Batch", false, true, false, "ContainerRef", 1051854, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Environment_Container")]
    protected Environment _Container;
    [Metadata("The detail information for the Containers in the BatchInquiry.", "BatchInquiryDetail", false, false, true, "BatchInquiryDetail", 1051907, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiry_Environment_Containers")]
    protected BatchInquiryDetail_Environment _Containers;

    public CurrentContainerStatus_Environment CurrentContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentContainerStatus), (object) value);
      }
      get
      {
        return (CurrentContainerStatus_Environment) this.PropertyGet(nameof (CurrentContainerStatus));
      }
    }

    public Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Container));
      }
    }

    public BatchInquiryDetail_Environment Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (BatchInquiryDetail_Environment) this.PropertyGet(nameof (Containers));
      }
    }
  }
}
