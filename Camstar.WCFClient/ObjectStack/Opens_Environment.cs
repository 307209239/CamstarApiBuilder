// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Opens_Environment
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
  public class Opens_Environment : ContainerStatusChanges_Environment
  {
    [Metadata("Sets the container's status from close to active (open)", "Open", false, false, false, "Open", 1052702, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Opens_Environment_Services")]
    protected Open_Environment _Services;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049124, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "Opens_Environment_IncludeChildren")]
    protected new Environment _IncludeChildren;

    public Open_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Open_Environment) this.PropertyGet(nameof (Services));
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
