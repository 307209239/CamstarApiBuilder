// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.RecordSet
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class RecordSet
  {
    [DataMember(EmitDefaultValue = false)]
    public Header[] Headers;
    [DataMember(EmitDefaultValue = false)]
    public Row[] Rows;
    [DataMember(EmitDefaultValue = false)]
    public int TotalCount;
  }
}
