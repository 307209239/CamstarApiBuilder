// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EMailDistributionMaintMethod
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
  public class EMailDistributionMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public EMailDistributionMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public EMailDistributionMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public EMailDistributionMaint_Parameters Parameters;

    public EMailDistributionMaintMethod(
      EMailDistributionMaint Cdo,
      EMailDistributionMaintMethods Method,
      EMailDistributionMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
