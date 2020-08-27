// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ImportStatusInquiryMethod
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
  public class ImportStatusInquiryMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public ImportStatusInquiry Cdo;
    [DataMember(EmitDefaultValue = false)]
    public ImportStatusInquiryMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public ImportStatusInquiry_Parameters Parameters;

    public ImportStatusInquiryMethod(
      ImportStatusInquiry Cdo,
      ImportStatusInquiryMethods Method,
      ImportStatusInquiry_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
