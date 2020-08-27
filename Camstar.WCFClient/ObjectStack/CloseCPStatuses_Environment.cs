// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseCPStatuses_Environment
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
  public class CloseCPStatuses_Environment : ChangeStatusTxns_Environment
  {
    [Metadata("Service to manage trackable object status to close.", "CloseCPStatus", false, false, false, "CloseCPStatus", 16778887, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CloseCPStatuses_Environment_Services")]
    protected CloseCPStatus_Environment _Services;

    public CloseCPStatus_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (CloseCPStatus_Environment) this.PropertyGet(nameof (Services));
      }
    }
  }
}
