// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.DebugResponse
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DebugResponse
  {
    [DataMember(EmitDefaultValue = false, Name = "Trace")]
    public ServerTraceItem Trace { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Fault")]
    public bool Fault { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Request")]
    public string Request { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Response")]
    public string Response { get; set; }
  }
}
