// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Opens_Info
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
  public class Opens_Info : ContainerStatusChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Opens_Info_Services")]
    protected Open_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "Opens_Info_IncludeChildren")]
    protected new Info _IncludeChildren;

    public Open_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Open_Info) this.PropertyGet(nameof (Services));
      }
    }

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
