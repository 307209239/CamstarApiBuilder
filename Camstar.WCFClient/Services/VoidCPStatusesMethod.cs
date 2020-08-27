// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.VoidCPStatusesMethod
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
  public class VoidCPStatusesMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public VoidCPStatuses Cdo;
    [DataMember(EmitDefaultValue = false)]
    public VoidCPStatusesMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public VoidCPStatuses_Parameters Parameters;

    public VoidCPStatusesMethod(
      VoidCPStatuses Cdo,
      VoidCPStatusesMethods Method,
      VoidCPStatuses_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
