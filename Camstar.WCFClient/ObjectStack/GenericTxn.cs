// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GenericTxn
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
  public class GenericTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_ESigRequirement")]
    protected new NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Comments")]
    protected new Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_HistoryId")]
    protected BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_IsRemoteService")]
    protected new Primitive<bool> _IsRemoteService;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_TrackableObject")]
    protected BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_MfgOrder")]
    protected new NamedObjectRef _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Factory")]
    protected new NamedObjectRef _Factory;

    public override bool Equals(object obj)
    {
      return obj is GenericTxn && object.Equals((object) this._ESigRequirement, (object) ((GenericTxn) obj)._ESigRequirement) && (object.Equals((object) this._Comments, (object) ((GenericTxn) obj)._Comments) && object.Equals((object) this._ProcessESignatures, (object) ((GenericTxn) obj)._ProcessESignatures)) && (object.Equals((object) this._HistoryId, (object) ((GenericTxn) obj)._HistoryId) && object.Equals((object) this._IsRemoteService, (object) ((GenericTxn) obj)._IsRemoteService) && (object.Equals((object) this._TrackableObject, (object) ((GenericTxn) obj)._TrackableObject) && object.Equals((object) this._MfgOrder, (object) ((GenericTxn) obj)._MfgOrder))) && object.Equals((object) this._Factory, (object) ((GenericTxn) obj)._Factory) && base.Equals(obj);
    }

    public new NamedObjectRef ESigRequirement
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

    public new Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Primitive<bool> IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new NamedObjectRef MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public new NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
