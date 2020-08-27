// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Service_Info
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
  public class Service_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Service_Info_MfgProcessOverrides")]
    protected Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Service_Info_WIPMsgMgr")]
    protected WIPMsgMgr_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Service_Info_IsRemoteService")]
    protected Info _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "Service_Info_TxnDateGMT")]
    protected Info _TxnDateGMT;

    public Info MfgProcessOverrides
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

    public WIPMsgMgr_Info WIPMsgMgr
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

    public Info IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Info TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TxnDateGMT));
      }
    }
  }
}
