// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteRecipeTaskMethod
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
  public class ExecuteRecipeTaskMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ExecuteRecipeTask Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ExecuteRecipeTaskMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ExecuteRecipeTask_Parameters Parameters;

    public ExecuteRecipeTaskMethod(
      ExecuteRecipeTask Cdo,
      ExecuteRecipeTaskMethods Method,
      ExecuteRecipeTask_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
