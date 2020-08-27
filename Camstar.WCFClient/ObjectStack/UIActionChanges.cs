// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIActionChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIFloatPageOpenActionChanges))]
  [KnownType(typeof (UIRedirectActionChanges))]
  [KnownType(typeof (UILinkActionChanges))]
  [KnownType(typeof (UICustomActionChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UISubmitActionChanges))]
  [Serializable]
  public class UIActionChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_LabelText")]
    protected Primitive<string> _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_SPCEnabled")]
    protected Enumeration<BooleanThreeStateEnum, int> _SPCEnabled;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_WIPMessagesRequired")]
    protected Enumeration<BooleanThreeStateEnum, int> _WIPMessagesRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_DisableCondition")]
    protected Primitive<string> _DisableCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ESignatureRequired")]
    protected Enumeration<BooleanThreeStateEnum, int> _ESignatureRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ConditionHandler")]
    protected Primitive<string> _ConditionHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_HiddenCondition")]
    protected Primitive<string> _HiddenCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Location")]
    protected Enumeration<ActionLocationEnum, int> _Location;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ButtonPosition")]
    protected Enumeration<ButtonPositionTypeEnum, int> _ButtonPosition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_DisplayMode")]
    protected Enumeration<UIDisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_HorizontalShift")]
    protected HorizontalShiftOptionsChanges _HorizontalShift;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ActionCategory")]
    protected NamedObjectRef _ActionCategory;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Permissions")]
    protected PermissionDefinitionChanges _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_IsDisabled")]
    protected Primitive<bool> _IsDisabled;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ReloadValues")]
    protected Primitive<bool> _ReloadValues;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_IsPrimary")]
    protected Primitive<bool> _IsPrimary;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Index")]
    protected Primitive<int> _Index;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_IsHidden")]
    protected Primitive<bool> _IsHidden;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_ServiceName")]
    protected Primitive<string> _ServiceName;

    public override bool Equals(object obj)
    {
      return obj is UIActionChanges && object.Equals((object) this._LabelText, (object) ((UIActionChanges) obj)._LabelText) && (object.Equals((object) this._Sequence, (object) ((UIActionChanges) obj)._Sequence) && object.Equals((object) this._LabelName, (object) ((UIActionChanges) obj)._LabelName)) && (object.Equals((object) this._SPCEnabled, (object) ((UIActionChanges) obj)._SPCEnabled) && object.Equals((object) this._WIPMessagesRequired, (object) ((UIActionChanges) obj)._WIPMessagesRequired) && (object.Equals((object) this._ObjectToChange, (object) ((UIActionChanges) obj)._ObjectToChange) && object.Equals((object) this._DisableCondition, (object) ((UIActionChanges) obj)._DisableCondition))) && (object.Equals((object) this._ListItemToChange, (object) ((UIActionChanges) obj)._ListItemToChange) && object.Equals((object) this._ESignatureRequired, (object) ((UIActionChanges) obj)._ESignatureRequired) && (object.Equals((object) this._ConditionHandler, (object) ((UIActionChanges) obj)._ConditionHandler) && object.Equals((object) this._HiddenCondition, (object) ((UIActionChanges) obj)._HiddenCondition)) && (object.Equals((object) this._Location, (object) ((UIActionChanges) obj)._Location) && object.Equals((object) this._ButtonPosition, (object) ((UIActionChanges) obj)._ButtonPosition) && (object.Equals((object) this._DisplayMode, (object) ((UIActionChanges) obj)._DisplayMode) && object.Equals((object) this._HorizontalShift, (object) ((UIActionChanges) obj)._HorizontalShift)))) && (object.Equals((object) this._ActionCategory, (object) ((UIActionChanges) obj)._ActionCategory) && object.Equals((object) this._Permissions, (object) ((UIActionChanges) obj)._Permissions) && (object.Equals((object) this._IsDisabled, (object) ((UIActionChanges) obj)._IsDisabled) && object.Equals((object) this._ReloadValues, (object) ((UIActionChanges) obj)._ReloadValues)) && (object.Equals((object) this._IsPrimary, (object) ((UIActionChanges) obj)._IsPrimary) && object.Equals((object) this._Index, (object) ((UIActionChanges) obj)._Index) && (object.Equals((object) this._IsHidden, (object) ((UIActionChanges) obj)._IsHidden) && object.Equals((object) this._Name, (object) ((UIActionChanges) obj)._Name))) && (object.Equals((object) this._Description, (object) ((UIActionChanges) obj)._Description) && object.Equals((object) this._ServiceName, (object) ((UIActionChanges) obj)._ServiceName))) && base.Equals(obj);
    }

    public Primitive<string> LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelText));
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

    public Primitive<string> LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (LabelName));
      }
    }

    public Enumeration<BooleanThreeStateEnum, int> SPCEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCEnabled), (object) value);
      }
      get
      {
        return (Enumeration<BooleanThreeStateEnum, int>) this.PropertyGet(nameof (SPCEnabled));
      }
    }

    public Enumeration<BooleanThreeStateEnum, int> WIPMessagesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMessagesRequired), (object) value);
      }
      get
      {
        return (Enumeration<BooleanThreeStateEnum, int>) this.PropertyGet(nameof (WIPMessagesRequired));
      }
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<string> DisableCondition
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisableCondition), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisableCondition));
      }
    }

    public NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Enumeration<BooleanThreeStateEnum, int> ESignatureRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESignatureRequired), (object) value);
      }
      get
      {
        return (Enumeration<BooleanThreeStateEnum, int>) this.PropertyGet(nameof (ESignatureRequired));
      }
    }

    public Primitive<string> ConditionHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionHandler), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ConditionHandler));
      }
    }

    public Primitive<string> HiddenCondition
    {
      [param: In] set
      {
        this.PropertySet(nameof (HiddenCondition), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HiddenCondition));
      }
    }

    public Enumeration<ActionLocationEnum, int> Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Enumeration<ActionLocationEnum, int>) this.PropertyGet(nameof (Location));
      }
    }

    public Enumeration<ButtonPositionTypeEnum, int> ButtonPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonPosition), (object) value);
      }
      get
      {
        return (Enumeration<ButtonPositionTypeEnum, int>) this.PropertyGet(nameof (ButtonPosition));
      }
    }

    public Enumeration<UIDisplayModeEnum, int> DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Enumeration<UIDisplayModeEnum, int>) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public HorizontalShiftOptionsChanges HorizontalShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShift), (object) value);
      }
      get
      {
        return (HorizontalShiftOptionsChanges) this.PropertyGet(nameof (HorizontalShift));
      }
    }

    public NamedObjectRef ActionCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionCategory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ActionCategory));
      }
    }

    public PermissionDefinitionChanges Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (PermissionDefinitionChanges) this.PropertyGet(nameof (Permissions));
      }
    }

    public Primitive<bool> IsDisabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDisabled), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsDisabled));
      }
    }

    public Primitive<bool> ReloadValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReloadValues), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ReloadValues));
      }
    }

    public Primitive<bool> IsPrimary
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPrimary), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsPrimary));
      }
    }

    public Primitive<int> Index
    {
      [param: In] set
      {
        this.PropertySet(nameof (Index), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Index));
      }
    }

    public Primitive<bool> IsHidden
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsHidden), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsHidden));
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

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
