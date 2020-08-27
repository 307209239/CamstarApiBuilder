// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_Sampling_EvaluateSwitchingRule_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ShopFloor_Sampling_EvaluateSwitchingRule_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingStatus")]
    protected string _SamplingStatus;
    [DataMember(EmitDefaultValue = false, Name = "SampleDetails")]
    protected string _SampleDetails;

    public string SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public string SampleDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDetails), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (SampleDetails));
      }
    }
  }
}
