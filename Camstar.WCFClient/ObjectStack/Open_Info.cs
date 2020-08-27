// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Open_Info
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
  public class Open_Info : ContainerStatusChange_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Open_Info_IncludeChildren")]
    protected new Info _IncludeChildren;

    public new Info IncludeChildren
    {
      [param: In] set
      {
        this.PropertySet(nameof (IncludeChildren), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IncludeChildren));
      }
    }
  }
}
