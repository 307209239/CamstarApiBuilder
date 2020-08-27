// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqTxnMap_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerESigTxnMap_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigReqTxnMap_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Environment_ESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050352, false, false, false, null)]
    protected Environment _ESigRequirement;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1049322, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Environment_AllTxns")]
    protected Environment _AllTxns;
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1050353, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Environment_TxnId")]
    protected Environment _TxnId;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Environment_TxnToUse")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049019, false, false, false, null)]
    protected Environment _TxnToUse;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ESigReqTxnMap_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

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

    public Environment TxnToUse
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnToUse), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnToUse));
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
