// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeHistoryChanges
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
  public class ChangeHistoryChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_LastChangeDateGMT")]
    protected Primitive<DateTime> _LastChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_LastChangeDate")]
    protected Primitive<DateTime> _LastChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_CurrentStatus")]
    protected Primitive<int> _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_User")]
    protected NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Control")]
    protected Primitive<int> _Control;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Notes")]
    protected Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is ChangeHistoryChanges && object.Equals((object) this._ListItemToChange, (object) ((ChangeHistoryChanges) obj)._ListItemToChange) && (object.Equals((object) this._LastChangeDateGMT, (object) ((ChangeHistoryChanges) obj)._LastChangeDateGMT) && object.Equals((object) this._LastChangeDate, (object) ((ChangeHistoryChanges) obj)._LastChangeDate)) && (object.Equals((object) this._CurrentStatus, (object) ((ChangeHistoryChanges) obj)._CurrentStatus) && object.Equals((object) this._IsFrozen, (object) ((ChangeHistoryChanges) obj)._IsFrozen) && (object.Equals((object) this._ObjectToChange, (object) ((ChangeHistoryChanges) obj)._ObjectToChange) && object.Equals((object) this._User, (object) ((ChangeHistoryChanges) obj)._User))) && (object.Equals((object) this._Control, (object) ((ChangeHistoryChanges) obj)._Control) && object.Equals((object) this._Notes, (object) ((ChangeHistoryChanges) obj)._Notes)) && base.Equals(obj);
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

    public Primitive<DateTime> LastChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastChangeDateGMT));
      }
    }

    public Primitive<DateTime> LastChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastChangeDate));
      }
    }

    public Primitive<int> CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CurrentStatus));
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

    public NamedObjectRef User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (User));
      }
    }

    public Primitive<int> Control
    {
      [param: In] set
      {
        this.PropertySet(nameof (Control), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Control));
      }
    }

    public Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
