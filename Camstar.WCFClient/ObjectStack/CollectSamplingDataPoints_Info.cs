// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataPoints_Info
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
  public class CollectSamplingDataPoints_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_SampleDataPoint")]
    protected Info _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_DataType")]
    protected Info _DataType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_DefaultValue")]
    protected Info _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_UpperLimit")]
    protected Info _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_LowerLimit")]
    protected Info _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Info_ShowLimits")]
    protected Info _ShowLimits;

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public Info SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Info DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataType));
      }
    }

    public Info DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public Info UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Info LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Info ShowLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowLimits), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowLimits));
      }
    }
  }
}
