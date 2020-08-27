// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerDefectReasonMaintMethod
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
  public class ContainerDefectReasonMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ContainerDefectReasonMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ContainerDefectReasonMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ContainerDefectReasonMaint_Parameters Parameters;

    public ContainerDefectReasonMaintMethod(
      ContainerDefectReasonMaint Cdo,
      ContainerDefectReasonMaintMethods Method,
      ContainerDefectReasonMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
