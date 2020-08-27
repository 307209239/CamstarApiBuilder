// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartTimerTaskDtlChanges_Environment
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
  public class StartTimerTaskDtlChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("StartTimerTaskDtl", "StartTimerTaskDtl", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Process Timer", "ProcessTimer", false, false, false, "RevisionedObjectRef", 16778404, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_Environment_StartTimer")]
    protected Environment _StartTimer;
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_Environment_ListItemToChange")]
    [Metadata("StartTimerTaskDtlChanges", "StartTimerTaskDtlChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public Environment StartTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartTimer));
      }
    }

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
