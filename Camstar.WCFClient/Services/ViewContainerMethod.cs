// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ViewContainerMethod
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
  public class ViewContainerMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ViewContainer Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ViewContainerMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ViewContainer_Parameters Parameters;

    public ViewContainerMethod(
      ViewContainer Cdo,
      ViewContainerMethods Method,
      ViewContainer_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
