// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_Sampling_LotSampleData_Parameters
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
  public class ShopFloor_Sampling_LotSampleData_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "SampleStatus")]
    protected string _SampleStatus;
    [DataMember(EmitDefaultValue = false, Name = "SampleDetails")]
    protected string _SampleDetails;
    [DataMember(EmitDefaultValue = false, Name = "StartDetails")]
    protected string _StartDetails;

    public string SampleStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleStatus), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (SampleStatus));
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

    public string StartDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDetails), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (StartDetails));
      }
    }
  }
}
