// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPersonalizationChanges
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
  public class UIPersonalizationChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Content")]
    protected Primitive<string> _Content;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_ChangeHistory")]
    protected ChangeHistoryChanges _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_WorkspaceId")]
    protected Primitive<int> _WorkspaceId;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_Owner")]
    protected NamedObjectRef _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIPersonalizationChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIPersonalizationChanges && object.Equals((object) this._Content, (object) ((UIPersonalizationChanges) obj)._Content) && (object.Equals((object) this._ChangeHistory, (object) ((UIPersonalizationChanges) obj)._ChangeHistory) && object.Equals((object) this._ObjectToChange, (object) ((UIPersonalizationChanges) obj)._ObjectToChange)) && (object.Equals((object) this._ListItemToChange, (object) ((UIPersonalizationChanges) obj)._ListItemToChange) && object.Equals((object) this._WorkspaceId, (object) ((UIPersonalizationChanges) obj)._WorkspaceId) && (object.Equals((object) this._Owner, (object) ((UIPersonalizationChanges) obj)._Owner) && object.Equals((object) this._IsFrozen, (object) ((UIPersonalizationChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public Primitive<string> Content
    {
      [param: In] set
      {
        this.PropertySet(nameof (Content), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Content));
      }
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

    public Primitive<int> WorkspaceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkspaceId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (WorkspaceId));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
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
