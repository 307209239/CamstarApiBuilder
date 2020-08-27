// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartTimerTxnMapChanges_Environment
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
  public class StartTimerTxnMapChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("StartTimerTxnMapChanges", "StartTimerTxnMapChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTxnMapChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [Metadata("StartTimerTxnMap", "StartTimerTxnMap", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTxnMapChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTxnMapChanges_Environment_ProcessTimer")]
    [Metadata("Process Timer", "ProcessTimer", false, true, false, "RevisionedObjectRef", 16778381, false, false, true, null)]
    protected Environment _ProcessTimer;
    [Metadata("CDO Definition Id", "", false, true, false, "Integer", 16778398, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTxnMapChanges_Environment_TxnType")]
    protected Environment _TxnType;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTxnMapChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049647, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTxnMapChanges_Environment_TxnName")]
    protected Environment _TxnName;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment ProcessTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessTimer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessTimer));
      }
    }

    public Environment TxnType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnType));
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

    public Environment TxnName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TxnName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TxnName));
      }
    }
  }
}
