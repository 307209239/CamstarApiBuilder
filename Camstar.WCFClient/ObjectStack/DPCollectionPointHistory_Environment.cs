// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DPCollectionPointHistory_Environment
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
  public class DPCollectionPointHistory_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    protected Environment _UOM;
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_DataType")]
    [Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1052464, false, false, false, null)]
    protected Environment _DataType;
    [Metadata("Describes a piece of data to be collected, including limits.  The user entering the data can dynamically add extra samples as well as dynamically adding new data points.", "DataPointCollectionPoint", false, false, true, "NamedSubentityRef", 1052460, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_Point")]
    protected Environment _Point;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_HistoryDetails")]
    [Metadata("The history for the data point collection samples. Contains values of the data point.", "DPCollectionSampleHistory", false, false, true, "SubentityRef", 1052465, false, true, false, null)]
    protected Environment _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_MinimumSamples")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052428, false, false, false, null)]
    protected Environment _MinimumSamples;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [Metadata("Generic String", "", false, false, true, "String", 1052450, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_OuterUpperLimit")]
    protected Environment _OuterUpperLimit;
    [Metadata("Generic String", "", false, false, true, "String", 1052447, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_InnerLowerLimit")]
    protected Environment _InnerLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_OuterLowerLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1052449, false, false, false, null)]
    protected Environment _OuterLowerLimit;
    [Metadata("Generic String", "", false, false, true, "String", 1052448, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_InnerUpperLimit")]
    protected Environment _InnerUpperLimit;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DPCollectionPointHistory_Environment_Name")]
    protected Environment _Name;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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

    public Environment HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryDetails));
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

    public new Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
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
