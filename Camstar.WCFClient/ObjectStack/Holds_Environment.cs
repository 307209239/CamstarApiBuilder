// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Holds_Environment
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
  public class Holds_Environment : HoldStatusTxns_Environment
  {
    [Metadata("Is a service used to put the container and its ancestors on hold.  Held Containers cannot undergo normal processing (such transactions as MoveIn, Thruput, ChangeQty, Move, etc.).  Transaction that can occur on held containers include to release, collect data, split, disassociate, and change attribute.", "Hold", false, false, false, "Hold", 1052702, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Holds_Environment_Services")]
    protected Hold_Environment _Services;
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, true, false, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "Holds_Environment_HoldReason")]
    protected Environment _HoldReason;

    public Hold_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (Hold_Environment) this.PropertyGet(nameof (Services));
      }
    }

    public Environment HoldReason
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
