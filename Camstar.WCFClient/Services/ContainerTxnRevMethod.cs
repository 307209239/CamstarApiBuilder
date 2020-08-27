// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerTxnRevMethod
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
  public class ContainerTxnRevMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ContainerTxnRev Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ContainerTxnRevMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ContainerTxnRev_Parameters Parameters;

    public ContainerTxnRevMethod(
      ContainerTxnRev Cdo,
      ContainerTxnRevMethods Method,
      ContainerTxnRev_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
