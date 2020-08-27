// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIActionChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UILinkActionChanges_Info))]
  [KnownType(typeof (UISubmitActionChanges_Info))]
  [KnownType(typeof (UIFloatPageOpenActionChanges_Info))]
  [KnownType(typeof (UIRedirectActionChanges_Info))]
  [KnownType(typeof (UICustomActionChanges_Info))]
  [Serializable]
  public class UIActionChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_LabelText")]
    protected Info _LabelText;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_LabelName")]
    protected Info _LabelName;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_SPCEnabled")]
    protected Info _SPCEnabled;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_WIPMessagesRequired")]
    protected Info _WIPMessagesRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_DisableCondition")]
    protected Info _DisableCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ESignatureRequired")]
    protected Info _ESignatureRequired;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ConditionHandler")]
    protected Info _ConditionHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_HiddenCondition")]
    protected Info _HiddenCondition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ButtonPosition")]
    protected Info _ButtonPosition;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_DisplayMode")]
    protected Info _DisplayMode;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_HorizontalShift")]
    protected HorizontalShiftOptionsChanges_Info _HorizontalShift;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ActionCategory")]
    protected Info _ActionCategory;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_Permissions")]
    protected PermissionDefinitionChanges_Info _Permissions;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_IsDisabled")]
    protected Info _IsDisabled;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ReloadValues")]
    protected Info _ReloadValues;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_IsPrimary")]
    protected Info _IsPrimary;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_Index")]
    protected Info _Index;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_IsHidden")]
    protected Info _IsHidden;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIActionChanges_Info_ServiceName")]
    protected Info _ServiceName;

    public Info LabelText
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelText));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info LabelName
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelName));
      }
    }

    public Info SPCEnabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (SPCEnabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SPCEnabled));
      }
    }

    public Info WIPMessagesRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMessagesRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WIPMessagesRequired));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info DisableCondition
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisableCondition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisableCondition));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info ESignatureRequired
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESignatureRequired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESignatureRequired));
      }
    }

    public Info ConditionHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConditionHandler), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ConditionHandler));
      }
    }

    public Info HiddenCondition
    {
      [param: In] set
      {
        this.PropertySet(nameof (HiddenCondition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HiddenCondition));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }

    public Info ButtonPosition
    {
      [param: In] set
      {
        this.PropertySet(nameof (ButtonPosition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ButtonPosition));
      }
    }

    public Info DisplayMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayMode));
      }
    }

    public HorizontalShiftOptionsChanges_Info HorizontalShift
    {
      [param: In] set
      {
        this.PropertySet(nameof (HorizontalShift), (object) value);
      }
      get
      {
        return (HorizontalShiftOptionsChanges_Info) this.PropertyGet(nameof (HorizontalShift));
      }
    }

    public Info ActionCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionCategory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionCategory));
      }
    }

    public PermissionDefinitionChanges_Info Permissions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permissions), (object) value);
      }
      get
      {
        return (PermissionDefinitionChanges_Info) this.PropertyGet(nameof (Permissions));
      }
    }

    public Info IsDisabled
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsDisabled), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsDisabled));
      }
    }

    public Info ReloadValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReloadValues), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReloadValues));
      }
    }

    public Info IsPrimary
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsPrimary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsPrimary));
      }
    }

    public Info Index
    {
      [param: In] set
      {
        this.PropertySet(nameof (Index), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Index));
      }
    }

    public Info IsHidden
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsHidden), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsHidden));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
