// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMgr_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (WIPMsgMgrInquiry_Info))]
  [Serializable]
  public class WIPMsgMgr_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Info_WIPMsgCriteria")]
    protected WIPMsgCriteria_Info _WIPMsgCriteria;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Info_WIPMsgs")]
    protected WIPMsg_Info _WIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Info_Containers")]
    protected Info _Containers;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Info_WIPMsgRetrievalDateGMT")]
    protected Info _WIPMsgRetrievalDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Info_FilterOnServiceType")]
    protected Info _FilterOnServiceType;

    public WIPMsgCriteria_Info WIPMsgCriteria
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgCriteria), (object) value);
      }
      get
      {
        return (WIPMsgCriteria_Info) this.PropertyGet(nameof (WIPMsgCriteria));
      }
    }

    public WIPMsg_Info WIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgs), (object) value);
      }
      get
      {
        return (WIPMsg_Info) this.PropertyGet(nameof (WIPMsgs));
      }
    }

    public Info Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Containers));
      }
    }

    public Info WIPMsgRetrievalDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgRetrievalDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMsgRetrievalDateGMT));
      }
    }

    public Info FilterOnServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterOnServiceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterOnServiceType));
      }
    }
  }
}
