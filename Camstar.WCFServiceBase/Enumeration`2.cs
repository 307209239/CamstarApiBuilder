// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Service.Enumeration`2
// Assembly: Camstar.WCFServiceBase, Version=7.8.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: 8C40E744-39D8-4815-88BD-EF627AFA70F4
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFServiceBase.dll

using System.Runtime.Serialization;

namespace Camstar.WCF.Service
{
  [DataContract(Name = "EnumerationOf{0}", Namespace = "Camstar.WCF.ObjectStack")]
  public class Enumeration<E, T> : Primitive<T> where E : struct
  {
  }
}
