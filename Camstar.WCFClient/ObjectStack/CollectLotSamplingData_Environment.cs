// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectLotSamplingData_Environment
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
  public class CollectLotSamplingData_Environment : CollectSamplingData_Environment
  {
    [Metadata("Subclass of MfgLot used to associate a group of containers for sampling.  For example, an Incoming inspection lot where multiple containers are from the same lot of material, received at different times but has one AQL Sampling.", "SamplingLot", false, false, false, "NamedObjectRef", 16777719, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Environment_SamplingLot")]
    protected Environment _SamplingLot;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Environment_LotSampleDataItem")]
    [Metadata("Data used to track the current sample data for each sample test required for a SamplingLot.", "LotSampleData", false, false, false, "SubentityRef", 16777728, false, false, false, null)]
    protected Environment _LotSampleDataItem;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Environment_SamplingStatus")]
    [Metadata("SampleStatus", "SampleStatusEnum", false, false, false, "String", 1053155, false, false, false, null)]
    protected new Environment _SamplingStatus;
    [Metadata("Data used to track the current sample data for each sample test required for a SamplingLot.", "LotSampleData", false, false, false, "LotSampleData", 16777714, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Environment_LotSampleData")]
    protected LotSampleData_Environment _LotSampleData;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Environment_SamplingPlan")]
    [Metadata("Used to Define a sampling plan for a Product.  The sample plan contains the details about the Sample Test for a Product such as where it is to be tested, AQL Level, and switching rules.", "SamplingPlan", false, false, false, "RevisionedObjectRef", 1053112, false, false, true, null)]
    protected new Environment _SamplingPlan;
    [DataMember(EmitDefaultValue = false, Name = "CollectLotSamplingData_Environment_SamplingLotQty")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 16777729, false, false, false, null)]
    protected Environment _SamplingLotQty;

    public Environment SamplingLot
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

    public Environment LotSampleDataItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleDataItem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LotSampleDataItem));
      }
    }

    public new Environment SamplingStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingStatus));
      }
    }

    public LotSampleData_Environment LotSampleData
    {
      [param: In] set
      {
        this.PropertySet(nameof (LotSampleData), (object) value);
      }
      get
      {
        return (LotSampleData_Environment) this.PropertyGet(nameof (LotSampleData));
      }
    }

    public new Environment SamplingPlan
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingPlan), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingPlan));
      }
    }

    public Environment SamplingLotQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (SamplingLotQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SamplingLotQty));
      }
    }
  }
}
