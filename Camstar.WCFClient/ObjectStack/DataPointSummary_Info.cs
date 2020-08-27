// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointSummary_Info
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
  public class DataPointSummary_Info : ParametricData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_Info_DataPointLayout")]
    protected Info _DataPointLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_Info_DataPointDetails")]
    protected DataPointDetails_Info _DataPointDetails;
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_Info_OverrideDataPointLimits")]
    protected Info _OverrideDataPointLimits;

    public Info DataPointLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointLayout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataPointLayout));
      }
    }

    public DataPointDetails_Info DataPointDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointDetails), (object) value);
      }
      get
      {
        return (DataPointDetails_Info) this.PropertyGet(nameof (DataPointDetails));
      }
    }

    public Info OverrideDataPointLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideDataPointLimits), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OverrideDataPointLimits));
      }
    }
  }
}
