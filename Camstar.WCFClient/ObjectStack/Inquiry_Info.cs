// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Inquiry_Info
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
  public class Inquiry_Info : Service_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Inquiry_Info_WIPMsgMgr")]
    protected WIPMsgMgrInquiry_Info _WIPMsgMgr;

    public WIPMsgMgrInquiry_Info WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgrInquiry_Info) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }
  }
}
