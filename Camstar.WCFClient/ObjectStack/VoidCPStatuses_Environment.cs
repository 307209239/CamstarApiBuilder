// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VoidCPStatuses_Environment
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
  public class VoidCPStatuses_Environment : ChangeStatusTxns_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "VoidCPStatuses_Environment_Services")]
    [Metadata("Service to manage trackable object status to void.", "VoidCPStatus", false, false, false, "VoidCPStatus", 16778887, false, true, false, null)]
    protected VoidCPStatus_Environment _Services;

    public VoidCPStatus_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (VoidCPStatus_Environment) this.PropertyGet(nameof (Services));
      }
    }
  }
}
