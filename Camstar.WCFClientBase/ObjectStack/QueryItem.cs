// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QueryItem
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class QueryItem
  {
    [DataMember(EmitDefaultValue = false)]
    public QueryParameters QueryParameters { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public QueryOptions Options { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public string Name { get; set; }
  }
}
