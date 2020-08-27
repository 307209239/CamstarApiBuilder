// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BatchInquiryDetail_Environment
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
  public class BatchInquiryDetail_Environment : ServiceData_Environment
  {
    [Metadata("Current status information of a Container", "CurrentContainerStatus", false, false, true, "CurrentContainerStatus", 1050388, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiryDetail_Environment_CurrentContainerStatus")]
    protected CurrentContainerStatus_Environment _CurrentContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "BatchInquiryDetail_Environment_Container")]
    [Metadata("Material Container", "MaterialContainer", false, false, true, "ContainerRef", 1051878, false, false, false, null)]
    protected Environment _Container;

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
  }
}
