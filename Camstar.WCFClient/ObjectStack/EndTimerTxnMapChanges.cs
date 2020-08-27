// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EndTimerTxnMapChanges
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
  public class EndTimerTxnMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTxnMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTxnMapChanges_ProcessTimer")]
    protected RevisionedObjectRef _ProcessTimer;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTxnMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTxnMapChanges_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTxnMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTxnMapChanges_TxnName")]
    protected Primitive<string> _TxnName;

    public override bool Equals(object obj)
    {
      return obj is EndTimerTxnMapChanges && object.Equals((object) this._ListItemToChange, (object) ((EndTimerTxnMapChanges) obj)._ListItemToChange) && (object.Equals((object) this._ProcessTimer, (object) ((EndTimerTxnMapChanges) obj)._ProcessTimer) && object.Equals((object) this._ObjectToChange, (object) ((EndTimerTxnMapChanges) obj)._ObjectToChange)) && (object.Equals((object) this._TxnType, (object) ((EndTimerTxnMapChanges) obj)._TxnType) && object.Equals((object) this._IsFrozen, (object) ((EndTimerTxnMapChanges) obj)._IsFrozen) && object.Equals((object) this._TxnName, (object) ((EndTimerTxnMapChanges) obj)._TxnName)) && base.Equals(obj);
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public RevisionedObjectRef ProcessTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimer), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ProcessTimer));
      }
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

    public Primitive<int> TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnType));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Primitive<string> TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TxnName));
      }
    }
  }
}
