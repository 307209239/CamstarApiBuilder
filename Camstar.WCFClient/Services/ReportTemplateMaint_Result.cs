// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReportTemplateMaint_Result
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
  public class ReportTemplateMaint_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ReportTemplateMaint _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ReportTemplateMaint_Environment _Environment;

    public ReportTemplateMaint Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ReportTemplateMaint) this.PropertyGet(nameof (Value));
      }
    }

    public ReportTemplateMaint_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ReportTemplateMaint_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
