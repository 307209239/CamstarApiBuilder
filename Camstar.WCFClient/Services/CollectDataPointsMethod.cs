// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CollectDataPointsMethod
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class CollectDataPointsMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public CollectDataPoints Cdo;
    [DataMember(EmitDefaultValue = false)]
    public CollectDataPointsMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public CollectDataPoints_Parameters Parameters;

    public CollectDataPointsMethod(
      CollectDataPoints Cdo,
      CollectDataPointsMethods Method,
      CollectDataPoints_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
