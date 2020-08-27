// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DesignateProcessObjectMethod
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
  public class DesignateProcessObjectMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public DesignateProcessObject Cdo;
    [DataMember(EmitDefaultValue = false)]
    public DesignateProcessObjectMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public DesignateProcessObject_Parameters Parameters;

    public DesignateProcessObjectMethod(
      DesignateProcessObject Cdo,
      DesignateProcessObjectMethods Method,
      DesignateProcessObject_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
