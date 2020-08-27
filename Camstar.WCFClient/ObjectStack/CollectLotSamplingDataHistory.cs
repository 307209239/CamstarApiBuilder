// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectLotSamplingDataHistory
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
  public class CollectLotSamplingDataHistory : CollectSamplingDataHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingDataHistory_SamplingLot")]
    protected NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingDataHistory_MfgOrder")]
    protected NamedObjectRef _MfgOrder;

    public override bool Equals(object obj)
    {
      return obj is CollectLotSamplingDataHistory && object.Equals((object) this._SamplingLot, (object) ((CollectLotSamplingDataHistory) obj)._SamplingLot) && object.Equals((object) this._MfgOrder, (object) ((CollectLotSamplingDataHistory) obj)._MfgOrder) && base.Equals(obj);
    }

    public NamedObjectRef SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }
  }
}
