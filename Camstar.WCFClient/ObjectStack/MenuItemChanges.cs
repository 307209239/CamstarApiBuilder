// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuItemChanges
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MenuCommandChanges))]
  [KnownType(typeof (MenuSubMenuChanges))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MenuItemChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_ImageFileName")]
    protected Primitive<string> _ImageFileName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_MainProgID")]
    protected Primitive<string> _MainProgID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_CategoryId")]
    protected Enumeration<MenuCategoryEnum, int> _CategoryId;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_MenuDefinition")]
    protected NamedObjectRef _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Caption")]
    protected Primitive<string> _Caption;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_URL")]
    protected Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_WorkingSectionURL")]
    protected Primitive<string> _WorkingSectionURL;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_UtilityLicenseKey")]
    protected Primitive<string> _UtilityLicenseKey;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_SubQuery")]
    protected Primitive<string> _SubQuery;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_MainLicenseKey")]
    protected Primitive<string> _MainLicenseKey;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_UtilityProgID")]
    protected Primitive<string> _UtilityProgID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_HelpFileName")]
    protected Primitive<string> _HelpFileName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_MainQuery")]
    protected Primitive<string> _MainQuery;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_PortalTab")]
    protected NamedObjectRef _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_PortalTabOption")]
    protected Enumeration<PortalTabOptionEnum, int> _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_AllowMultiple")]
    protected Primitive<bool> _AllowMultiple;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_HelpContextID")]
    protected Primitive<int> _HelpContextID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_RefreshOnSelection")]
    protected Primitive<bool> _RefreshOnSelection;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_ServiceTypeDefID")]
    protected Primitive<int> _ServiceTypeDefID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_ServiceTypeName")]
    protected Primitive<string> _ServiceTypeName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_MenuItemType")]
    protected Primitive<int> _MenuItemType;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_HelpFilePath")]
    protected Primitive<string> _HelpFilePath;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_ImageFilePath")]
    protected Primitive<string> _ImageFilePath;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is MenuItemChanges && object.Equals((object) this._ListItemToChange, (object) ((MenuItemChanges) obj)._ListItemToChange) && (object.Equals((object) this._ImageFileName, (object) ((MenuItemChanges) obj)._ImageFileName) && object.Equals((object) this._MainProgID, (object) ((MenuItemChanges) obj)._MainProgID)) && (object.Equals((object) this._CategoryId, (object) ((MenuItemChanges) obj)._CategoryId) && object.Equals((object) this._MenuDefinition, (object) ((MenuItemChanges) obj)._MenuDefinition) && (object.Equals((object) this._Caption, (object) ((MenuItemChanges) obj)._Caption) && object.Equals((object) this._URL, (object) ((MenuItemChanges) obj)._URL))) && (object.Equals((object) this._WorkingSectionURL, (object) ((MenuItemChanges) obj)._WorkingSectionURL) && object.Equals((object) this._UtilityLicenseKey, (object) ((MenuItemChanges) obj)._UtilityLicenseKey) && (object.Equals((object) this._SubQuery, (object) ((MenuItemChanges) obj)._SubQuery) && object.Equals((object) this._MainLicenseKey, (object) ((MenuItemChanges) obj)._MainLicenseKey)) && (object.Equals((object) this._UtilityProgID, (object) ((MenuItemChanges) obj)._UtilityProgID) && object.Equals((object) this._HelpFileName, (object) ((MenuItemChanges) obj)._HelpFileName) && (object.Equals((object) this._MainQuery, (object) ((MenuItemChanges) obj)._MainQuery) && object.Equals((object) this._ObjectToChange, (object) ((MenuItemChanges) obj)._ObjectToChange)))) && (object.Equals((object) this._PortalTab, (object) ((MenuItemChanges) obj)._PortalTab) && object.Equals((object) this._PortalTabOption, (object) ((MenuItemChanges) obj)._PortalTabOption) && (object.Equals((object) this._Sequence, (object) ((MenuItemChanges) obj)._Sequence) && object.Equals((object) this._AllowMultiple, (object) ((MenuItemChanges) obj)._AllowMultiple)) && (object.Equals((object) this._HelpContextID, (object) ((MenuItemChanges) obj)._HelpContextID) && object.Equals((object) this._RefreshOnSelection, (object) ((MenuItemChanges) obj)._RefreshOnSelection) && (object.Equals((object) this._ServiceTypeDefID, (object) ((MenuItemChanges) obj)._ServiceTypeDefID) && object.Equals((object) this._ServiceTypeName, (object) ((MenuItemChanges) obj)._ServiceTypeName))) && (object.Equals((object) this._IsFrozen, (object) ((MenuItemChanges) obj)._IsFrozen) && object.Equals((object) this._MenuItemType, (object) ((MenuItemChanges) obj)._MenuItemType) && (object.Equals((object) this._HelpFilePath, (object) ((MenuItemChanges) obj)._HelpFilePath) && object.Equals((object) this._ImageFilePath, (object) ((MenuItemChanges) obj)._ImageFilePath)) && object.Equals((object) this._Description, (object) ((MenuItemChanges) obj)._Description))) && base.Equals(obj);
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

    public Primitive<string> ImageFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImageFileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ImageFileName));
      }
    }

    public Primitive<string> MainProgID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainProgID), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MainProgID));
      }
    }

    public Enumeration<MenuCategoryEnum, int> CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Enumeration<MenuCategoryEnum, int>) this.PropertyGet(nameof (CategoryId));
      }
    }

    public NamedObjectRef MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MenuDefinition));
      }
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

    public Primitive<string> URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (URL));
      }
    }

    public Primitive<string> WorkingSectionURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingSectionURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (WorkingSectionURL));
      }
    }

    public Primitive<string> UtilityLicenseKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (UtilityLicenseKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UtilityLicenseKey));
      }
    }

    public Primitive<string> SubQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubQuery), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SubQuery));
      }
    }

    public Primitive<string> MainLicenseKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainLicenseKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MainLicenseKey));
      }
    }

    public Primitive<string> UtilityProgID
    {
      [param: In] set
      {
        this.PropertySet(nameof (UtilityProgID), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UtilityProgID));
      }
    }

    public Primitive<string> HelpFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpFileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HelpFileName));
      }
    }

    public Primitive<string> MainQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainQuery), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MainQuery));
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

    public NamedObjectRef PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Enumeration<PortalTabOptionEnum, int> PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Enumeration<PortalTabOptionEnum, int>) this.PropertyGet(nameof (PortalTabOption));
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

    public Primitive<bool> AllowMultiple
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMultiple), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowMultiple));
      }
    }

    public Primitive<int> HelpContextID
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpContextID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (HelpContextID));
      }
    }

    public Primitive<bool> RefreshOnSelection
    {
      [param: In] set
      {
        this.PropertySet(nameof (RefreshOnSelection), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RefreshOnSelection));
      }
    }

    public Primitive<int> ServiceTypeDefID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeDefID), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ServiceTypeDefID));
      }
    }

    public Primitive<string> ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServiceTypeName));
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

    public Primitive<int> MenuItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (MenuItemType));
      }
    }

    public Primitive<string> HelpFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpFilePath), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HelpFilePath));
      }
    }

    public Primitive<string> ImageFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImageFilePath), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ImageFilePath));
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
  }
}
