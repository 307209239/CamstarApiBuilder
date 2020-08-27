// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuItemChanges
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
  public class ActionsMenuItemChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Caption")]
    protected Primitive<string> _Caption;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_OptionalParameters")]
    protected Primitive<string> _OptionalParameters;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuItemChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is ActionsMenuItemChanges && object.Equals((object) this._Caption, (object) ((ActionsMenuItemChanges) obj)._Caption) && (object.Equals((object) this._Sequence, (object) ((ActionsMenuItemChanges) obj)._Sequence) && object.Equals((object) this._OptionalParameters, (object) ((ActionsMenuItemChanges) obj)._OptionalParameters)) && (object.Equals((object) this._ListItemToChange, (object) ((ActionsMenuItemChanges) obj)._ListItemToChange) && object.Equals((object) this._UIVirtualPage, (object) ((ActionsMenuItemChanges) obj)._UIVirtualPage) && (object.Equals((object) this._ObjectToChange, (object) ((ActionsMenuItemChanges) obj)._ObjectToChange) && object.Equals((object) this._IsFrozen, (object) ((ActionsMenuItemChanges) obj)._IsFrozen))) && base.Equals(obj);
    }

    public Primitive<string> Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Caption));
      }
    }

    public Primitive<int> Sequence
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

    public Primitive<string> OptionalParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (OptionalParameters), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OptionalParameters));
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

    public NamedObjectRef UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIVirtualPage));
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
