// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MenuItemChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (MenuCommandChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MenuSubMenuChanges_Environment))]
  [Serializable]
  public class MenuItemChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_ListItemToChange")]
    [Metadata("An instance of a MenuItem is used to define an entry within a MenuDefinition. Each MenuItem defines either a command to execute or a reference to another MenuDefinition.", "MenuItemChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049609, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_ImageFileName")]
    protected Environment _ImageFileName;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_MainProgID")]
    [Metadata("ProgID", "", false, false, false, "String", 1049618, false, false, false, null)]
    protected Environment _MainProgID;
    [Metadata("MenuCategoryId -- used to determine which general UI style to follow.\r\n\r\nValid values and their meanings are:\r\n1 = Container Transactions\r\n2 = Resource Transactions\r\n3 = Inquiry Transactions\r\n4 = Query Transactions", "MenuCategoryEnum", false, false, false, "Integer", 1049636, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_CategoryId")]
    protected Environment _CategoryId;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_MenuDefinition")]
    [Metadata("Menu definitions are used to create custom menus on the customers own user interface. Menu Definitions consist of a collection of predefined commands. Through the use of Menu Definitions the needs of different groups of employees can be met in a factory. For example, employees in an operation might be responsible for moving containers and collecting container parametric data, while employees in another operation might be responsible for starting and grouping containers. In both cases, they should see a different menu and therefore they would have a different Menu Definition.", "MenuDefinition", false, false, false, "NamedObjectRef", 1049604, false, false, true, null)]
    protected Environment _MenuDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_Caption")]
    [Metadata("Caption", "", false, true, false, "String", 1049603, false, false, false, null)]
    protected Environment _Caption;
    [Metadata("URL", "", false, false, false, "String", 1049950, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_URL")]
    protected Environment _URL;
    [Metadata("URL", "", false, false, false, "String", 1049948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_WorkingSectionURL")]
    protected Environment _WorkingSectionURL;
    [Metadata("LicenseKey - used in MenuDefinition", "", false, false, false, "String", 1049614, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_UtilityLicenseKey")]
    protected Environment _UtilityLicenseKey;
    [Metadata("SQL/CDO Query Name", "", false, false, false, "String", 1049619, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_SubQuery")]
    protected Environment _SubQuery;
    [Metadata("LicenseKey - used in MenuDefinition", "", false, false, false, "String", 1049610, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_MainLicenseKey")]
    protected Environment _MainLicenseKey;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_UtilityProgID")]
    [Metadata("ProgID", "", false, false, false, "String", 1049621, false, false, false, null)]
    protected Environment _UtilityProgID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_HelpFileName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049608, false, false, false, null)]
    protected Environment _HelpFileName;
    [Metadata("SQL/CDO Query Name", "", false, false, false, "String", 1049612, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_MainQuery")]
    protected Environment _MainQuery;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_ObjectToChange")]
    [Metadata("An instance of a MenuItem is used to define an entry within a MenuDefinition. Each MenuItem defines either a command to execute or a reference to another MenuDefinition.", "MenuItem", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_PortalTab")]
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1052686, false, false, true, null)]
    protected Environment _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_PortalTabOption")]
    [Metadata("Determines the TabOption when a new page is opened.", "PortalTabOptionEnum", false, false, false, "Integer", 1052707, false, false, true, null)]
    protected Environment _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_Sequence")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049605, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049607, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_AllowMultiple")]
    protected Environment _AllowMultiple;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049615, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_HelpContextID")]
    protected Environment _HelpContextID;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049994, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_RefreshOnSelection")]
    protected Environment _RefreshOnSelection;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_ServiceTypeDefID")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049606, false, false, true, null)]
    protected Environment _ServiceTypeDefID;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_ServiceTypeName")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1049606, false, false, true, null)]
    protected Environment _ServiceTypeName;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Numeric Option", "", false, false, true, "Integer", 1049809, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_MenuItemType")]
    protected Environment _MenuItemType;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_HelpFilePath")]
    [Metadata("Optionally specifies the directory to be used as the current directory when the application is launched.", "", false, false, false, "String", 1049616, false, false, false, null)]
    protected Environment _HelpFilePath;
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_ImageFilePath")]
    [Metadata("Optionally specifies the directory to be used as the current directory when the application is launched.", "", false, false, false, "String", 1049617, false, false, false, null)]
    protected Environment _ImageFilePath;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MenuItemChanges_Environment_Description")]
    protected Environment _Description;

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

    public Environment ImageFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImageFileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImageFileName));
      }
    }

    public Environment MainProgID
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainProgID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MainProgID));
      }
    }

    public Environment CategoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CategoryId));
      }
    }

    public Environment MenuDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuDefinition), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MenuDefinition));
      }
    }

    public Environment Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Caption));
      }
    }

    public Environment URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (URL));
      }
    }

    public Environment WorkingSectionURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkingSectionURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WorkingSectionURL));
      }
    }

    public Environment UtilityLicenseKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (UtilityLicenseKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UtilityLicenseKey));
      }
    }

    public Environment SubQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubQuery), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubQuery));
      }
    }

    public Environment MainLicenseKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainLicenseKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MainLicenseKey));
      }
    }

    public Environment UtilityProgID
    {
      [param: In] set
      {
        this.PropertySet(nameof (UtilityProgID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UtilityProgID));
      }
    }

    public Environment HelpFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpFileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HelpFileName));
      }
    }

    public Environment MainQuery
    {
      [param: In] set
      {
        this.PropertySet(nameof (MainQuery), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MainQuery));
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

    public Environment PortalTab
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTab), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalTab));
      }
    }

    public Environment PortalTabOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalTabOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalTabOption));
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

    public Environment AllowMultiple
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMultiple), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowMultiple));
      }
    }

    public Environment HelpContextID
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpContextID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HelpContextID));
      }
    }

    public Environment RefreshOnSelection
    {
      [param: In] set
      {
        this.PropertySet(nameof (RefreshOnSelection), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RefreshOnSelection));
      }
    }

    public Environment ServiceTypeDefID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeDefID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceTypeDefID));
      }
    }

    public Environment ServiceTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceTypeName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceTypeName));
      }
    }

    public Environment IsFrozen
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

    public Environment MenuItemType
    {
      [param: In] set
      {
        this.PropertySet(nameof (MenuItemType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MenuItemType));
      }
    }

    public Environment HelpFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (HelpFilePath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HelpFilePath));
      }
    }

    public Environment ImageFilePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImageFilePath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ImageFilePath));
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
  }
}
