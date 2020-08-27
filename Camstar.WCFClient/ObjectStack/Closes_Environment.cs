// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Closes_Environment
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
  public class Closes_Environment : ContainerStatusChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Closes_Environment_Services")]
    [Metadata("Sets the container's status from active to close", "Close", false, false, false, "Close", 1052702, false, true, false, null)]
    protected Close_Environment _Services;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049124, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "Closes_Environment_IncludeChildren")]
    protected new Environment _IncludeChildren;

    public Close_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Close_Environment) this.PropertyGet(nameof (Services));
      }
    }

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
