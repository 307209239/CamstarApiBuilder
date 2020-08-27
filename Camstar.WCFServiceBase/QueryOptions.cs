// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.QueryOptions
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class QueryOptions
  {
    [DataMember(EmitDefaultValue = false)]
    public int? RowSetSize;
    [DataMember(EmitDefaultValue = false)]
    public int? StartRow;
    [DataMember(EmitDefaultValue = false)]
    public Camstar.WCF.Service.QueryType? QueryType;
    [DataMember(EmitDefaultValue = false)]
    public int? ChangeCount;
    [DataMember(EmitDefaultValue = false)]
    public bool RequestRecordCount;
    [DataMember(EmitDefaultValue = false)]
    public bool RequestRecordSetAndCount;
    [DataMember(EmitDefaultValue = false)]
    public bool RequestHeadersOnly;
    [DataMember(EmitDefaultValue = false)]
    public bool RequestHeadersAndRowCount;
  }
}
