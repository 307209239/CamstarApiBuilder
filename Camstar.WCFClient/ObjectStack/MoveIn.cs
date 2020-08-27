// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveIn
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
  public class MoveIn : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_WIPMsgMgr")]
    protected new WIPMsgMgr _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_ClearLocation")]
    protected Primitive<bool> _ClearLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_UseDispatch")]
    protected new Primitive<bool> _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Location")]
    protected NamedSubentityRef _Location;

    public override bool Equals(object obj)
    {
      return obj is MoveIn && object.Equals((object) this._WIPMsgMgr, (object) ((MoveIn) obj)._WIPMsgMgr) && (object.Equals((object) this._ClearLocation, (object) ((MoveIn) obj)._ClearLocation) && object.Equals((object) this._Container, (object) ((MoveIn) obj)._Container)) && (object.Equals((object) this._UseDispatch, (object) ((MoveIn) obj)._UseDispatch) && object.Equals((object) this._Resource, (object) ((MoveIn) obj)._Resource) && object.Equals((object) this._Location, (object) ((MoveIn) obj)._Location)) && base.Equals(obj);
    }

    public new WIPMsgMgr WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public Primitive<bool> ClearLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearLocation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ClearLocation));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public new Primitive<bool> UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }
  }
}
