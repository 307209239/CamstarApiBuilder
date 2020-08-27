// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInfoInquiry_Environment
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
  public class ContainerInfoInquiry_Environment : Inquiry_Environment
  {
    [Metadata("A step in an ERPRoute, which is the closest ERP concept to an InSite workflow.  ERP Route Steps are usually defined at a more summarized level than InSite workflow steps.", "RouteStep", false, false, false, "NamedSubentityRef", 16779252, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Environment_CurrentRouteStep")]
    protected Environment _CurrentRouteStep;
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Environment_ContainerInfo")]
    [Metadata("Holds information for a Container and CurrentStatus", "ContainerInfo", false, false, false, "ContainerInfo", 16779185, false, false, false, null)]
    protected ContainerInfo_Environment _ContainerInfo;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfoInquiry_Environment_Container")]
    protected Environment _Container;

    public Environment CurrentRouteStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentRouteStep), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentRouteStep));
      }
    }

    public ContainerInfo_Environment ContainerInfo
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerInfo), (object) value);
      }
      get
      {
        return (ContainerInfo_Environment) this.PropertyGet(nameof (ContainerInfo));
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
