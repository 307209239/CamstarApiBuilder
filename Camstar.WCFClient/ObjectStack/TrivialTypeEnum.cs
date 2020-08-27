// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrivialTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum TrivialTypeEnum
  {
    [EnumMember, Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049983, false, false, false, "1"), Enumeration("1")] Integer = 1,
    [Enumeration("2"), Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049984, false, false, false, "2"), EnumMember] Float = 2,
    [Enumeration("3"), EnumMember, Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049985, false, false, false, "3")] Fixed = 3,
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049986, false, false, false, "4"), EnumMember, Enumeration("4")] String = 4,
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049987, false, false, false, "6"), Enumeration("6"), EnumMember] Timestamp = 6,
    [EnumMember, Enumeration("7"), Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049988, false, false, false, "7")] Boolean = 7,
    [Metadata("All non-object data types.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "TrivialTypeEnum", false, false, true, "Integer", 1049989, false, false, false, "9"), EnumMember, Enumeration("9")] Decimal = 9,
  }
}
