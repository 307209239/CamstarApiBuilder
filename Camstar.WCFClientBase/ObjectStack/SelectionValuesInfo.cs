// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SelectionValuesInfo
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class SelectionValuesInfo
  {
    [DataMember(EmitDefaultValue = false, Name = "Parameters")]
    public QueryParameter[] Parameters { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Options")]
    public QueryOptions Options { get; set; }
  }
}
