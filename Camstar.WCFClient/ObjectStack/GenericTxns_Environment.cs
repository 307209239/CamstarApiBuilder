// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GenericTxns_Environment
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
  public class GenericTxns_Environment : ShopFloor_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "GenericTxns_Environment_Services")]
    [Metadata("Listing of services that are desirable to run for different types of tracking objects (Containers, Events, etc.).", "GenericTxn", false, false, false, "GenericTxn", 1052702, false, true, false, null)]
    protected GenericTxn_Environment _Services;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 16778662, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GenericTxns_Environment_TrackableObjects")]
    protected Environment _TrackableObjects;

    public GenericTxn_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (GenericTxn_Environment) this.PropertyGet(nameof (Services));
      }
    }

    public Environment TrackableObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObjects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObjects));
      }
    }
  }
}
