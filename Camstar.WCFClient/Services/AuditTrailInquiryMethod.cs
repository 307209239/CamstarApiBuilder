// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AuditTrailInquiryMethod
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
  public class AuditTrailInquiryMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public AuditTrailInquiry Cdo;
    [DataMember(EmitDefaultValue = false)]
    public AuditTrailInquiryMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public AuditTrailInquiry_Parameters Parameters;

    public AuditTrailInquiryMethod(
      AuditTrailInquiry Cdo,
      AuditTrailInquiryMethods Method,
      AuditTrailInquiry_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
