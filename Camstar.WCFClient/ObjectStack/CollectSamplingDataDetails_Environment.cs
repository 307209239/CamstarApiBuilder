// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataDetails_Environment
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
  public class CollectSamplingDataDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_CountedRejectReason")]
    [Metadata("The user code for loss reason.", "LossReason", false, false, false, "NamedObjectRef", 1053181, false, false, false, null)]
    protected Environment _CountedRejectReason;
    [Metadata("Object used for defining instances of AQL SampleTest that describe the Data to collect and any events that should happen based on the collected data on the sample.", "SampleTest", false, true, false, "RevisionedObjectRef", 1053111, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_SampleTest")]
    protected Environment _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_SamplingDataPointDetails")]
    [Metadata("Sampling Data Point Details", "SamplingDataPointDetails", false, false, false, "SamplingDataPointDetails", 1053182, false, true, false, null)]
    protected SamplingDataPointDetails_Environment _SamplingDataPointDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_CollectSamplingTestDtlHistory")]
    [Metadata("Collect Sampling Test Dtl History", "CollectSamplingTestDtlHistory", false, false, false, "SubentityRef", 1053179, false, true, false, null)]
    protected Environment _CollectSamplingTestDtlHistory;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053183, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_TotalSamplesCollected")]
    protected Environment _TotalSamplesCollected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_Rejects")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053180, false, false, false, null)]
    protected Environment _Rejects;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051368, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_Rejected")]
    protected Environment _Rejected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Environment_SampleTestName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053132, false, false, false, null)]
    protected Environment _SampleTestName;

    public Environment CountedRejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountedRejectReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CountedRejectReason));
      }
    }

    public Environment SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTest));
      }
    }

    public SamplingDataPointDetails_Environment SamplingDataPointDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingDataPointDetails), (object) value);
      }
      get
      {
        return (SamplingDataPointDetails_Environment) this.PropertyGet(nameof (SamplingDataPointDetails));
      }
    }

    public Environment CollectSamplingTestDtlHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingTestDtlHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollectSamplingTestDtlHistory));
      }
    }

    public Environment TotalSamplesCollected
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesCollected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TotalSamplesCollected));
      }
    }

    public Environment Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejects));
      }
    }

    public Environment Rejected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Rejected));
      }
    }

    public Environment SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
