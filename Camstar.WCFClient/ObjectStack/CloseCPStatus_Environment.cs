// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseCPStatus_Environment
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
  public class CloseCPStatus_Environment : ChangeStatusTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "CloseCPStatus_Environment_Status")]
    [Metadata("PackageStatus", "PackageStatusEnum", false, false, false, "Integer", 16778128, false, false, true, "0")]
    protected new Environment _Status;

    public new Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }
  }
}
