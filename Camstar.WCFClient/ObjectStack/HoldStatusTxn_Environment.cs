// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HoldStatusTxn_Environment
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
  public class HoldStatusTxn_Environment : ContainerTxn_Environment
  {
    [Metadata("Associating a Hold Code with a Container prevents transactions from being performed for that Container. Hold Codes are User Defined to provide multiple descriptions (reasons) for Holds.", "HoldReason", false, false, false, "NamedObjectRef", 1048800, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxn_Environment_HoldReason")]
    protected Environment _HoldReason;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1049783, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HoldStatusTxn_Environment_CurrentHoldCount")]
    protected Environment _CurrentHoldCount;

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

    public Environment CurrentHoldCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentHoldCount), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentHoldCount));
      }
    }
  }
}
