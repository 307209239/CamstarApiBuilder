// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveIn_Info
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
  public class MoveIn_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Info_WIPMsgMgr")]
    protected new WIPMsgMgr_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Info_ClearLocation")]
    protected Info _ClearLocation;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Info_UseDispatch")]
    protected new Info _UseDispatch;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "MoveIn_Info_Location")]
    protected Info _Location;

    public new WIPMsgMgr_Info WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Info) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public Info ClearLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClearLocation));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public new Info UseDispatch
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseDispatch), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseDispatch));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
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
  }
}
