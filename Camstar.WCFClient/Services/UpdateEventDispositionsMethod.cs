// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventDispositionsMethod
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
  public class UpdateEventDispositionsMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public UpdateEventDispositions Cdo;
    [DataMember(EmitDefaultValue = false)]
    public UpdateEventDispositionsMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public UpdateEventDispositions_Parameters Parameters;

    public UpdateEventDispositionsMethod(
      UpdateEventDispositions Cdo,
      UpdateEventDispositionsMethods Method,
      UpdateEventDispositions_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
