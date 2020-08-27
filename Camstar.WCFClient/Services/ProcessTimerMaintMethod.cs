// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessTimerMaintMethod
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
  public class ProcessTimerMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ProcessTimerMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ProcessTimerMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ProcessTimerMaint_Parameters Parameters;

    public ProcessTimerMaintMethod(
      ProcessTimerMaint Cdo,
      ProcessTimerMaintMethods Method,
      ProcessTimerMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
