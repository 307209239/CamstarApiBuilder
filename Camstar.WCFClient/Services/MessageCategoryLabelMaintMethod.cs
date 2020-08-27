// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MessageCategoryLabelMaintMethod
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
  public class MessageCategoryLabelMaintMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public MessageCategoryLabelMaint Cdo;
    [DataMember(EmitDefaultValue = false)]
    public MessageCategoryLabelMaintMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public MessageCategoryLabelMaint_Parameters Parameters;

    public MessageCategoryLabelMaintMethod(
      MessageCategoryLabelMaint Cdo,
      MessageCategoryLabelMaintMethods Method,
      MessageCategoryLabelMaint_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
