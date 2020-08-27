// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqTxnMapChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRESigTxnMapChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ContainerESigTxnMapChanges_Environment))]
  [Serializable]
  public class ESigReqTxnMapChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, true, false, "NamedObjectRef", 1050352, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Environment_ESigRequirement")]
    protected Environment _ESigRequirement;
    [Metadata("Contains the matchup of an InSite service to an ElectronicSignature Requirement.", "ESigReqTxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048825, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Environment_Parent")]
    protected new Environment _Parent;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049647, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Environment_TxnId")]
    protected Environment _TxnId;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Environment_AllTxns")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049322, false, false, false, "0")]
    protected Environment _AllTxns;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment ESigRequirement
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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment TxnId
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnId));
      }
    }

    public Environment AllTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllTxns));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
