// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.SelectionValuesInfo
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class SelectionValuesInfo
  {
    [DataMember(EmitDefaultValue = false)]
    public QueryParameter[] Parameters;
    [DataMember(EmitDefaultValue = false)]
    public QueryOptions Options;
  }
}
