// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MoveNonStds_Environment
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
  public class MoveNonStds_Environment : MoveTxns_Environment
  {
    [Metadata("A MoveNonStd will move a container from one operation to another without regard to the current location.  In other words, there does not need to be a path leading to the new location.", "MoveNonStd", false, false, false, "MoveNonStd", 1052702, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MoveNonStds_Environment_Services")]
    protected MoveNonStd_Environment _Services;

    public MoveNonStd_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (MoveNonStd_Environment) this.PropertyGet(nameof (Services));
      }
    }
  }
}
