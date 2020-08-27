// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventLots_Environment
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
  public class UpdateEventLots_Environment : UpdateEventDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventLots_Environment_EventLotDetails")]
    [Metadata("Identifies the Lots to assign to the Event.", "EventLotDetail", false, false, false, "EventLotDetail", 1051071, false, true, false, null)]
    protected EventLotDetail_Environment _EventLotDetails;

    public EventLotDetail_Environment EventLotDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotDetails), (object) value);
      }
      get
      {
        return (EventLotDetail_Environment) this.PropertyGet(nameof (EventLotDetails));
      }
    }
  }
}
