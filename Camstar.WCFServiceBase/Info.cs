// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.Info
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class Info
  {
    [DataMember(EmitDefaultValue = false)]
    public bool RequestValue;
    [DataMember(EmitDefaultValue = false)]
    public bool RequestSelectionValues;
    [DataMember(EmitDefaultValue = false)]
    public SelectionValuesInfo RequestSelectionValuesInfo;
  }
}
