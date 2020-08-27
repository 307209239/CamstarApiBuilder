// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartContAttrHistoryDetail_Environment
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
  public class StartContAttrHistoryDetail_Environment : ServiceHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [Metadata("A unique name for an attribute of a object.", "", false, false, true, "String", 1051934, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_Name")]
    protected Environment _Name;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1051936, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_AttributeValue")]
    protected Environment _AttributeValue;
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1051940, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_DataType")]
    protected Environment _DataType;
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1049097, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_HistoryId")]
    protected new Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_LevelName")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049278, false, false, false, null)]
    protected Environment _LevelName;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049088, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartContAttrHistoryDetail_Environment_ContainerName")]
    protected Environment _ContainerName;

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

    public Environment AttributeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttributeValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttributeValue));
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

    public Environment LevelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LevelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LevelName));
      }
    }

    public Environment ContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerName));
      }
    }
  }
}
