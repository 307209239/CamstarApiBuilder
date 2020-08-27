// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangePackageInquiryMethod
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
  public class ChangePackageInquiryMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ChangePackageInquiry Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ChangePackageInquiryMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ChangePackageInquiry_Parameters Parameters;

    public ChangePackageInquiryMethod(
      ChangePackageInquiry Cdo,
      ChangePackageInquiryMethods Method,
      ChangePackageInquiry_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
