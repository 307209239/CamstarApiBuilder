// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Disassociate_Environment
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
  public class Disassociate_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_Environment_DisassociateCandidate")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1052805, false, false, false, null)]
    protected Environment _DisassociateCandidate;
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_Environment_DisassociateAll")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049073, false, false, false, "0")]
    protected Environment _DisassociateAll;
    [DataMember(EmitDefaultValue = false, Name = "Disassociate_Environment_ChildContainers")]
    [Metadata("A Container describes a discrete unit of work or a discrete quantity of material (i.e., batch of material, a serialized component or serialized piece of material, a uniquely identified package or vessel that contains product, etc.)  A Container can include quantity information (weight, count, etc.) directly, or it can include a grouping of other containers (child containers).", "Container", false, false, false, "ContainerRef", 1049640, false, true, true, null)]
    protected Environment _ChildContainers;

    public Environment DisassociateCandidate
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateCandidate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisassociateCandidate));
      }
    }

    public Environment DisassociateAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateAll), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisassociateAll));
      }
    }

    public Environment ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildContainers));
      }
    }
  }
}
