// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Close_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class Close_Environment : ContainerStatusChange_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Close_Environment_IncludeChildren")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049124, false, false, false, "1")]
    protected new Environment _IncludeChildren;

    public new Environment IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
