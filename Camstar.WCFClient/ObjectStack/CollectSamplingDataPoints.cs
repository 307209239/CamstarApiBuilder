// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataPoints
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
  public class CollectSamplingDataPoints : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_SampleDataPoint")]
    protected RevisionedObjectRef _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_DataType")]
    protected Enumeration<TrivialTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_DefaultValue")]
    protected Primitive<string> _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_UpperLimit")]
    protected Primitive<string> _UpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_LowerLimit")]
    protected Primitive<string> _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_ShowLimits")]
    protected Primitive<bool> _ShowLimits;

    public override bool Equals(object obj)
    {
      return obj is CollectSamplingDataPoints && object.Equals((object) this._UOM, (object) ((CollectSamplingDataPoints) obj)._UOM) && (object.Equals((object) this._SampleDataPoint, (object) ((CollectSamplingDataPoints) obj)._SampleDataPoint) && object.Equals((object) this._DataType, (object) ((CollectSamplingDataPoints) obj)._DataType)) && (object.Equals((object) this._DefaultValue, (object) ((CollectSamplingDataPoints) obj)._DefaultValue) && object.Equals((object) this._UpperLimit, (object) ((CollectSamplingDataPoints) obj)._UpperLimit) && (object.Equals((object) this._LowerLimit, (object) ((CollectSamplingDataPoints) obj)._LowerLimit) && object.Equals((object) this._ShowLimits, (object) ((CollectSamplingDataPoints) obj)._ShowLimits))) && base.Equals(obj);
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public RevisionedObjectRef SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (SampleDataPoint));
      }
    }

    public Enumeration<TrivialTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<TrivialTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public Primitive<string> DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public Primitive<string> UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Primitive<string> LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Primitive<bool> ShowLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowLimits), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowLimits));
      }
    }
  }
}
