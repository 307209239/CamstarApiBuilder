// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComputationParamHistory_Environment
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
  public class ComputationParamHistory_Environment : ServiceHistoryDetail_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Environment_DataType")]
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049990, false, false, false, null)]
    protected Environment _DataType;
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Environment_ParamValue")]
    [Metadata("ComputationValue", "", false, false, true, "String", 1051022, false, false, false, null)]
    protected Environment _ParamValue;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComputationParamHistory_Environment_ParamName")]
    protected Environment _ParamName;

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

    public Environment ParamValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParamValue));
      }
    }

    public Environment ParamName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParamName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParamName));
      }
    }
  }
}
