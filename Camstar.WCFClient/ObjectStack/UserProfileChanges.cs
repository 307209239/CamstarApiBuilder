// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserProfileChanges
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
  public class UserProfileChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_ShowLineAssignmentOnLogon")]
    protected Primitive<bool> _ShowLineAssignmentOnLogon;
    [DataMember(EmitDefaultValue = false, Name = "UserProfileChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UserProfileChanges && object.Equals((object) this._ChangeHistory, (object) ((UserProfileChanges) obj)._ChangeHistory) && (object.Equals((object) this._ObjectToChange, (object) ((UserProfileChanges) obj)._ObjectToChange) && object.Equals((object) this._ListItemToChange, (object) ((UserProfileChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ShowLineAssignmentOnLogon, (object) ((UserProfileChanges) obj)._ShowLineAssignmentOnLogon) && object.Equals((object) this._IsFrozen, (object) ((UserProfileChanges) obj)._IsFrozen)) && base.Equals(obj);
    }

    public ChangeHistoryChanges ChangeHistory
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

    public Primitive<bool> ShowLineAssignmentOnLogon
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowLineAssignmentOnLogon), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowLineAssignmentOnLogon));
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
