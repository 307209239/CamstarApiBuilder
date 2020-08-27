// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMgr
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (WIPMsgMgrInquiry))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class WIPMsgMgr : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_WIPMsgCriteria")]
    protected WIPMsgCriteria _WIPMsgCriteria;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_WIPMsgs")]
    protected WIPMsg[] _WIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_Containers")]
    protected ContainerRef[] _Containers;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_WIPMsgRetrievalDateGMT")]
    protected Primitive<DateTime> _WIPMsgRetrievalDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgr_FilterOnServiceType")]
    protected Primitive<bool> _FilterOnServiceType;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgMgr && object.Equals((object) this._WIPMsgCriteria, (object) ((WIPMsgMgr) obj)._WIPMsgCriteria) && (this.CompareArrays((Array) this._WIPMsgs, (Array) ((WIPMsgMgr) obj)._WIPMsgs) && this.CompareArrays((Array) this._Containers, (Array) ((WIPMsgMgr) obj)._Containers)) && (object.Equals((object) this._WIPMsgRetrievalDateGMT, (object) ((WIPMsgMgr) obj)._WIPMsgRetrievalDateGMT) && object.Equals((object) this._FilterOnServiceType, (object) ((WIPMsgMgr) obj)._FilterOnServiceType)) && base.Equals(obj);
    }

    public WIPMsgCriteria WIPMsgCriteria
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgCriteria), (object) value);
      }
      get
      {
        return (WIPMsgCriteria) this.PropertyGet(nameof (WIPMsgCriteria));
      }
    }

    public WIPMsg[] WIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgs), (object) value);
      }
      get
      {
        return (WIPMsg[]) this.PropertyGet(nameof (WIPMsgs));
      }
    }

    public ContainerRef[] Containers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Containers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (Containers));
      }
    }

    public Primitive<DateTime> WIPMsgRetrievalDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgRetrievalDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (WIPMsgRetrievalDateGMT));
      }
    }

    public Primitive<bool> FilterOnServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterOnServiceType), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (FilterOnServiceType));
      }
    }
  }
}
