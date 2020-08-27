// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointCollectionTypeEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DataPointCollectionTypeEnum
  {
    [EnumMember, Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1049983, false, false, false, "1"), Enumeration("1")] Integer = 1,
    [Enumeration("4"), Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1049986, false, false, false, "4"), EnumMember] String = 4,
    [Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1049987, false, false, false, "6"), EnumMember, Enumeration("6")] Timestamp = 6,
    [EnumMember, Enumeration("7"), Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1049988, false, false, false, "7")] Boolean = 7,
    [Metadata("The Data Point Collection data type:\r\n1\tInteger\r\n4\tString\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal", "DataPointCollectionTypeEnum", false, false, true, "Integer", 1049989, false, false, false, "9"), EnumMember, Enumeration("9")] Decimal = 9,
  }
}
