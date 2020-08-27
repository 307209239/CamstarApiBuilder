// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgMgrInquiry
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
  public class WIPMsgMgrInquiry : WIPMsgMgr
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgMgrInquiry_FilterOnServiceType")]
    protected new Primitive<bool> _FilterOnServiceType;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgMgrInquiry && object.Equals((object) this._FilterOnServiceType, (object) ((WIPMsgMgrInquiry) obj)._FilterOnServiceType) && base.Equals(obj);
    }

    public new Primitive<bool> FilterOnServiceType
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
