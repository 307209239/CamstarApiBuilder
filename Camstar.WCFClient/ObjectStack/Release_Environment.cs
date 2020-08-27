// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Release_Environment
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
  public class Release_Environment : HoldStatusTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "Release_Environment_ReleaseReason")]
    [Metadata("Reason codes for releasing Containers", "ReleaseReason", false, false, false, "NamedObjectRef", 1050369, false, false, true, null)]
    protected Environment _ReleaseReason;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, true, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Release_Environment_HoldReason")]
    protected new Environment _HoldReason;

    public Environment ReleaseReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReleaseReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReleaseReason));
      }
    }

    public new Environment HoldReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (HoldReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HoldReason));
      }
    }
  }
}
