// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIAction
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIRedirectAction))]
  [KnownType(typeof (UICustomAction))]
  [KnownType(typeof (UISubmitAction))]
  [KnownType(typeof (UIFloatPageOpenAction))]
  [KnownType(typeof (UILinkAction))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIAction : NamedSubentity
  {
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_LabelName")]
    protected Primitive<string> _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_LabelText")]
    protected Primitive<string> _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_HorizontalShift")]
    protected HorizontalShiftOptions _HorizontalShift;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Location")]
    protected Enumeration<ActionLocationEnum, int> _Location;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Permissions")]
    protected PermissionDefinition _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_HiddenCondition")]
    protected Primitive<string> _HiddenCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ConditionHandler")]
    protected Primitive<string> _ConditionHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_DisableCondition")]
    protected Primitive<string> _DisableCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ActionCategory")]
    protected NamedObjectRef _ActionCategory;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ButtonPosition")]
    protected Enumeration<ButtonPositionTypeEnum, int> _ButtonPosition;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_DisplayMode")]
    protected Enumeration<UIDisplayModeEnum, int> _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_WIPMessagesRequired")]
    protected Enumeration<BooleanThreeStateEnum, int> _WIPMessagesRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ESignatureRequired")]
    protected Enumeration<BooleanThreeStateEnum, int> _ESignatureRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_SPCEnabled")]
    protected Enumeration<BooleanThreeStateEnum, int> _SPCEnabled;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_IsDisabled")]
    protected Primitive<bool> _IsDisabled;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ReloadValues")]
    protected Primitive<bool> _ReloadValues;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_IsPrimary")]
    protected Primitive<bool> _IsPrimary;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Index")]
    protected Primitive<int> _Index;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_IsHidden")]
    protected Primitive<bool> _IsHidden;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_ServiceName")]
    protected Primitive<string> _ServiceName;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is UIAction && object.Equals((object) this._Sequence, (object) ((UIAction) obj)._Sequence) && (object.Equals((object) this._LabelName, (object) ((UIAction) obj)._LabelName) && object.Equals((object) this._ExportImportKey, (object) ((UIAction) obj)._ExportImportKey)) && (object.Equals((object) this._LabelText, (object) ((UIAction) obj)._LabelText) && object.Equals((object) this._HorizontalShift, (object) ((UIAction) obj)._HorizontalShift) && (object.Equals((object) this._Location, (object) ((UIAction) obj)._Location) && object.Equals((object) this._Permissions, (object) ((UIAction) obj)._Permissions))) && (object.Equals((object) this._HiddenCondition, (object) ((UIAction) obj)._HiddenCondition) && object.Equals((object) this._ConditionHandler, (object) ((UIAction) obj)._ConditionHandler) && (object.Equals((object) this._DisableCondition, (object) ((UIAction) obj)._DisableCondition) && object.Equals((object) this._ActionCategory, (object) ((UIAction) obj)._ActionCategory)) && (object.Equals((object) this._ButtonPosition, (object) ((UIAction) obj)._ButtonPosition) && object.Equals((object) this._DisplayMode, (object) ((UIAction) obj)._DisplayMode) && (object.Equals((object) this._WIPMessagesRequired, (object) ((UIAction) obj)._WIPMessagesRequired) && object.Equals((object) this._ESignatureRequired, (object) ((UIAction) obj)._ESignatureRequired)))) && (object.Equals((object) this._SPCEnabled, (object) ((UIAction) obj)._SPCEnabled) && object.Equals((object) this._IsDisabled, (object) ((UIAction) obj)._IsDisabled) && (object.Equals((object) this._ReloadValues, (object) ((UIAction) obj)._ReloadValues) && object.Equals((object) this._IsPrimary, (object) ((UIAction) obj)._IsPrimary)) && (object.Equals((object) this._Index, (object) ((UIAction) obj)._Index) && object.Equals((object) this._IsHidden, (object) ((UIAction) obj)._IsHidden) && (object.Equals((object) this._Description, (object) ((UIAction) obj)._Description) && object.Equals((object) this._Name, (object) ((UIAction) obj)._Name))) && (object.Equals((object) this._ServiceName, (object) ((UIAction) obj)._ServiceName) && object.Equals((object) this._IsFrozen, (object) ((UIAction) obj)._IsFrozen))) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
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

    public HorizontalShiftOptions HorizontalShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShift), (object) value);
      }
      get
      {
        return (HorizontalShiftOptions) this.PropertyGet(nameof (HorizontalShift));
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

    public PermissionDefinition Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (PermissionDefinition) this.PropertyGet(nameof (Permissions));
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
