// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DetachSingleCPContentMethod
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
  public class DetachSingleCPContentMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public DetachSingleCPContent Cdo;
    [DataMember(EmitDefaultValue = false)]
    public DetachSingleCPContentMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public DetachSingleCPContent_Parameters Parameters;

    public DetachSingleCPContentMethod(
      DetachSingleCPContent Cdo,
      DetachSingleCPContentMethods Method,
      DetachSingleCPContent_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
