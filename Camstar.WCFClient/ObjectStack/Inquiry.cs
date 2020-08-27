// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Inquiry
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
  public class Inquiry : Service
  {
    [DataMember(EmitDefaultValue = false, Name = "Inquiry_WIPMsgMgr")]
    protected WIPMsgMgrInquiry _WIPMsgMgr;

    public override bool Equals(object obj)
    {
      return obj is Inquiry && object.Equals((object) this._WIPMsgMgr, (object) ((Inquiry) obj)._WIPMsgMgr) && base.Equals(obj);
    }

    public WIPMsgMgrInquiry WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgrInquiry) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }
  }
}
