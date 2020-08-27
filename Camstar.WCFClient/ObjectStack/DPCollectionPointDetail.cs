// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionPointDetail
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
  public class DPCollectionPointDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Point")]
    protected NamedSubentityRef _Point;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Samples")]
    protected DPCollectionSampleDetail[] _Samples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_DataType")]
    protected Enumeration<DataPointCollectionTypeEnum, int> _DataType;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_InnerUpperLimit")]
    protected Primitive<string> _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_MinimumSamples")]
    protected Primitive<int> _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_OuterLowerLimit")]
    protected Primitive<string> _OuterLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_InnerLowerLimit")]
    protected Primitive<string> _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_OuterUpperLimit")]
    protected Primitive<string> _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is DPCollectionPointDetail && object.Equals((object) this._UOM, (object) ((DPCollectionPointDetail) obj)._UOM) && (object.Equals((object) this._Sequence, (object) ((DPCollectionPointDetail) obj)._Sequence) && object.Equals((object) this._Point, (object) ((DPCollectionPointDetail) obj)._Point)) && (this.CompareArrays((Array) this._Samples, (Array) ((DPCollectionPointDetail) obj)._Samples) && object.Equals((object) this._DataType, (object) ((DPCollectionPointDetail) obj)._DataType) && (object.Equals((object) this._InnerUpperLimit, (object) ((DPCollectionPointDetail) obj)._InnerUpperLimit) && object.Equals((object) this._MinimumSamples, (object) ((DPCollectionPointDetail) obj)._MinimumSamples))) && (object.Equals((object) this._OuterLowerLimit, (object) ((DPCollectionPointDetail) obj)._OuterLowerLimit) && object.Equals((object) this._InnerLowerLimit, (object) ((DPCollectionPointDetail) obj)._InnerLowerLimit) && (object.Equals((object) this._OuterUpperLimit, (object) ((DPCollectionPointDetail) obj)._OuterUpperLimit) && object.Equals((object) this._Name, (object) ((DPCollectionPointDetail) obj)._Name))) && base.Equals(obj);
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

    public NamedSubentityRef Point
    {
      [param: In] set
      {
        this.PropertySet(nameof (Point), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Point));
      }
    }

    public DPCollectionSampleDetail[] Samples
    {
      [param: In] set
      {
        this.PropertySet(nameof (Samples), (object) value);
      }
      get
      {
        return (DPCollectionSampleDetail[]) this.PropertyGet(nameof (Samples));
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

    public Primitive<string> Name
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
