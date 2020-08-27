// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UserQueryMaintMethod
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
  public class UserQueryMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public UserQueryMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public UserQueryMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public UserQueryMaint_Parameters Parameters;

    public UserQueryMaintMethod(
      UserQueryMaint Cdo,
      UserQueryMaintMethods Method,
      UserQueryMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
