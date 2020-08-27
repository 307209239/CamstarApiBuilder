// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.ServerTraceItem
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ServerTraceItem
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Value")]
    public string Value { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Attributes")]
    public TraceItemAttribute[] Attributes { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Parameters")]
    public TraceItemParameter[] Parameters { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Children")]
    public ServerTraceItem[] Children { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Started")]
    public DateTime Started { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Ended")]
    public DateTime Ended { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "StartedMemoryUsage")]
    public int StartedMemoryUsage { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "EndedMemoryUsage")]
    public int EndedMemoryUsage { get; set; }
  }
}
