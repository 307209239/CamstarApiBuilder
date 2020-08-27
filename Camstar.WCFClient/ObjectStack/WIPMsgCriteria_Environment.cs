// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgCriteria_Environment
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
  public class WIPMsgCriteria_Environment : Subentity_Environment
  {
    [Metadata("This object contains the resolved message and values used to acknowledge the message during processing.  It is a temporary object created during the GetWIPMsgs function.", "WIPMsg", false, false, true, "WIPMsg", 1051787, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_Environment_WIPMsgs")]
    protected WIPMsg_Environment _WIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_Environment_ContainerEffectiveDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1049076, false, false, false, null)]
    protected Environment _ContainerEffectiveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_Environment_FilterOnServiceType")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049840, false, false, false, "0")]
    protected Environment _FilterOnServiceType;

    public WIPMsg_Environment WIPMsgs
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgs), (object) value);
      }
      get
      {
        return (WIPMsg_Environment) this.PropertyGet(nameof (WIPMsgs));
      }
    }

    public Environment ContainerEffectiveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerEffectiveDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerEffectiveDateGMT));
      }
    }

    public Environment FilterOnServiceType
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
