// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ParametricData_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DataPointDetails_Environment))]
  [KnownType(typeof (DataPointSummary_Environment))]
  [KnownType(typeof (DPCollection_Environment))]
  [Serializable]
  public class ParametricData_Environment : ServiceDetails_Environment
  {
  }
}
