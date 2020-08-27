// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QueryParameter
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QueryParameter
  {
    [DataMember(EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Value { get; set; }

    public QueryParameter()
    {
    }

    public QueryParameter(string name, string value)
    {
      this.Name = name;
      this.Value = value;
    }
  }
}
