// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionPointChgs_Environment
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
  public class DataPointCollectionPointChgs_Environment : DataPointChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    protected Environment _UOM;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, false, "Integer", 1049990, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_DataType")]
    protected new Environment _DataType;
    [Metadata("Describes a piece of data to be collected, including limits.  The user entering the data can dynamically add extra samples as well as dynamically adding new data points.", "DataPointCollectionPointChgs", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("Describes a piece of data to be collected, including limits.  The user entering the data can dynamically add extra samples as well as dynamically adding new data points.", "DataPointCollectionPoint", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_OuterLowerLimit")]
    [Metadata("Generic String", "", false, false, false, "String", 1052449, false, false, false, null)]
    protected Environment _OuterLowerLimit;
    [Metadata("Generic String", "", false, false, false, "String", 1052447, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_InnerLowerLimit")]
    protected Environment _InnerLowerLimit;
    [Metadata("Generic String", "", false, false, false, "String", 1052450, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_OuterUpperLimit")]
    protected Environment _OuterUpperLimit;
    [Metadata("Generic String", "", false, false, false, "String", 1052448, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_InnerUpperLimit")]
    protected Environment _InnerUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_MinimumSamples")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052428, false, false, false, null)]
    protected Environment _MinimumSamples;
    [DataMember(EmitDefaultValue = false, Name = "DataPointCollectionPointChgs_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050528, false, false, false, null)]
    protected new Environment _Name;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
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
