﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.NamedObjectRef
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  public class NamedObjectRef : BaseObjectRef
  {
    [DataMember(EmitDefaultValue = false)]
    public string Name;
  }
}
