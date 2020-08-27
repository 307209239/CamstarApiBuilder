// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnMapChanges
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
  public class TxnMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_TxnToUse")]
    protected Primitive<int> _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_Required")]
    protected Primitive<bool> _Required;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_TxnToUseName")]
    protected Primitive<string> _TxnToUseName;
    [DataMember(EmitDefaultValue = false, Name = "TxnMapChanges_TxnName")]
    protected Primitive<string> _TxnName;

    public override bool Equals(object obj)
    {
      return obj is TxnMapChanges && object.Equals((object) this._Sequence, (object) ((TxnMapChanges) obj)._Sequence) && (object.Equals((object) this._ListItemToChange, (object) ((TxnMapChanges) obj)._ListItemToChange) && object.Equals((object) this._DataCollectionDef, (object) ((TxnMapChanges) obj)._DataCollectionDef)) && (object.Equals((object) this._ObjectToChange, (object) ((TxnMapChanges) obj)._ObjectToChange) && object.Equals((object) this._TxnToUse, (object) ((TxnMapChanges) obj)._TxnToUse) && (object.Equals((object) this._Required, (object) ((TxnMapChanges) obj)._Required) && object.Equals((object) this._IsFrozen, (object) ((TxnMapChanges) obj)._IsFrozen))) && (object.Equals((object) this._TxnToUseName, (object) ((TxnMapChanges) obj)._TxnToUseName) && object.Equals((object) this._TxnName, (object) ((TxnMapChanges) obj)._TxnName)) && base.Equals(obj);
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
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

    public RevisionedObjectRef DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (DataCollectionDef));
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

    public Primitive<int> TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TxnToUse));
      }
    }

    public Primitive<bool> Required
    {
      [param: In] set
      {
        this.PropertySet(nameof (Required), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Required));
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

    public Primitive<string> TxnToUseName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUseName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TxnToUseName));
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
