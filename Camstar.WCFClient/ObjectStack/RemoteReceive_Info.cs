// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemoteReceive_Info
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
  public class RemoteReceive_Info : CompoundTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_CurrentStatus")]
    protected CurrentStatus_Info _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_ShipmentDestination")]
    protected Info _ShipmentDestination;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_ContainerStatus")]
    protected Info _ContainerStatus;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_Container")]
    protected Container_Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_Close")]
    protected Info _Close;
    [DataMember(EmitDefaultValue = false, Name = "RemoteReceive_Info_Factory")]
    protected new Info _Factory;

    public CurrentStatus_Info CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (CurrentStatus_Info) this.PropertyGet(nameof (CurrentStatus));
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

    public new Info MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

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

    public Container_Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Container_Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info Close
    {
      [param: In] set
      {
        this.PropertySet(nameof (Close), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Close));
      }
    }

    public new Info Factory
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
  }
}
