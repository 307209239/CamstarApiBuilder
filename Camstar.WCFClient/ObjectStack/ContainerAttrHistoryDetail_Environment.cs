// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrHistoryDetail_Environment
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
  public class ContainerAttrHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_AttributeName_After")]
    [Metadata("A unique name for an attribute of a object.", "", false, false, true, "String", 1051947, false, false, false, null)]
    protected Environment _AttributeName_After;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_AttributeName_Before")]
    [Metadata("A unique name for an attribute of a object.", "", false, false, true, "String", 1051946, false, false, false, null)]
    protected Environment _AttributeName_Before;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1051948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_AttributeValue_Before")]
    protected Environment _AttributeValue_Before;
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1051951, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_DataType_After")]
    protected Environment _DataType_After;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1051949, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_AttributeValue_After")]
    protected Environment _AttributeValue_After;
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1051950, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_DataType_Before")]
    protected Environment _DataType_Before;
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrHistoryDetail_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    protected new Environment _HistoryId;

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

    public Environment AttributeName_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName_After), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeName_After));
      }
    }

    public Environment AttributeName_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeName_Before), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeName_Before));
      }
    }

    public Environment AttributeValue_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue_Before), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeValue_Before));
      }
    }

    public Environment DataType_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType_After), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType_After));
      }
    }

    public Environment AttributeValue_After
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue_After), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeValue_After));
      }
    }

    public Environment DataType_Before
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataType_Before), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataType_Before));
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
  }
}
