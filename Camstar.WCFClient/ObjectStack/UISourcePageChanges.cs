// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISourcePageChanges
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
  public class UISourcePageChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Links")]
    protected UITargetLinkChanges[] _Links;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Conditions")]
    protected UITargetConditionChanges[] _Conditions;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UISourcePageChanges && object.Equals((object) this._Sequence, (object) ((UISourcePageChanges) obj)._Sequence) && (object.Equals((object) this._ListItemToChange, (object) ((UISourcePageChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((UISourcePageChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._Links, (Array) ((UISourcePageChanges) obj)._Links) && this.CompareArrays((Array) this._Conditions, (Array) ((UISourcePageChanges) obj)._Conditions) && (object.Equals((object) this._UIVirtualPage, (object) ((UISourcePageChanges) obj)._UIVirtualPage) && object.Equals((object) this._IsFrozen, (object) ((UISourcePageChanges) obj)._IsFrozen))) && base.Equals(obj);
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

    public UITargetLinkChanges[] Links
    {
      [param: In] set
      {
        this.PropertySet(nameof (Links), (object) value);
      }
      get
      {
        return (UITargetLinkChanges[]) this.PropertyGet(nameof (Links));
      }
    }

    public UITargetConditionChanges[] Conditions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Conditions), (object) value);
      }
      get
      {
        return (UITargetConditionChanges[]) this.PropertyGet(nameof (Conditions));
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
