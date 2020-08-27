// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRESigTxnMapChanges_Environment
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
  public class NCRESigTxnMapChanges_Environment : ESigReqTxnMapChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRESigTxnMapChanges_Environment_ObjectToChange")]
    [Metadata("Transaction map for Nonconformance services.", "NCRESigTxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049647, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRESigTxnMapChanges_Environment_TxnId")]
    protected new Environment _TxnId;

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment TxnId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnId));
      }
    }
  }
}
