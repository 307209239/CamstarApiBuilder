// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PhaseTemplateMaintMethod
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
  public class PhaseTemplateMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public PhaseTemplateMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public PhaseTemplateMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public PhaseTemplateMaint_Parameters Parameters;

    public PhaseTemplateMaintMethod(
      PhaseTemplateMaint Cdo,
      PhaseTemplateMaintMethods Method,
      PhaseTemplateMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
