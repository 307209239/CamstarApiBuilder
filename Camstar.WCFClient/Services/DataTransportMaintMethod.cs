// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DataTransportMaintMethod
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
  public class DataTransportMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public DataTransportMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public DataTransportMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public DataTransportMaint_Parameters Parameters;

    public DataTransportMaintMethod(
      DataTransportMaint Cdo,
      DataTransportMaintMethods Method,
      DataTransportMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
