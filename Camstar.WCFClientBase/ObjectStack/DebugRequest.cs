// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DebugRequest
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class DebugRequest
  {
    [DataMember(EmitDefaultValue = false, Name = "DisableCommit")]
    public bool DisableCommit { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "TraceToResponseXML")]
    public bool TraceToResponseXML { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "IncludeTimestamps")]
    public bool IncludeTimestamps { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "IncludeRRXML")]
    public bool IncludeRRXML { get; set; }
  }
}
