// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIActionChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UISubmitActionChanges_Environment))]
  [KnownType(typeof (UICustomActionChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UILinkActionChanges_Environment))]
  [KnownType(typeof (UIFloatPageOpenActionChanges_Environment))]
  [KnownType(typeof (UIRedirectActionChanges_Environment))]
  [Serializable]
  public class UIActionChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_LabelText")]
    [Metadata("Label Value.", "", false, false, false, "String", 1049993, false, false, false, null)]
    protected Environment _LabelText;
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_LabelName")]
    [Metadata("LabelName", "", false, false, false, "String", 1052772, false, false, false, null)]
    protected Environment _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_SPCEnabled")]
    [Metadata("{NotSet, Yes, No}", "BooleanThreeStateEnum", false, false, false, "Integer", 1053037, false, false, true, null)]
    protected Environment _SPCEnabled;
    [Metadata("{NotSet, Yes, No}", "BooleanThreeStateEnum", false, false, false, "Integer", 1052995, false, false, true, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_WIPMessagesRequired")]
    protected Environment _WIPMessagesRequired;
    [Metadata("UIAction is used to save Portal Studio data related to an Action", "UIAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_DisableCondition")]
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1052788, false, false, false, null)]
    protected Environment _DisableCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ListItemToChange")]
    [Metadata("UIAction is used to save Portal Studio data related to an Action", "UIActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ESignatureRequired")]
    [Metadata("{NotSet, Yes, No}", "BooleanThreeStateEnum", false, false, false, "Integer", 1052790, false, false, true, "0")]
    protected Environment _ESignatureRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ConditionHandler")]
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1052786, false, false, false, null)]
    protected Environment _ConditionHandler;
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1052789, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_HiddenCondition")]
    protected Environment _HiddenCondition;
    [Metadata("Action Location", "ActionLocationEnum", false, false, false, "Integer", 1048660, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_Location")]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ButtonPosition")]
    [Metadata("ButtonPositionType", "ButtonPositionTypeEnum", false, false, false, "Integer", 1052792, false, false, false, null)]
    protected Environment _ButtonPosition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_DisplayMode")]
    [Metadata("Indicates the display mode for UI control.", "UIDisplayModeEnum", false, false, false, "Integer", 1050521, false, false, true, "1")]
    protected Environment _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_HorizontalShift")]
    [Metadata("Horizontal Shift Options", "HorizontalShiftOptionsChanges", false, false, false, "HorizontalShiftOptionsChanges", 1052821, false, false, false, null)]
    protected HorizontalShiftOptionsChanges_Environment _HorizontalShift;
    [Metadata("ActionCategory object is using to collect Actions in categories on SourcePages", "ActionCategory", false, false, false, "NamedObjectRef", 1053020, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ActionCategory")]
    protected Environment _ActionCategory;
    [Metadata("Permission Definition", "PermissionDefinitionChanges", false, false, false, "PermissionDefinitionChanges", 1050786, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_Permissions")]
    protected PermissionDefinitionChanges_Environment _Permissions;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052756, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_IsDisabled")]
    protected Environment _IsDisabled;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052791, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ReloadValues")]
    protected Environment _ReloadValues;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052757, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_IsPrimary")]
    protected Environment _IsPrimary;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_Index")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1052787, false, false, false, null)]
    protected Environment _Index;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_IsHidden")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052755, false, false, false, "0")]
    protected Environment _IsHidden;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052777, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Environment_ServiceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049390, false, false, false, null)]
    protected Environment _ServiceName;

    public Environment LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelText));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LabelName));
      }
    }

    public Environment SPCEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCEnabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SPCEnabled));
      }
    }

    public Environment WIPMessagesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMessagesRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPMessagesRequired));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment DisableCondition
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisableCondition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisableCondition));
      }
    }

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment ESignatureRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESignatureRequired), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESignatureRequired));
      }
    }

    public Environment ConditionHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionHandler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ConditionHandler));
      }
    }

    public Environment HiddenCondition
    {
      [param: In] set
      {
        this.PropertySet(nameof (HiddenCondition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HiddenCondition));
      }
    }

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
      }
    }

    public Environment ButtonPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonPosition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ButtonPosition));
      }
    }

    public Environment DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public HorizontalShiftOptionsChanges_Environment HorizontalShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShift), (object) value);
      }
      get
      {
        return (HorizontalShiftOptionsChanges_Environment) this.PropertyGet(nameof (HorizontalShift));
      }
    }

    public Environment ActionCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionCategory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionCategory));
      }
    }

    public PermissionDefinitionChanges_Environment Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (PermissionDefinitionChanges_Environment) this.PropertyGet(nameof (Permissions));
      }
    }

    public Environment IsDisabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDisabled), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsDisabled));
      }
    }

    public Environment ReloadValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReloadValues), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ReloadValues));
      }
    }

    public Environment IsPrimary
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPrimary), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsPrimary));
      }
    }

    public Environment Index
    {
      [param: In] set
      {
        this.PropertySet(nameof (Index), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Index));
      }
    }

    public Environment IsHidden
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsHidden), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsHidden));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
