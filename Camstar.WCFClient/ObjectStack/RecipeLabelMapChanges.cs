// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeLabelMapChanges
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
  public class RecipeLabelMapChanges : LabelTxnMapChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeLabelMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeLabelMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeLabelMapChanges_TxnType")]
    protected new Primitive<int> _TxnType;

    public override bool Equals(object obj)
    {
      return obj is RecipeLabelMapChanges && object.Equals((object) this._ObjectToChange, (object) ((RecipeLabelMapChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((RecipeLabelMapChanges) obj)._ListItemToChange) && object.Equals((object) this._TxnType, (object) ((RecipeLabelMapChanges) obj)._TxnType)) && base.Equals(obj);
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

    public new Primitive<int> TxnType
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
  }
}
