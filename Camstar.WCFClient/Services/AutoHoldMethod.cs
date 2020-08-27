// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AutoHoldMethod
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
  public class AutoHoldMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public AutoHold Cdo;
    [DataMember(EmitDefaultValue = false)]
    public AutoHoldMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public AutoHold_Parameters Parameters;

    public AutoHoldMethod(AutoHold Cdo, AutoHoldMethods Method, AutoHold_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
