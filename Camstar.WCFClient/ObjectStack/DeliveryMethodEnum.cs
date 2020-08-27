// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeliveryMethodEnum
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public enum DeliveryMethodEnum
  {
    [EnumMember, Enumeration("1"), Metadata("Generic Integer", "", false, false, true, "Integer", 1049963, false, false, false, "1")] Email = 1,
  }
}
