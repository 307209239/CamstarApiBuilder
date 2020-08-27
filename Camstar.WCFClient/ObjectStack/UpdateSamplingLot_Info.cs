// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateSamplingLot_Info
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
  public class UpdateSamplingLot_Info : SamplingLotTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Info_SamplingLot")]
    protected new Info _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Info_CurrentSampleRate")]
    protected Info _CurrentSampleRate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Info_SampleRate")]
    protected new Info _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Info_Qty")]
    protected new Info _Qty;

    public new Info SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Info CurrentSampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSampleRate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentSampleRate));
      }
    }

    public new Info SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleRate));
      }
    }

    public new Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
