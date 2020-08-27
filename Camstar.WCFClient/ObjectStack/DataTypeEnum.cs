// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DataTypeEnum
  {
    [Enumeration("1"), Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049983, false, false, false, "1"), EnumMember] Integer = 1,
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049984, false, false, false, "2"), EnumMember, Enumeration("2")] Float = 2,
    [EnumMember, Enumeration("3"), Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049985, false, false, false, "3")] Fixed = 3,
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049986, false, false, false, "4"), EnumMember, Enumeration("4")] String = 4,
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049474, false, false, false, "5"), Enumeration("5"), EnumMember] Object = 5,
    [EnumMember, Enumeration("6"), Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049987, false, false, false, "6")] Timestamp = 6,
    [Enumeration("7"), EnumMember, Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049988, false, false, false, "7")] Boolean = 7,
    [EnumMember, Enumeration("9"), Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1049989, false, false, false, "9")] Decimal = 9,
  }
}
