// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnDetails
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
  public class TxnDetails : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_ReworkReason")]
    protected NamedObjectRef _ReworkReason;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_NewOwner")]
    protected NamedObjectRef _NewOwner;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_ToContainerOption")]
    protected Primitive<int> _ToContainerOption;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnDetails_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is TxnDetails && object.Equals((object) this._ExportImportKey, (object) ((TxnDetails) obj)._ExportImportKey) && (object.Equals((object) this._ReworkReason, (object) ((TxnDetails) obj)._ReworkReason) && object.Equals((object) this._NewOwner, (object) ((TxnDetails) obj)._NewOwner)) && (object.Equals((object) this._ToContainerOption, (object) ((TxnDetails) obj)._ToContainerOption) && object.Equals((object) this._TxnType, (object) ((TxnDetails) obj)._TxnType) && object.Equals((object) this._IsFrozen, (object) ((TxnDetails) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
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
  }
}
