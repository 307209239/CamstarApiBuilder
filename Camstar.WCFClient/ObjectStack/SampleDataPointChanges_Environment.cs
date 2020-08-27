// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SampleDataPointChanges_Environment
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
  public class SampleDataPointChanges_Environment : RevisionedObjectChanges_Environment
  {
    [Metadata("The user code for unit of material.", "UOM", false, false, false, "NamedObjectRef", 1048629, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_UOM")]
    protected Environment _UOM;
    [Metadata("Object used for defining a reusable data points.", "SampleDataPointBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_Base")]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_ObjectToChange")]
    [Metadata("Object used for defining a reusable data points.", "SampleDataPoint", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_DataType")]
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, true, false, "Integer", 1049990, false, false, true, null)]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_DefaultValue")]
    [Metadata("Generic String", "", false, false, false, "String", 1051014, false, false, false, null)]
    protected Environment _DefaultValue;
    [Metadata("Generic String", "", false, false, false, "String", 1050532, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_UpperLimit")]
    protected Environment _UpperLimit;
    [Metadata("Generic String", "", false, false, false, "String", 1050533, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_LowerLimit")]
    protected Environment _LowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_ShowLimits")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053122, false, false, false, "0")]
    protected Environment _ShowLimits;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053123, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SampleDataPointChanges_Environment_Name")]
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

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
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
