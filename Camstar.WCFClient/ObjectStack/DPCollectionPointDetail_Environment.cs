// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionPointDetail_Environment
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
  public class DPCollectionPointDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_Point")]
    [Metadata("Describes a piece of data to be collected, including limits.  The user entering the data can dynamically add extra samples as well as dynamically adding new data points.", "DataPointCollectionPoint", false, false, false, "NamedSubentityRef", 1052460, false, false, false, null)]
    protected Environment _Point;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_Samples")]
    [Metadata("The DPCollectionSampleDetail is used to collect a single data value for a data point within a DataPointCollectionDef.", "DPCollectionSampleDetail", false, false, false, "DPCollectionSampleDetail", 1052461, false, true, false, null)]
    protected DPCollectionSampleDetail_Environment _Samples;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_DataType")]
    [Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, false, "Integer", 1049990, false, false, false, null)]
    protected Environment _DataType;
    [Metadata("Generic String", "", false, false, false, "String", 1052448, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_InnerUpperLimit")]
    protected Environment _InnerUpperLimit;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052428, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_MinimumSamples")]
    protected Environment _MinimumSamples;
    [Metadata("Generic String", "", false, false, false, "String", 1052449, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_OuterLowerLimit")]
    protected Environment _OuterLowerLimit;
    [Metadata("Generic String", "", false, false, false, "String", 1052447, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_InnerLowerLimit")]
    protected Environment _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_OuterUpperLimit")]
    [Metadata("Generic String", "", false, false, false, "String", 1052450, false, false, false, null)]
    protected Environment _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointDetail_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    protected Environment _Name;

    public Environment UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UOM));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment Point
    {
      [param: In] set
      {
        this.PropertySet(nameof (Point), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Point));
      }
    }

    public DPCollectionSampleDetail_Environment Samples
    {
      [param: In] set
      {
        this.PropertySet(nameof (Samples), (object) value);
      }
      get
      {
        return (DPCollectionSampleDetail_Environment) this.PropertyGet(nameof (Samples));
      }
    }

    public Environment DataType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType));
      }
    }

    public Environment InnerUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerUpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InnerUpperLimit));
      }
    }

    public Environment MinimumSamples
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinimumSamples), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinimumSamples));
      }
    }

    public Environment OuterLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterLowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OuterLowerLimit));
      }
    }

    public Environment InnerLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (InnerLowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InnerLowerLimit));
      }
    }

    public Environment OuterUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (OuterUpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OuterUpperLimit));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
