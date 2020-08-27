// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DisallowedTxnsChanges
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
  public class DisallowedTxnsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_DisallowAll")]
    protected Primitive<bool> _DisallowAll;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_TxnName")]
    protected Primitive<string> _TxnName;
    [DataMember(EmitDefaultValue = false, Name = "DisallowedTxnsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is DisallowedTxnsChanges && object.Equals((object) this._DisplayName, (object) ((DisallowedTxnsChanges) obj)._DisplayName) && (object.Equals((object) this._ListItemToChange, (object) ((DisallowedTxnsChanges) obj)._ListItemToChange) && object.Equals((object) this._TxnType, (object) ((DisallowedTxnsChanges) obj)._TxnType)) && (object.Equals((object) this._DisallowAll, (object) ((DisallowedTxnsChanges) obj)._DisallowAll) && object.Equals((object) this._IsFrozen, (object) ((DisallowedTxnsChanges) obj)._IsFrozen) && (object.Equals((object) this._TxnName, (object) ((DisallowedTxnsChanges) obj)._TxnName) && object.Equals((object) this._ObjectToChange, (object) ((DisallowedTxnsChanges) obj)._ObjectToChange))) && base.Equals(obj);
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
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

    public Primitive<bool> DisallowAll
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisallowAll), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisallowAll));
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
  }
}
