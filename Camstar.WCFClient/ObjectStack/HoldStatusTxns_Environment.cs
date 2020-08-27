// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldStatusTxns_Environment
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
  public class HoldStatusTxns_Environment : ContainersTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxns_Environment_Services")]
    [Metadata("Used to encapsulate the common behaviour of the Hold and Release transactions.", "HoldStatusTxn", false, false, false, "HoldStatusTxn", 1052702, false, true, false, null)]
    protected HoldStatusTxn_Environment _Services;

    public HoldStatusTxn_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (HoldStatusTxn_Environment) this.PropertyGet(nameof (Services));
      }
    }
  }
}
