// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqTxnMapChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerESigTxnMapChanges))]
  [KnownType(typeof (NCRESigTxnMapChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigReqTxnMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Parent")]
    protected new BaseObjectRef _Parent;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_TxnId")]
    protected Primitive<int> _TxnId;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_AllTxns")]
    protected Primitive<bool> _AllTxns;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ESigReqTxnMapChanges && object.Equals((object) this._ESigRequirement, (object) ((ESigReqTxnMapChanges) obj)._ESigRequirement) && (object.Equals((object) this._ObjectToChange, (object) ((ESigReqTxnMapChanges) obj)._ObjectToChange) && object.Equals((object) this._Parent, (object) ((ESigReqTxnMapChanges) obj)._Parent)) && (object.Equals((object) this._TxnId, (object) ((ESigReqTxnMapChanges) obj)._TxnId) && object.Equals((object) this._AllTxns, (object) ((ESigReqTxnMapChanges) obj)._AllTxns) && object.Equals((object) this._IsFrozen, (object) ((ESigReqTxnMapChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public new BaseObjectRef Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (Parent));
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
