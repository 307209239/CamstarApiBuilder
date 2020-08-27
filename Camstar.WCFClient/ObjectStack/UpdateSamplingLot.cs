// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateSamplingLot
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
  public class UpdateSamplingLot : SamplingLotTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_SamplingLot")]
    protected new NamedObjectRef _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_CurrentSampleRate")]
    protected Primitive<int> _CurrentSampleRate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_SampleRate")]
    protected new Primitive<int> _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Qty")]
    protected new Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is UpdateSamplingLot && object.Equals((object) this._SamplingLot, (object) ((UpdateSamplingLot) obj)._SamplingLot) && (object.Equals((object) this._CurrentSampleRate, (object) ((UpdateSamplingLot) obj)._CurrentSampleRate) && object.Equals((object) this._SampleRate, (object) ((UpdateSamplingLot) obj)._SampleRate)) && object.Equals((object) this._Qty, (object) ((UpdateSamplingLot) obj)._Qty) && base.Equals(obj);
    }

    public new NamedObjectRef SamplingLot
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

    public Primitive<int> CurrentSampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSampleRate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentSampleRate));
      }
    }

    public new Primitive<int> SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SampleRate));
      }
    }

    public new Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
