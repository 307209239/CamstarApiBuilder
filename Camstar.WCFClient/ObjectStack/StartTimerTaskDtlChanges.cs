// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.StartTimerTaskDtlChanges
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
  public class StartTimerTaskDtlChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_StartTimer")]
    protected RevisionedObjectRef _StartTimer;
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "StartTimerTaskDtlChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is StartTimerTaskDtlChanges && object.Equals((object) this._ObjectToChange, (object) ((StartTimerTaskDtlChanges) obj)._ObjectToChange) && (object.Equals((object) this._StartTimer, (object) ((StartTimerTaskDtlChanges) obj)._StartTimer) && object.Equals((object) this._ListItemToChange, (object) ((StartTimerTaskDtlChanges) obj)._ListItemToChange)) && object.Equals((object) this._IsFrozen, (object) ((StartTimerTaskDtlChanges) obj)._IsFrozen) && base.Equals(obj);
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

    public RevisionedObjectRef StartTimer
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimer), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (StartTimer));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
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
