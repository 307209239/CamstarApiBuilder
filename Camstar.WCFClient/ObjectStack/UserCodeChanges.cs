// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserCodeChanges
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
  public class UserCodeChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserCodeChanges_ChangeHistory")]
    protected new ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeChanges_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserCodeChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UserCodeChanges && object.Equals((object) this._ChangeHistory, (object) ((UserCodeChanges) obj)._ChangeHistory) && (object.Equals((object) this._FilterTags, (object) ((UserCodeChanges) obj)._FilterTags) && object.Equals((object) this._ObjectToChange, (object) ((UserCodeChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((UserCodeChanges) obj)._Name) && base.Equals(obj);
    }

    public new ChangeHistoryChanges ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
