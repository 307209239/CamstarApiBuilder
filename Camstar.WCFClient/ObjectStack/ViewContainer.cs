// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainer
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
  public class ViewContainer : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_WIPMsgMgr")]
    protected new WIPMsgMgrInquiry _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_ContainerStatusDetails")]
    protected ViewContainerAsParent _ContainerStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_WIPMessageExtent")]
    protected Primitive<int> _WIPMessageExtent;

    public override bool Equals(object obj)
    {
      return obj is ViewContainer && object.Equals((object) this._WIPMsgMgr, (object) ((ViewContainer) obj)._WIPMsgMgr) && (object.Equals((object) this._ContainerStatusDetails, (object) ((ViewContainer) obj)._ContainerStatusDetails) && object.Equals((object) this._Container, (object) ((ViewContainer) obj)._Container)) && object.Equals((object) this._WIPMessageExtent, (object) ((ViewContainer) obj)._WIPMessageExtent) && base.Equals(obj);
    }

    public new WIPMsgMgrInquiry WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgrInquiry) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public ViewContainerAsParent ContainerStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusDetails), (object) value);
      }
      get
      {
        return (ViewContainerAsParent) this.PropertyGet(nameof (ContainerStatusDetails));
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

    public Primitive<int> WIPMessageExtent
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMessageExtent), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WIPMessageExtent));
      }
    }
  }
}
