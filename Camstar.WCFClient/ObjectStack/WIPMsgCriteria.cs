// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WIPMsgCriteria
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
  public class WIPMsgCriteria : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_WIPMsgs")]
    protected WIPMsg[] _WIPMsgs;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_ContainerEffectiveDateGMT")]
    protected Primitive<DateTime> _ContainerEffectiveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "WIPMsgCriteria_FilterOnServiceType")]
    protected Primitive<bool> _FilterOnServiceType;

    public override bool Equals(object obj)
    {
      return obj is WIPMsgCriteria && this.CompareArrays((Array) this._WIPMsgs, (Array) ((WIPMsgCriteria) obj)._WIPMsgs) && (object.Equals((object) this._ContainerEffectiveDateGMT, (object) ((WIPMsgCriteria) obj)._ContainerEffectiveDateGMT) && object.Equals((object) this._FilterOnServiceType, (object) ((WIPMsgCriteria) obj)._FilterOnServiceType)) && base.Equals(obj);
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

    public Primitive<DateTime> ContainerEffectiveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerEffectiveDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ContainerEffectiveDateGMT));
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
