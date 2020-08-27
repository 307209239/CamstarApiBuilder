// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WorkCenterMaintMethod
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
  public class WorkCenterMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public WorkCenterMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public WorkCenterMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public WorkCenterMaint_Parameters Parameters;

    public WorkCenterMaintMethod(
      WorkCenterMaint Cdo,
      WorkCenterMaintMethods Method,
      WorkCenterMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
