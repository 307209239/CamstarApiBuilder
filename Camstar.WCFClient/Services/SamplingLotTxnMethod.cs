// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SamplingLotTxnMethod
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
  public class SamplingLotTxnMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public SamplingLotTxn Cdo;
    [DataMember(EmitDefaultValue = false)]
    public SamplingLotTxnMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public SamplingLotTxn_Parameters Parameters;

    public SamplingLotTxnMethod(
      SamplingLotTxn Cdo,
      SamplingLotTxnMethods Method,
      SamplingLotTxn_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
