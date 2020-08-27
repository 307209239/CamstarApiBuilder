// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventDispositions
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
  public class UpdateEventDispositions : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDispositions_EventLotDetails")]
    protected EventLotDetail[] _EventLotDetails;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventDispositions && this.CompareArrays((Array) this._EventLotDetails, (Array) ((UpdateEventDispositions) obj)._EventLotDetails) && base.Equals(obj);
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
