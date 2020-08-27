// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.TrainingPlanMaintMethod
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
  public class TrainingPlanMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public TrainingPlanMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public TrainingPlanMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public TrainingPlanMaint_Parameters Parameters;

    public TrainingPlanMaintMethod(
      TrainingPlanMaint Cdo,
      TrainingPlanMaintMethods Method,
      TrainingPlanMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
