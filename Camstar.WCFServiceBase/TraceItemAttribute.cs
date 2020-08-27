// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.TraceItemAttribute
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class TraceItemAttribute
  {
    [DataMember(EmitDefaultValue = false, Name = "Name")]
    public string Name { get; set; }

    [DataMember(EmitDefaultValue = false, Name = "Value")]
    public string Value { get; set; }
  }
}
