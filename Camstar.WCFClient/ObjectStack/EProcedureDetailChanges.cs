// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EProcedureDetailChanges
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
  public class EProcedureDetailChanges : ProductionProcessDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_Sequence")]
    protected new Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_TaskList")]
    protected new RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is EProcedureDetailChanges && object.Equals((object) this._ObjectToChange, (object) ((EProcedureDetailChanges) obj)._ObjectToChange) && (object.Equals((object) this._Sequence, (object) ((EProcedureDetailChanges) obj)._Sequence) && object.Equals((object) this._ListItemToChange, (object) ((EProcedureDetailChanges) obj)._ListItemToChange)) && (object.Equals((object) this._TaskList, (object) ((EProcedureDetailChanges) obj)._TaskList) && object.Equals((object) this._IsFrozen, (object) ((EProcedureDetailChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public new Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
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

    public new RevisionedObjectRef TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TaskList));
      }
    }

    public new Primitive<bool> IsFrozen
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
