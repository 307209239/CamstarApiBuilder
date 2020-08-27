// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnDetailsChanges
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
  public class TxnDetailsChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_ToContainerLevel")]
    protected NamedObjectRef _ToContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_ToContainerName")]
    protected Primitive<string> _ToContainerName;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_ToContainerOption")]
    protected Primitive<int> _ToContainerOption;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_NewOwner")]
    protected NamedObjectRef _NewOwner;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetailsChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is TxnDetailsChanges && object.Equals((object) this._ListItemToChange, (object) ((TxnDetailsChanges) obj)._ListItemToChange) && (object.Equals((object) this._TxnType, (object) ((TxnDetailsChanges) obj)._TxnType) && object.Equals((object) this._ToContainerLevel, (object) ((TxnDetailsChanges) obj)._ToContainerLevel)) && (object.Equals((object) this._ToContainerName, (object) ((TxnDetailsChanges) obj)._ToContainerName) && object.Equals((object) this._ToContainerOption, (object) ((TxnDetailsChanges) obj)._ToContainerOption) && (object.Equals((object) this._ObjectToChange, (object) ((TxnDetailsChanges) obj)._ObjectToChange) && object.Equals((object) this._NewOwner, (object) ((TxnDetailsChanges) obj)._NewOwner))) && (object.Equals((object) this._ReworkReason, (object) ((TxnDetailsChanges) obj)._ReworkReason) && object.Equals((object) this._IsFrozen, (object) ((TxnDetailsChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public NamedObjectRef ToContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToContainerLevel));
      }
    }

    public Primitive<string> ToContainerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ToContainerName));
      }
    }

    public Primitive<int> ToContainerOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToContainerOption), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ToContainerOption));
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

    public NamedObjectRef NewOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewOwner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NewOwner));
      }
    }

    public NamedObjectRef ReworkReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReworkReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ReworkReason));
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
  }
}
