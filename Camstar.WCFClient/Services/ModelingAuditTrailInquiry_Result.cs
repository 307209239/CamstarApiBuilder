// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ModelingAuditTrailInquiry_Result
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ModelingAuditTrailInquiry_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ModelingAuditTrailInquiry _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ModelingAuditTrailInquiry_Environment _Environment;

    public ModelingAuditTrailInquiry Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ModelingAuditTrailInquiry) this.PropertyGet(nameof (Value));
      }
    }

    public ModelingAuditTrailInquiry_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ModelingAuditTrailInquiry_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
