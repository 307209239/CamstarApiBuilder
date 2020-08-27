// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReportMappingConfigMaintMethod
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
  public class ReportMappingConfigMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ReportMappingConfigMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ReportMappingConfigMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ReportMappingConfigMaint_Parameters Parameters;

    public ReportMappingConfigMaintMethod(
      ReportMappingConfigMaint Cdo,
      ReportMappingConfigMaintMethods Method,
      ReportMappingConfigMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
