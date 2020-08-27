// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShipmentDestinationChanges_Info
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
  public class ShipmentDestinationChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_LocalContainerStatus")]
    protected Info _LocalContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_RemoteSite")]
    protected Info _RemoteSite;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_RemoteContainerStatus")]
    protected Info _RemoteContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_Customer")]
    protected Info _Customer;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ShipmentDestinationChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info LocalContainerStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocalContainerStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LocalContainerStatus));
      }
    }

    public Info RemoteSite
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteSite), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemoteSite));
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

    public Info Customer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Customer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Customer));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
