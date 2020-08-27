// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuItemChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MenuCommandChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MenuSubMenuChanges_Info))]
  [Serializable]
  public class MenuItemChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_ImageFileName")]
    protected Info _ImageFileName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_MainProgID")]
    protected Info _MainProgID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_CategoryId")]
    protected Info _CategoryId;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_MenuDefinition")]
    protected Info _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_Caption")]
    protected Info _Caption;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_URL")]
    protected Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_WorkingSectionURL")]
    protected Info _WorkingSectionURL;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_UtilityLicenseKey")]
    protected Info _UtilityLicenseKey;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_SubQuery")]
    protected Info _SubQuery;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_MainLicenseKey")]
    protected Info _MainLicenseKey;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_UtilityProgID")]
    protected Info _UtilityProgID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_HelpFileName")]
    protected Info _HelpFileName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_MainQuery")]
    protected Info _MainQuery;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_PortalTab")]
    protected Info _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_PortalTabOption")]
    protected Info _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_AllowMultiple")]
    protected Info _AllowMultiple;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_HelpContextID")]
    protected Info _HelpContextID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_RefreshOnSelection")]
    protected Info _RefreshOnSelection;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_ServiceTypeDefID")]
    protected Info _ServiceTypeDefID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_ServiceTypeName")]
    protected Info _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_MenuItemType")]
    protected Info _MenuItemType;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_HelpFilePath")]
    protected Info _HelpFilePath;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_ImageFilePath")]
    protected Info _ImageFilePath;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Info_Description")]
    protected Info _Description;

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

    public Info ImageFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImageFileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImageFileName));
      }
    }

    public Info MainProgID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainProgID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MainProgID));
      }
    }

    public Info CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CategoryId));
      }
    }

    public Info MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public Info Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Caption));
      }
    }

    public Info URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (URL));
      }
    }

    public Info WorkingSectionURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingSectionURL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkingSectionURL));
      }
    }

    public Info UtilityLicenseKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (UtilityLicenseKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UtilityLicenseKey));
      }
    }

    public Info SubQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubQuery), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubQuery));
      }
    }

    public Info MainLicenseKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainLicenseKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MainLicenseKey));
      }
    }

    public Info UtilityProgID
    {
      [param: In] set
      {
        this.PropertySet(nameof (UtilityProgID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UtilityProgID));
      }
    }

    public Info HelpFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpFileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HelpFileName));
      }
    }

    public Info MainQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainQuery), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MainQuery));
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

    public Info PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Info PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalTabOption));
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

    public Info AllowMultiple
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMultiple), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowMultiple));
      }
    }

    public Info HelpContextID
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpContextID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HelpContextID));
      }
    }

    public Info RefreshOnSelection
    {
      [param: In] set
      {
        this.PropertySet(nameof (RefreshOnSelection), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RefreshOnSelection));
      }
    }

    public Info ServiceTypeDefID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeDefID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceTypeDefID));
      }
    }

    public Info ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceTypeName));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info MenuItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MenuItemType));
      }
    }

    public Info HelpFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpFilePath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HelpFilePath));
      }
    }

    public Info ImageFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImageFilePath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ImageFilePath));
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
  }
}
