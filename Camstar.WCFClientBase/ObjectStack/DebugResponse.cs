// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DebugResponse
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
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

    public override string ToString()
    {
      string str = string.Empty;
      if (this.Request != null)
        str = str + "\n[\n" + this.Request + "\n]\n";
      if (this.Trace != null)
        str = str + "{\n" + this.Trace.ToString() + "\n}\n";
      if (this.Response != null)
        str = str + "[\n" + this.Response + "\n]\n";
      return str;
    }
  }
}
