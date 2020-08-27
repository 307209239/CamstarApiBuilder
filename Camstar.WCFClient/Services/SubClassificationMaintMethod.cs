// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SubClassificationMaintMethod
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
  public class SubClassificationMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public SubClassificationMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public SubClassificationMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public SubClassificationMaint_Parameters Parameters;

    public SubClassificationMaintMethod(
      SubClassificationMaint Cdo,
      SubClassificationMaintMethods Method,
      SubClassificationMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
