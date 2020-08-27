// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Service_Environment
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
  public class Service_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Service_Environment_MfgProcessOverrides")]
    [Metadata("Bill Of Process is used to specify overrides to a specification (spec), and is assigned to a container, manufacturing order or a product.", "BillOfProcess", false, false, false, "RevisionedObjectRef", 1050936, false, false, false, null)]
    protected Environment _MfgProcessOverrides;
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgr", false, false, false, "WIPMsgMgr", 1048865, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Service_Environment_WIPMsgMgr")]
    protected WIPMsgMgr_Environment _WIPMsgMgr;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049887, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Service_Environment_IsRemoteService")]
    protected Environment _IsRemoteService;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1053113, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Service_Environment_TxnDateGMT")]
    protected Environment _TxnDateGMT;

    public Environment MfgProcessOverrides
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgProcessOverrides), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgProcessOverrides));
      }
    }

    public WIPMsgMgr_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public Environment IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Environment TxnDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnDateGMT));
      }
    }
  }
}
