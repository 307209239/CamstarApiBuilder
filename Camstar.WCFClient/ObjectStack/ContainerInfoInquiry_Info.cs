// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInfoInquiry_Info
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
  public class ContainerInfoInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Info_CurrentRouteStep")]
    protected Info _CurrentRouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Info_ContainerInfo")]
    protected ContainerInfo_Info _ContainerInfo;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Info_Container")]
    protected Info _Container;

    public Info CurrentRouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRouteStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentRouteStep));
      }
    }

    public ContainerInfo_Info ContainerInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInfo), (object) value);
      }
      get
      {
        return (ContainerInfo_Info) this.PropertyGet(nameof (ContainerInfo));
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
  }
}
