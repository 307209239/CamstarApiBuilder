// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventMethod
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
  public class UpdateEventMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public UpdateEvent Cdo;
    [DataMember(EmitDefaultValue = false)]
    public UpdateEventMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public UpdateEvent_Parameters Parameters;

    public UpdateEventMethod(
      UpdateEvent Cdo,
      UpdateEventMethods Method,
      UpdateEvent_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
