// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.ResultStatus
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class ResultStatus
  {
    [DataMember(EmitDefaultValue = false)]
    public string Message;
    [DataMember(EmitDefaultValue = false)]
    public bool IsSuccess;
    [DataMember(EmitDefaultValue = false)]
    public ExceptionDataType ExceptionData;
    [DataMember(EmitDefaultValue = false)]
    public string ACEMessage;
    [DataMember(EmitDefaultValue = false)]
    public string ACEStatus;
    [DataMember(EmitDefaultValue = false)]
    public DebugResponse DebugResponse;
  }
}
