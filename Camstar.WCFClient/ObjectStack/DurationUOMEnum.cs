// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DurationUOMEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DurationUOMEnum
  {
    [Metadata("Generic Decimal.  The decimal data type is a fixed point type, an exact numeric value as opposed to an approximate numeric type like float or real.  It is defined by a precision and scale.  The precision p refers to the overall number of digits both to the left and right of the decimal point.  The scale s refers to the number of digits to the right of the decimal point, also referred to as fractional component.", "", false, false, false, "String", 1051360, false, false, false, "1"), EnumMember, Enumeration("1")] Hours = 1,
    [Metadata("Generic Decimal.  The decimal data type is a fixed point type, an exact numeric value as opposed to an approximate numeric type like float or real.  It is defined by a precision and scale.  The precision p refers to the overall number of digits both to the left and right of the decimal point.  The scale s refers to the number of digits to the right of the decimal point, also referred to as fractional component.", "", false, false, false, "String", 1051359, false, false, false, "24"), EnumMember, Enumeration("24")] Days = 24, // 0x00000018
    [Metadata("Generic Decimal.  The decimal data type is a fixed point type, an exact numeric value as opposed to an approximate numeric type like float or real.  It is defined by a precision and scale.  The precision p refers to the overall number of digits both to the left and right of the decimal point.  The scale s refers to the number of digits to the right of the decimal point, also referred to as fractional component.", "", false, false, false, "String", 1051361, false, false, false, "168"), Enumeration("168"), EnumMember] Weeks = 168, // 0x000000A8
  }
}
