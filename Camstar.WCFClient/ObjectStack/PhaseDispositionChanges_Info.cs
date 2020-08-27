// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseDispositionChanges_Info
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
  public class PhaseDispositionChanges_Info : PhaseChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionChanges_Info_EventLots")]
    protected Info _EventLots;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionChanges_Info_AvailableLots")]
    protected AvailableLotDetail_Info _AvailableLots;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionChanges_Info_DiscoveryArea")]
    protected Info _DiscoveryArea;

    public Info EventLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLots), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventLots));
      }
    }

    public AvailableLotDetail_Info AvailableLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail_Info) this.PropertyGet(nameof (AvailableLots));
      }
    }

    public Info DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DiscoveryArea));
      }
    }
  }
}
