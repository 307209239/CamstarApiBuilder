// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataDetails
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
  public class CollectSamplingDataDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_CountedRejectReason")]
    protected NamedObjectRef _CountedRejectReason;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_SampleTest")]
    protected RevisionedObjectRef _SampleTest;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_SamplingDataPointDetails")]
    protected Camstar.WCF.ObjectStack.SamplingDataPointDetails[] _SamplingDataPointDetails;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_CollectSamplingTestDtlHistory")]
    protected SubentityRef[] _CollectSamplingTestDtlHistory;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_TotalSamplesCollected")]
    protected Primitive<int> _TotalSamplesCollected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Rejects")]
    protected Primitive<int> _Rejects;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_Rejected")]
    protected Primitive<bool> _Rejected;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataDetails_SampleTestName")]
    protected Primitive<string> _SampleTestName;

    public override bool Equals(object obj)
    {
      return obj is CollectSamplingDataDetails && object.Equals((object) this._CountedRejectReason, (object) ((CollectSamplingDataDetails) obj)._CountedRejectReason) && (object.Equals((object) this._SampleTest, (object) ((CollectSamplingDataDetails) obj)._SampleTest) && this.CompareArrays((Array) this._SamplingDataPointDetails, (Array) ((CollectSamplingDataDetails) obj)._SamplingDataPointDetails)) && (this.CompareArrays((Array) this._CollectSamplingTestDtlHistory, (Array) ((CollectSamplingDataDetails) obj)._CollectSamplingTestDtlHistory) && object.Equals((object) this._TotalSamplesCollected, (object) ((CollectSamplingDataDetails) obj)._TotalSamplesCollected) && (object.Equals((object) this._Rejects, (object) ((CollectSamplingDataDetails) obj)._Rejects) && object.Equals((object) this._Rejected, (object) ((CollectSamplingDataDetails) obj)._Rejected))) && object.Equals((object) this._SampleTestName, (object) ((CollectSamplingDataDetails) obj)._SampleTestName) && base.Equals(obj);
    }

    public NamedObjectRef CountedRejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CountedRejectReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CountedRejectReason));
      }
    }

    public RevisionedObjectRef SampleTest
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTest), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SampleTest));
      }
    }

    public Camstar.WCF.ObjectStack.SamplingDataPointDetails[] SamplingDataPointDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingDataPointDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.SamplingDataPointDetails[]) this.PropertyGet(nameof (SamplingDataPointDetails));
      }
    }

    public SubentityRef[] CollectSamplingTestDtlHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectSamplingTestDtlHistory), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (CollectSamplingTestDtlHistory));
      }
    }

    public Primitive<int> TotalSamplesCollected
    {
      [param: In] set
      {
        this.PropertySet(nameof (TotalSamplesCollected), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TotalSamplesCollected));
      }
    }

    public Primitive<int> Rejects
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejects), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Rejects));
      }
    }

    public Primitive<bool> Rejected
    {
      [param: In] set
      {
        this.PropertySet(nameof (Rejected), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Rejected));
      }
    }

    public Primitive<string> SampleTestName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleTestName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SampleTestName));
      }
    }
  }
}
