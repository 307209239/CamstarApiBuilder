// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRESigTxnMapChanges
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
  public class NCRESigTxnMapChanges : ESigReqTxnMapChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRESigTxnMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NCRESigTxnMapChanges_TxnId")]
    protected new Primitive<int> _TxnId;

    public override bool Equals(object obj)
    {
      return obj is NCRESigTxnMapChanges && object.Equals((object) this._ObjectToChange, (object) ((NCRESigTxnMapChanges) obj)._ObjectToChange) && object.Equals((object) this._TxnId, (object) ((NCRESigTxnMapChanges) obj)._TxnId) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<int> TxnId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnId));
      }
    }
  }
}
