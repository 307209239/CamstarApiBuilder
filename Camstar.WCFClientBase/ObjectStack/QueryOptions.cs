// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QueryOptions
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class QueryOptions
  {
    [DataMember(EmitDefaultValue = false)]
    public int? RowSetSize { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int? StartRow { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public Camstar.WCF.ObjectStack.QueryType? QueryType { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public int? ChangeCount { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool RequestRecordCount { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool RequestRecordSetAndCount { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool RequestHeadersOnly { get; set; }

    [DataMember(EmitDefaultValue = false)]
    public bool RequestHeadersAndRowCount { get; set; }
  }
}
