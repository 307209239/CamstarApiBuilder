// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgCriteria_Info
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
  public class WIPMsgCriteria_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_Info_WIPMsgs")]
    protected WIPMsg_Info _WIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_Info_ContainerEffectiveDateGMT")]
    protected Info _ContainerEffectiveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_Info_FilterOnServiceType")]
    protected Info _FilterOnServiceType;

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

    public Info ContainerEffectiveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerEffectiveDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerEffectiveDateGMT));
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
