// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataDetails_Info
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
  public class CollectSamplingDataDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_CountedRejectReason")]
    protected Info _CountedRejectReason;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_SampleTest")]
    protected Info _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_SamplingDataPointDetails")]
    protected SamplingDataPointDetails_Info _SamplingDataPointDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_CollectSamplingTestDtlHistory")]
    protected Info _CollectSamplingTestDtlHistory;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_TotalSamplesCollected")]
    protected Info _TotalSamplesCollected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_Rejects")]
    protected Info _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_Rejected")]
    protected Info _Rejected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Info_SampleTestName")]
    protected Info _SampleTestName;

    public Info CountedRejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountedRejectReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CountedRejectReason));
      }
    }

    public Info SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTest));
      }
    }

    public SamplingDataPointDetails_Info SamplingDataPointDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingDataPointDetails), (object) value);
      }
      get
      {
        return (SamplingDataPointDetails_Info) this.PropertyGet(nameof (SamplingDataPointDetails));
      }
    }

    public Info CollectSamplingTestDtlHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingTestDtlHistory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollectSamplingTestDtlHistory));
      }
    }

    public Info TotalSamplesCollected
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesCollected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TotalSamplesCollected));
      }
    }

    public Info Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejects));
      }
    }

    public Info Rejected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Rejected));
      }
    }

    public Info SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
