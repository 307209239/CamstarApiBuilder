// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqTxnMap
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerESigTxnMap))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigReqTxnMap : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_AllTxns")]
    protected Primitive<bool> _AllTxns;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_TxnId")]
    protected Primitive<int> _TxnId;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_TxnToUse")]
    protected Primitive<string> _TxnToUse;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ESigReqTxnMap && object.Equals((object) this._ExportImportKey, (object) ((ESigReqTxnMap) obj)._ExportImportKey) && (object.Equals((object) this._ESigRequirement, (object) ((ESigReqTxnMap) obj)._ESigRequirement) && object.Equals((object) this._AllTxns, (object) ((ESigReqTxnMap) obj)._AllTxns)) && (object.Equals((object) this._TxnId, (object) ((ESigReqTxnMap) obj)._TxnId) && object.Equals((object) this._TxnToUse, (object) ((ESigReqTxnMap) obj)._TxnToUse) && object.Equals((object) this._IsFrozen, (object) ((ESigReqTxnMap) obj)._IsFrozen)) && base.Equals(obj);
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

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Primitive<bool> AllTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllTxns), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllTxns));
      }
    }

    public Primitive<int> TxnId
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

    public Primitive<string> TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TxnToUse));
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
