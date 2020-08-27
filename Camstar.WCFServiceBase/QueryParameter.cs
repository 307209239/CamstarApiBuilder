// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.QueryParameter
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class QueryParameter
  {
    [DataMember(EmitDefaultValue = false)]
    public string Name;
    [DataMember(EmitDefaultValue = false)]
    public string Value;

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
