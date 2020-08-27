// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateSamplingLot_Environment
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
  public class UpdateSamplingLot_Environment : SamplingLotTxn_Environment
  {
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, true, false, "NamedObjectRef", 16777719, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Environment_SamplingLot")]
    protected new Environment _SamplingLot;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777972, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Environment_CurrentSampleRate")]
    protected Environment _CurrentSampleRate;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777736, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Environment_SampleRate")]
    protected new Environment _SampleRate;
    [DataMember(EmitDefaultValue = false, Name = "UpdateSamplingLot_Environment_Qty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 16777735, false, false, false, null)]
    protected new Environment _Qty;

    public new Environment SamplingLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLot));
      }
    }

    public Environment CurrentSampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSampleRate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentSampleRate));
      }
    }

    public new Environment SampleRate
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleRate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleRate));
      }
    }

    public new Environment Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
