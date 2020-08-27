// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Update_Info
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
  public class Update_Info : Service_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_ACEStatus")]
    protected Info _ACEStatus;
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_WIPMsgMgr")]
    protected new WIPMsgMgr_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_MfgProcessOverrides")]
    protected new Info _MfgProcessOverrides;
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_IsRemoteService")]
    protected new Info _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "Update_Info_ACEMessage")]
    protected Info _ACEMessage;

    public Info ACEStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (ACEStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ACEStatus));
      }
    }

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

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

    public new Info IsRemoteService
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

    public Info ACEMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ACEMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ACEMessage));
      }
    }
  }
}
