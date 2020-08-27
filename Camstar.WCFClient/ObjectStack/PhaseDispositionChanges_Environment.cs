// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PhaseDispositionChanges_Environment
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
  public class PhaseDispositionChanges_Environment : PhaseChanges_Environment
  {
    [Metadata("Identifies a suspect Lot for an Event.", "EventLot", false, false, false, "SubentityRef", 1051071, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionChanges_Environment_EventLots")]
    protected Environment _EventLots;
    [Metadata("Service details for available lots", "AvailableLotDetail", false, false, false, "AvailableLotDetail", 1052031, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionChanges_Environment_AvailableLots")]
    protected AvailableLotDetail_Environment _AvailableLots;
    [DataMember(EmitDefaultValue = false, Name = "PhaseDispositionChanges_Environment_DiscoveryArea")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051043, false, false, false, null)]
    protected Environment _DiscoveryArea;

    public Environment EventLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLots), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventLots));
      }
    }

    public AvailableLotDetail_Environment AvailableLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail_Environment) this.PropertyGet(nameof (AvailableLots));
      }
    }

    public Environment DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DiscoveryArea));
      }
    }
  }
}
