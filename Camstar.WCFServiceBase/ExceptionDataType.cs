// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.ExceptionDataType
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class ExceptionDataType
  {
    [DataMember(EmitDefaultValue = false)]
    public int Code;
    [DataMember(EmitDefaultValue = false)]
    public string Description;
    [DataMember(EmitDefaultValue = false)]
    public string Source;
    [DataMember(EmitDefaultValue = false)]
    public string failureContext;
    [DataMember(EmitDefaultValue = false)]
    public ExceptionLevel ExceptionLevel;
    [DataMember(EmitDefaultValue = false)]
    public ExceptionParameter[] ExceptionParameters;
  }
}
