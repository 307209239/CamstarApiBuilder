// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionPoint_Environment
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
  public class DataPointCollectionPoint_Environment : DataPoint_Environment
  {
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_DataType")]
    [Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    protected new Environment _DataType;
    [Metadata("A sample collected for the Data Point.", "DPCollectionPointSample", false, false, true, "DPCollectionPointSample", 1052461, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_Samples")]
    protected DPCollectionPointSample_Environment _Samples;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052428, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_MinimumSamples")]
    protected Environment _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_InnerUpperLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1052448, false, false, false, null)]
    protected Environment _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_InnerLowerLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1052447, false, false, false, null)]
    protected Environment _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_OuterUpperLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1052450, false, false, false, null)]
    protected Environment _OuterUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_OuterLowerLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1052449, false, false, false, null)]
    protected Environment _OuterLowerLimit;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050528, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPoint_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment DataType
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

    public DPCollectionPointSample_Environment Samples
    {
      [param: In] set
      {
        this.PropertySet(nameof (Samples), (object) value);
      }
      get
      {
        return (DPCollectionPointSample_Environment) this.PropertyGet(nameof (Samples));
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

    public new Environment Name
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
