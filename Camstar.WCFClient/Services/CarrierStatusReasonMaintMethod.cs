// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierStatusReasonMaintMethod
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
  public class CarrierStatusReasonMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public CarrierStatusReasonMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public CarrierStatusReasonMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public CarrierStatusReasonMaint_Parameters Parameters;

    public CarrierStatusReasonMaintMethod(
      CarrierStatusReasonMaint Cdo,
      CarrierStatusReasonMaintMethods Method,
      CarrierStatusReasonMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
