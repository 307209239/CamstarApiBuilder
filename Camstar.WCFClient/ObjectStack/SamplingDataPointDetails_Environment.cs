// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SamplingDataPointDetails_Environment
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
  public class SamplingDataPointDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Environment_RejectReason")]
    [Metadata("The user code for loss reason.", "LossReason", false, false, false, "NamedObjectRef", 1053152, false, false, true, null)]
    protected Environment _RejectReason;
    [Metadata("Object used for defining a reusable data points.", "SampleDataPoint", false, false, false, "RevisionedObjectRef", 1053159, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Environment_SampleDataPoint")]
    protected Environment _SampleDataPoint;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053116, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Environment_Passed")]
    protected Environment _Passed;
    [DataMember(EmitDefaultValue = false, Name = "SamplingDataPointDetails_Environment_DataValue")]
    [Metadata("Generic String", "", false, false, false, "String", 1052459, false, false, false, null)]
    protected Environment _DataValue;

    public Environment RejectReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RejectReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RejectReason));
      }
    }

    public Environment SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Environment Passed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Passed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Passed));
      }
    }

    public Environment DataValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataValue));
      }
    }
  }
}
