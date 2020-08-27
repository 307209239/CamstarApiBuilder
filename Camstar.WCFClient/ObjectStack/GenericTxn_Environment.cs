// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GenericTxn_Environment
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
  public class GenericTxn_Environment : ShopFloor_Environment
  {
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_ESigRequirement")]
    protected new Environment _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_Comments")]
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    protected new Environment _Comments;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1050357, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_ProcessESignatures")]
    protected new Environment _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_HistoryId")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049097, false, false, false, null)]
    protected Environment _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_IsRemoteService")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049887, false, false, false, "0")]
    protected new Environment _IsRemoteService;
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_TrackableObject")]
    protected Environment _TrackableObject;
    [Metadata("A Manufacturing Order is a request to manufacture a product. Manufacturing orders are typically originated to fulfill a sales order or inventory requirements and are often a link between MES and an ERP system. \r\n\r\nA Manufacturing Order can contain a list of product containers. The relationship of a container to a manufacturing order is established and maintained in the containers data record. This information is used to provide WIP status by manufacturing order and WIP updates to the ERP system.\r\n\r\n", "MfgOrder", false, false, false, "NamedObjectRef", 1048810, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_MfgOrder")]
    protected new Environment _MfgOrder;
    [DataMember(EmitDefaultValue = false, Name = "GenericTxn_Environment_Factory")]
    [Metadata("A Factory often represent a physical or logical plant. A Factory can be any division, department, section, or group that is separated for accounting and reporting purposes. A Factory often represents a physical manufacturing building. ", "Factory", false, false, false, "NamedObjectRef", 1048659, false, false, true, null)]
    protected new Environment _Factory;

    public new Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public new Environment ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Environment HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryId));
      }
    }

    public new Environment IsRemoteService
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRemoteService), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRemoteService));
      }
    }

    public Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new Environment MfgOrder
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgOrder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MfgOrder));
      }
    }

    public new Environment Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
