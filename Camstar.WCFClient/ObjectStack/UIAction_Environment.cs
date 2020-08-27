// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIAction_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UILinkAction_Environment))]
  [KnownType(typeof (UICustomAction_Environment))]
  [KnownType(typeof (UIRedirectAction_Environment))]
  [KnownType(typeof (UIFloatPageOpenAction_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UISubmitAction_Environment))]
  [Serializable]
  public class UIAction_Environment : NamedSubentity_Environment
  {
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_Sequence")]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_LabelName")]
    [Metadata("LabelName", "", false, false, true, "String", 1052772, false, false, false, null)]
    protected Environment _LabelName;
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_LabelText")]
    [Metadata("Label Value.", "", false, false, true, "String", 1049993, false, false, false, null)]
    protected Environment _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_HorizontalShift")]
    [Metadata("Horizontal Shift Options", "HorizontalShiftOptions", false, false, false, "HorizontalShiftOptions", 1052821, false, false, false, null)]
    protected HorizontalShiftOptions_Environment _HorizontalShift;
    [Metadata("Action Location", "ActionLocationEnum", false, false, false, "Integer", 1048660, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_Location")]
    protected Environment _Location;
    [Metadata("Permission Definition", "PermissionDefinition", false, false, false, "PermissionDefinition", 1050786, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_Permissions")]
    protected PermissionDefinition_Environment _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_HiddenCondition")]
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1052789, false, false, false, null)]
    protected Environment _HiddenCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ConditionHandler")]
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1052786, false, false, false, null)]
    protected Environment _ConditionHandler;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1052788, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_DisableCondition")]
    protected Environment _DisableCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ActionCategory")]
    [Metadata("ActionCategory object is using to collect Actions in categories on SourcePages", "ActionCategory", false, false, true, "NamedObjectRef", 1053020, false, false, false, null)]
    protected Environment _ActionCategory;
    [Metadata("ButtonPositionType", "ButtonPositionTypeEnum", false, false, true, "Integer", 1052792, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ButtonPosition")]
    protected Environment _ButtonPosition;
    [Metadata("Indicates the display mode for UI control.", "UIDisplayModeEnum", false, false, true, "Integer", 1050521, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_DisplayMode")]
    protected Environment _DisplayMode;
    [Metadata("{NotSet, Yes, No}", "BooleanThreeStateEnum", false, false, true, "Integer", 1052995, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_WIPMessagesRequired")]
    protected Environment _WIPMessagesRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ESignatureRequired")]
    [Metadata("{NotSet, Yes, No}", "BooleanThreeStateEnum", false, false, true, "Integer", 1052790, false, false, false, "0")]
    protected Environment _ESignatureRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_SPCEnabled")]
    [Metadata("{NotSet, Yes, No}", "BooleanThreeStateEnum", false, false, true, "Integer", 1053037, false, false, false, null)]
    protected Environment _SPCEnabled;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052756, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_IsDisabled")]
    protected Environment _IsDisabled;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052791, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ReloadValues")]
    protected Environment _ReloadValues;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052757, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_IsPrimary")]
    protected Environment _IsPrimary;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1052787, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_Index")]
    protected Environment _Index;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_IsHidden")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052755, false, false, false, "0")]
    protected Environment _IsHidden;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052777, false, false, false, null)]
    protected new Environment _Name;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1049390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_ServiceName")]
    protected Environment _ServiceName;
    [DataMember(EmitDefaultValue = false, Name = "UIAction_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;

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

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
      }
    }

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

    public HorizontalShiftOptions_Environment HorizontalShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShift), (object) value);
      }
      get
      {
        return (HorizontalShiftOptions_Environment) this.PropertyGet(nameof (HorizontalShift));
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

    public PermissionDefinition_Environment Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (PermissionDefinition_Environment) this.PropertyGet(nameof (Permissions));
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

    public new Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
