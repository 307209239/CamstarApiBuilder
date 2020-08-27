// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointSummary_Environment
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
  public class DataPointSummary_Environment : ParametricData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_Environment_DataPointLayout")]
    [Metadata("DataPointLayout", "DataPointLayoutEnum", false, false, true, "Integer", 1050890, false, false, false, null)]
    protected Environment _DataPointLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_Environment_DataPointDetails")]
    [Metadata("The history of the DataPoints collected for a DataPointCollectionDef.", "DataPointDetails", false, false, false, "DataPointDetails", 1050545, false, true, false, null)]
    protected DataPointDetails_Environment _DataPointDetails;
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_Environment_OverrideDataPointLimits")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050891, false, false, false, "0")]
    protected Environment _OverrideDataPointLimits;

    public Environment DataPointLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointLayout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataPointLayout));
      }
    }

    public DataPointDetails_Environment DataPointDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointDetails), (object) value);
      }
      get
      {
        return (DataPointDetails_Environment) this.PropertyGet(nameof (DataPointDetails));
      }
    }

    public Environment OverrideDataPointLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideDataPointLimits), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OverrideDataPointLimits));
      }
    }
  }
}
