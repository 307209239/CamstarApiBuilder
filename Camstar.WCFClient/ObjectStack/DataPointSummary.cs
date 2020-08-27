// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointSummary
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
  public class DataPointSummary : ParametricData
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_DataPointLayout")]
    protected Enumeration<DataPointLayoutEnum, int> _DataPointLayout;
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_DataPointDetails")]
    protected Camstar.WCF.ObjectStack.DataPointDetails[] _DataPointDetails;
    [DataMember(EmitDefaultValue = false, Name = "DataPointSummary_OverrideDataPointLimits")]
    protected Primitive<bool> _OverrideDataPointLimits;

    public override bool Equals(object obj)
    {
      return obj is DataPointSummary && object.Equals((object) this._DataPointLayout, (object) ((DataPointSummary) obj)._DataPointLayout) && (this.CompareArrays((Array) this._DataPointDetails, (Array) ((DataPointSummary) obj)._DataPointDetails) && object.Equals((object) this._OverrideDataPointLimits, (object) ((DataPointSummary) obj)._OverrideDataPointLimits)) && base.Equals(obj);
    }

    public Enumeration<DataPointLayoutEnum, int> DataPointLayout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointLayout), (object) value);
      }
      get
      {
        return (Enumeration<DataPointLayoutEnum, int>) this.PropertyGet(nameof (DataPointLayout));
      }
    }

    public Camstar.WCF.ObjectStack.DataPointDetails[] DataPointDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataPointDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.DataPointDetails[]) this.PropertyGet(nameof (DataPointDetails));
      }
    }

    public Primitive<bool> OverrideDataPointLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (OverrideDataPointLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OverrideDataPointLimits));
      }
    }
  }
}
