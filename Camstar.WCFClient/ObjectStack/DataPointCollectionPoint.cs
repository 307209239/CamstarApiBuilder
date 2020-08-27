// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionPoint
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
  public class DataPointCollectionPoint : DataPoint
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_DataType")]
    protected Enumeration<DataPointCollectionTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Samples")]
    protected DPCollectionPointSample[] _Samples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_InnerUpperLimit")]
    protected Primitive<string> _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_InnerLowerLimit")]
    protected Primitive<string> _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_OuterUpperLimit")]
    protected Primitive<string> _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_OuterLowerLimit")]
    protected Primitive<string> _OuterLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DataPointCollectionPoint && object.Equals((object) this._Sequence, (object) ((DataPointCollectionPoint) obj)._Sequence) && (object.Equals((object) this._UOM, (object) ((DataPointCollectionPoint) obj)._UOM) && object.Equals((object) this._DataType, (object) ((DataPointCollectionPoint) obj)._DataType)) && (this.CompareArrays((Array) this._Samples, (Array) ((DataPointCollectionPoint) obj)._Samples) && object.Equals((object) this._MinimumSamples, (object) ((DataPointCollectionPoint) obj)._MinimumSamples) && (object.Equals((object) this._InnerUpperLimit, (object) ((DataPointCollectionPoint) obj)._InnerUpperLimit) && object.Equals((object) this._InnerLowerLimit, (object) ((DataPointCollectionPoint) obj)._InnerLowerLimit))) && (object.Equals((object) this._OuterUpperLimit, (object) ((DataPointCollectionPoint) obj)._OuterUpperLimit) && object.Equals((object) this._OuterLowerLimit, (object) ((DataPointCollectionPoint) obj)._OuterLowerLimit) && object.Equals((object) this._Name, (object) ((DataPointCollectionPoint) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
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

    public Enumeration<DataPointCollectionTypeEnum, int> DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Enumeration<DataPointCollectionTypeEnum, int>) this.PropertyGet(nameof (DataType));
      }
    }

    public DPCollectionPointSample[] Samples
    {
      [param: In] set
      {
        this.PropertySet(nameof (Samples), (object) value);
      }
      get
      {
        return (DPCollectionPointSample[]) this.PropertyGet(nameof (Samples));
      }
    }

    public Primitive<int> MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public Primitive<string> InnerUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InnerUpperLimit));
      }
    }

    public Primitive<string> InnerLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InnerLowerLimit));
      }
    }

    public Primitive<string> OuterUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OuterUpperLimit));
      }
    }

    public Primitive<string> OuterLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OuterLowerLimit));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
