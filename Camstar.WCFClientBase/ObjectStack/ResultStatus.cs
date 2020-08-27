// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResultStatus
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ResultStatus
  {
    [DataMember(EmitDefaultValue = false, Name = "Message")]
    public string Message { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "IsSuccess")]
    public bool IsSuccess { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ExceptionData")]
    public ExceptionDataType ExceptionData { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ACEMessage")]
    public string ACEMessage { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "ACEStatus")]
    public string ACEStatus { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "DebugResponse")]
    public DebugResponse DebugResponse { get; set; }

    public ResultStatus()
    {
    }

    public ResultStatus(string message, bool isSuccess)
    {
      this.IsSuccess = isSuccess;
      if (this.IsSuccess)
      {
        this.Message = message;
      }
      else
      {
        this.ExceptionData = new ExceptionDataType();
        this.ExceptionData.Description = message;
        this.ExceptionData.ExceptionLevel = ExceptionLevel.Client;
      }
    }

    public override string ToString()
    {
      if (this.IsSuccess)
        return this.Message;
      return this.ExceptionData != null ? this.ExceptionData.ToString() : string.Empty;
    }
  }
}
