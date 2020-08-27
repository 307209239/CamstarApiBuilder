// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataPointLayoutEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DataPointLayoutEnum
  {
    [EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050889, false, false, false, "1"), Enumeration("1")] RowColumnPosition = 1,
    [Enumeration("2"), EnumMember, Metadata("Generic Integer", "", false, false, true, "Integer", 1050888, false, false, false, "2")] IterationGrid = 2,
  }
}
