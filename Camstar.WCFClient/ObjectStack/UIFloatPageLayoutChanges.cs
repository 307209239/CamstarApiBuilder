// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIFloatPageLayoutChanges
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
  public class UIFloatPageLayoutChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_CloseButton")]
    protected ButtonLabelChanges _CloseButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_OKButton")]
    protected ButtonLabelChanges _OKButton;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIFloatPageLayoutChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIFloatPageLayoutChanges && object.Equals((object) this._ObjectToChange, (object) ((UIFloatPageLayoutChanges) obj)._ObjectToChange) && (object.Equals((object) this._CloseButton, (object) ((UIFloatPageLayoutChanges) obj)._CloseButton) && object.Equals((object) this._OKButton, (object) ((UIFloatPageLayoutChanges) obj)._OKButton)) && (object.Equals((object) this._ListItemToChange, (object) ((UIFloatPageLayoutChanges) obj)._ListItemToChange) && object.Equals((object) this._IsFrozen, (object) ((UIFloatPageLayoutChanges) obj)._IsFrozen)) && base.Equals(obj);
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

    public ButtonLabelChanges CloseButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseButton), (object) value);
      }
      get
      {
        return (ButtonLabelChanges) this.PropertyGet(nameof (CloseButton));
      }
    }

    public ButtonLabelChanges OKButton
    {
      [param: In] set
      {
        this.PropertySet(nameof (OKButton), (object) value);
      }
      get
      {
        return (ButtonLabelChanges) this.PropertyGet(nameof (OKButton));
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
