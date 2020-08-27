// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Service
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
  public class Service : BaseObject
  {
    [DataMember(EmitDefaultValue = false, Name = "Service_MfgProcessOverrides")]
    protected RevisionedObjectRef _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Service_WIPMsgMgr")]
    protected WIPMsgMgr _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Service_IsRemoteService")]
    protected Primitive<bool> _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "Service_TxnDateGMT")]
    protected Primitive<DateTime> _TxnDateGMT;

    public override bool Equals(object obj)
    {
      return obj is Service && object.Equals((object) this._MfgProcessOverrides, (object) ((Service) obj)._MfgProcessOverrides) && (object.Equals((object) this._WIPMsgMgr, (object) ((Service) obj)._WIPMsgMgr) && object.Equals((object) this._IsRemoteService, (object) ((Service) obj)._IsRemoteService)) && object.Equals((object) this._TxnDateGMT, (object) ((Service) obj)._TxnDateGMT) && base.Equals(obj);
    }

    public RevisionedObjectRef MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public WIPMsgMgr WIPMsgMgr
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

    public Primitive<bool> IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Primitive<DateTime> TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (TxnDateGMT));
      }
    }
  }
}
