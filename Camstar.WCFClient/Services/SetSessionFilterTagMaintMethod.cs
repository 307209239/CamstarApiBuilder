// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SetSessionFilterTagMaintMethod
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
  public class SetSessionFilterTagMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public SetSessionFilterTagMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public SetSessionFilterTagMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public SetSessionFilterTagMaint_Parameters Parameters;

    public SetSessionFilterTagMaintMethod(
      SetSessionFilterTagMaint Cdo,
      SetSessionFilterTagMaintMethods Method,
      SetSessionFilterTagMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
