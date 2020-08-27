// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ObjectTypeSecurity
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class V4_ObjectTypeSecurity : V4_Security
  {
    public override bool Equals(object obj)
    {
      return obj is V4_ObjectTypeSecurity && base.Equals(obj);
    }
  }
}
