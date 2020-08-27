// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollectSamplingDataPoints_Environment
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
  public class CollectSamplingDataPoints_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_UOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1048629, false, false, false, null)]
    protected Environment _UOM;
    [Metadata("Object used for defining a reusable data points.", "SampleDataPoint", false, false, true, "RevisionedObjectRef", 1053159, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_SampleDataPoint")]
    protected Environment _SampleDataPoint;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_DataType")]
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_DefaultValue")]
    [Metadata("Generic String", "", false, false, true, "String", 1051014, false, false, false, null)]
    protected Environment _DefaultValue;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_UpperLimit")]
    [Metadata("Generic String", "", false, false, true, "String", 1050532, false, false, false, null)]
    protected Environment _UpperLimit;
    [Metadata("Generic String", "", false, false, true, "String", 1050533, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_LowerLimit")]
    protected Environment _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "CollectSamplingDataPoints_Environment_ShowLimits")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053122, false, false, false, "0")]
    protected Environment _ShowLimits;

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

    public Environment SampleDataPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleDataPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SampleDataPoint));
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

    public Environment DefaultValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultValue));
      }
    }

    public Environment UpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (UpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UpperLimit));
      }
    }

    public Environment LowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (LowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LowerLimit));
      }
    }

    public Environment ShowLimits
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowLimits), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowLimits));
      }
    }
  }
}
