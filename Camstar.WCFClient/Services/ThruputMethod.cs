// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ThruputMethod
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
  public class ThruputMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public Thruput Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ThruputMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public Thruput_Parameters Parameters;

    public ThruputMethod(Thruput Cdo, ThruputMethods Method, Thruput_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
