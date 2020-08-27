// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainer_Info
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
  public class ViewContainer_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Info_WIPMsgMgr")]
    protected new WIPMsgMgrInquiry_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Info_ContainerStatusDetails")]
    protected ViewContainerAsParent_Info _ContainerStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Info_WIPMessageExtent")]
    protected Info _WIPMessageExtent;

    public new WIPMsgMgrInquiry_Info WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgrInquiry_Info) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public ViewContainerAsParent_Info ContainerStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusDetails), (object) value);
      }
      get
      {
        return (ViewContainerAsParent_Info) this.PropertyGet(nameof (ContainerStatusDetails));
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

    public Info WIPMessageExtent
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMessageExtent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMessageExtent));
      }
    }
  }
}
