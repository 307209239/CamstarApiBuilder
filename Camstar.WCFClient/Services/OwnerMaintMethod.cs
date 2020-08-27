// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OwnerMaintMethod
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
  public class OwnerMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public OwnerMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public OwnerMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public OwnerMaint_Parameters Parameters;

    public OwnerMaintMethod(
      OwnerMaint Cdo,
      OwnerMaintMethods Method,
      OwnerMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
