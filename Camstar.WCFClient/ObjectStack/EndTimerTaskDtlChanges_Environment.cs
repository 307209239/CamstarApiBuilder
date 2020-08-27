// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EndTimerTaskDtlChanges_Environment
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
  public class EndTimerTaskDtlChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("EndTimerTaskDtl", "EndTimerTaskDtl", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTaskDtlChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("EndTimerTaskDtlChanges", "EndTimerTaskDtlChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTaskDtlChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTaskDtlChanges_Environment_EndTimer")]
    [Metadata("Process Timer", "ProcessTimer", false, false, false, "RevisionedObjectRef", 16778408, false, false, true, null)]
    protected Environment _EndTimer;
    [DataMember(EmitDefaultValue = false, Name = "EndTimerTaskDtlChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
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

    public Environment EndTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndTimer));
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
