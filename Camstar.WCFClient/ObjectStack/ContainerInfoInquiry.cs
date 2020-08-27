// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInfoInquiry
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
  public class ContainerInfoInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_CurrentRouteStep")]
    protected NamedSubentityRef _CurrentRouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_ContainerInfo")]
    protected ContainerInfo _ContainerInfo;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Container")]
    protected ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is ContainerInfoInquiry && object.Equals((object) this._CurrentRouteStep, (object) ((ContainerInfoInquiry) obj)._CurrentRouteStep) && (object.Equals((object) this._ContainerInfo, (object) ((ContainerInfoInquiry) obj)._ContainerInfo) && object.Equals((object) this._Container, (object) ((ContainerInfoInquiry) obj)._Container)) && base.Equals(obj);
    }

    public NamedSubentityRef CurrentRouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRouteStep), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (CurrentRouteStep));
      }
    }

    public ContainerInfo ContainerInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInfo), (object) value);
      }
      get
      {
        return (ContainerInfo) this.PropertyGet(nameof (ContainerInfo));
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
