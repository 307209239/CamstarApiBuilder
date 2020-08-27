// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMgrInquiry_Environment
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
  public class WIPMsgMgrInquiry_Environment : WIPMsgMgr_Environment
  {
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049840, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgrInquiry_Environment_FilterOnServiceType")]
    protected new Environment _FilterOnServiceType;

    public new Environment FilterOnServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterOnServiceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterOnServiceType));
      }
    }
  }
}
