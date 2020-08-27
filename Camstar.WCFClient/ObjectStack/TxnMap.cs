// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TxnMap
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
  public class TxnMap : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_DataCollectionDef")]
    protected RevisionedObjectRef _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_TxnType")]
    protected Primitive<int> _TxnType;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_Required")]
    protected Primitive<bool> _Required;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_TxnToUse")]
    protected Primitive<int> _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "TxnMap_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is TxnMap && object.Equals((object) this._DataCollectionDef, (object) ((TxnMap) obj)._DataCollectionDef) && (object.Equals((object) this._Sequence, (object) ((TxnMap) obj)._Sequence) && object.Equals((object) this._ExportImportKey, (object) ((TxnMap) obj)._ExportImportKey)) && (object.Equals((object) this._TxnType, (object) ((TxnMap) obj)._TxnType) && object.Equals((object) this._Required, (object) ((TxnMap) obj)._Required) && (object.Equals((object) this._TxnToUse, (object) ((TxnMap) obj)._TxnToUse) && object.Equals((object) this._IsFrozen, (object) ((TxnMap) obj)._IsFrozen))) && base.Equals(obj);
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
