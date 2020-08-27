// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ParametricData_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DataPointSummary_Info))]
  [KnownType(typeof (DPCollection_Info))]
  [KnownType(typeof (DataPointDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ParametricData_Info : ServiceDetails_Info
  {
  }
}
