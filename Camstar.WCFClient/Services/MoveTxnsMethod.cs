// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveTxnsMethod
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
  public class MoveTxnsMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public MoveTxns Cdo;
    [DataMember(EmitDefaultValue = false)]
    public MoveTxnsMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public MoveTxns_Parameters Parameters;

    public MoveTxnsMethod(MoveTxns Cdo, MoveTxnsMethods Method, MoveTxns_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
