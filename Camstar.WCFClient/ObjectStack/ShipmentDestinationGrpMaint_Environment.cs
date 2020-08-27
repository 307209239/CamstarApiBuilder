// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipmentDestinationGrpMaint_Environment
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
  public class ShipmentDestinationGrpMaint_Environment : NamedObjectGroupMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationGrpMaint_Environment_ObjectListInquiry")]
    [Metadata("A Named Object Group that represents a group of ShipmentDestination which is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestinationGrp", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationGrpMaint_Environment_ObjectToChange")]
    [Metadata("A Named Object Group that represents a group of ShipmentDestination which is the factory or customer to which the container is shipped. ShipmentDestinaiton also contains routing information used by the RemoteProcessingInfo object when the Ship transaction is sending remote transactions to a destination site.", "ShipmentDestinationGrp", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationGrpMaint_Environment_ObjectChanges")]
    [Metadata("A Named Object Group that represents a group of ShipmentDestinationChanges.", "ShipmentDestinationGrpChanges", false, false, false, "ShipmentDestinationGrpChanges", 1048873, true, false, false, null)]
    protected ShipmentDestinationGrpChanges_Environment _ObjectChanges;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public ShipmentDestinationGrpChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ShipmentDestinationGrpChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
