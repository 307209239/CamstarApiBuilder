// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventDispositions_Info
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
  public class UpdateEventDispositions_Info : UpdateEventDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventDispositions_Info_EventLotDetails")]
    protected EventLotDetail_Info _EventLotDetails;

    public EventLotDetail_Info EventLotDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLotDetails), (object) value);
      }
      get
      {
        return (EventLotDetail_Info) this.PropertyGet(nameof (EventLotDetails));
      }
    }
  }
}
