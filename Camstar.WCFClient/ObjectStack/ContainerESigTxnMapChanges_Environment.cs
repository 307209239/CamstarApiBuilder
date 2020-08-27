// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerESigTxnMapChanges_Environment
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
  public class ContainerESigTxnMapChanges_Environment : ESigReqTxnMapChanges_Environment
  {
    [Metadata("Transaction Map for Container Transaction.", "ContainerESigTxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerESigTxnMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ContainerESigTxnMapChanges_Environment_TxnId")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049647, false, false, true, null)]
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
