// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SPCChartDefMaintMethod
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
  public class SPCChartDefMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public SPCChartDefMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public SPCChartDefMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public SPCChartDefMaint_Parameters Parameters;

    public SPCChartDefMaintMethod(
      SPCChartDefMaint Cdo,
      SPCChartDefMaintMethods Method,
      SPCChartDefMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
