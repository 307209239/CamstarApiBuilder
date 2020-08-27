// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ViewContainer_Environment
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
  public class ViewContainer_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Environment_WIPMsgMgr")]
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgrInquiry", false, false, false, "WIPMsgMgrInquiry", 1048865, true, false, false, null)]
    protected new WIPMsgMgrInquiry_Environment _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Environment_ContainerStatusDetails")]
    [Metadata("The ViewContainer CDO is the parent for this subclass. All CVEs will resolve through the ViewContainer.Container field.", "ViewContainerAsParent", false, false, false, "ViewContainerAsParent", 1049722, true, false, false, null)]
    protected ViewContainerAsParent_Environment _ContainerStatusDetails;
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Environment_Container")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    protected Environment _Container;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049069, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ViewContainer_Environment_WIPMessageExtent")]
    protected Environment _WIPMessageExtent;

    public new WIPMsgMgrInquiry_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgrInquiry_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public ViewContainerAsParent_Environment ContainerStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatusDetails), (object) value);
      }
      get
      {
        return (ViewContainerAsParent_Environment) this.PropertyGet(nameof (ContainerStatusDetails));
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

    public Environment WIPMessageExtent
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMessageExtent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMessageExtent));
      }
    }
  }
}
