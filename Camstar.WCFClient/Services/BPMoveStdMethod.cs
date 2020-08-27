// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BPMoveStdMethod
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
  public class BPMoveStdMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public BPMoveStd Cdo;
    [DataMember(EmitDefaultValue = false)]
    public BPMoveStdMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public BPMoveStd_Parameters Parameters;

    public BPMoveStdMethod(BPMoveStd Cdo, BPMoveStdMethods Method, BPMoveStd_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
