// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventLots
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
  public class UpdateEventLots : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventLots_EventLotDetails")]
    protected EventLotDetail[] _EventLotDetails;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventLots && this.CompareArrays((Array) this._EventLotDetails, (Array) ((UpdateEventLots) obj)._EventLotDetails) && base.Equals(obj);
    }

    public EventLotDetail[] EventLotDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotDetails), (object) value);
      }
      get
      {
        return (EventLotDetail[]) this.PropertyGet(nameof (EventLotDetails));
      }
    }
  }
}
