// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerInfo_Environment
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
  public class ContainerInfo_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfo_Environment_CurrentStatus")]
    [Metadata("The Current Container Status contains the current location information for one or more containers.  Every container associated in a multilevel container structure will have a reference to a single Current Container Status CDO.", "CurrentStatus", false, false, true, "CurrentStatus", 1048786, false, false, false, null)]
    protected CurrentStatus_Environment _CurrentStatus;
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, true, "Container", 1049043, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerInfo_Environment_Container")]
    protected Container_Environment _Container;

    public CurrentStatus_Environment CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (CurrentStatus_Environment) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Container_Environment Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Container_Environment) this.PropertyGet(nameof (Container));
      }
    }
  }
}
