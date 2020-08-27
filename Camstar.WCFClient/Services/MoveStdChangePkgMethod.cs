// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveStdChangePkgMethod
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
  public class MoveStdChangePkgMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public MoveStdChangePkg Cdo;
    [DataMember(EmitDefaultValue = false)]
    public MoveStdChangePkgMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public MoveStdChangePkg_Parameters Parameters;

    public MoveStdChangePkgMethod(
      MoveStdChangePkg Cdo,
      MoveStdChangePkgMethods Method,
      MoveStdChangePkg_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
