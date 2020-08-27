// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipHistory_Info
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
  public class ShipHistory_Info : MoveHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Info_ContainerStatus")]
    protected Info _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Info_RemoteContainerStatus")]
    protected Info _RemoteContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Info_ShipmentDestination")]
    protected Info _ShipmentDestination;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Info_ToCustomer")]
    protected Info _ToCustomer;
    [DataMember(EmitDefaultValue = false, Name = "ShipHistory_Info_ToFactory")]
    protected Info _ToFactory;

    public Info ContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerStatus));
      }
    }

    public Info RemoteContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteContainerStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemoteContainerStatus));
      }
    }

    public Info ShipmentDestination
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShipmentDestination), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShipmentDestination));
      }
    }

    public Info ToCustomer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCustomer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToCustomer));
      }
    }

    public Info ToFactory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToFactory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ToFactory));
      }
    }
  }
}
