// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanDispositionChanges
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
  public class PlanDispositionChanges : PlanChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionChanges_EventLots")]
    protected SubentityRef[] _EventLots;
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionChanges_AvailableLots")]
    protected AvailableLotDetail[] _AvailableLots;
    [DataMember(EmitDefaultValue = false, Name = "PlanDispositionChanges_DiscoveryArea")]
    protected Primitive<string> _DiscoveryArea;

    public override bool Equals(object obj)
    {
      return obj is PlanDispositionChanges && this.CompareArrays((Array) this._EventLots, (Array) ((PlanDispositionChanges) obj)._EventLots) && (this.CompareArrays((Array) this._AvailableLots, (Array) ((PlanDispositionChanges) obj)._AvailableLots) && object.Equals((object) this._DiscoveryArea, (object) ((PlanDispositionChanges) obj)._DiscoveryArea)) && base.Equals(obj);
    }

    public SubentityRef[] EventLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLots), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (EventLots));
      }
    }

    public AvailableLotDetail[] AvailableLots
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailableLots), (object) value);
      }
      get
      {
        return (AvailableLotDetail[]) this.PropertyGet(nameof (AvailableLots));
      }
    }

    public Primitive<string> DiscoveryArea
    {
      [param: In] set
      {
        this.PropertySet(nameof (DiscoveryArea), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DiscoveryArea));
      }
    }
  }
}
