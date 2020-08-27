// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerObjectListDetails_Environment
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
  public class ChgContainerObjectListDetails_Environment : ChgObjectListDetails_Environment
  {
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049473, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerObjectListDetails_Environment_NewObjects")]
    protected new Environment _NewObjects;

    public new Environment NewObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewObjects));
      }
    }
  }
}
