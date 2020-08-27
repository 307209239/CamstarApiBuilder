// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShipMethod
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
  public class ShipMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public Ship Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ShipMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public Ship_Parameters Parameters;

    public ShipMethod(Ship Cdo, ShipMethods Method, Ship_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
