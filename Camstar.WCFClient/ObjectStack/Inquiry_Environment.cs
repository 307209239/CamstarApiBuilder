// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Inquiry_Environment
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
  public class Inquiry_Environment : Service_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Inquiry_Environment_WIPMsgMgr")]
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgrInquiry", false, false, false, "WIPMsgMgrInquiry", 1048865, true, false, false, null)]
    protected WIPMsgMgrInquiry_Environment _WIPMsgMgr;

    public WIPMsgMgrInquiry_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgrInquiry_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }
  }
}
