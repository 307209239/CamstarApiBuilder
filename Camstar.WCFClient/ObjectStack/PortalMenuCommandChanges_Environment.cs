// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PortalMenuCommandChanges_Environment
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
  public class PortalMenuCommandChanges_Environment : PortalMenuItemChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_QueryString")]
    [Metadata("URL", "", false, false, false, "String", 1051667, false, false, false, null)]
    protected Environment _QueryString;
    [Metadata("URL", "", false, false, false, "String", 1051635, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_PageURL")]
    protected Environment _PageURL;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_PageDisplay")]
    [Metadata("Enumeration for the New Browser Display:\r\n1 = InCurrentTab\r\n2 = InNewTab\r\n3 = InNewBrowser", "NewBrowserDisplayEnum", false, false, false, "Integer", 1051636, false, false, true, null)]
    protected Environment _PageDisplay;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, true, "NamedObjectRef", 1051501, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_StartPage")]
    protected Environment _StartPage;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_VirtualPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1051633, false, false, true, null)]
    protected Environment _VirtualPage;
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, false, "NamedObjectRef", 1051634, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_PageFlow")]
    protected Environment _PageFlow;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_ListItemToChange")]
    [Metadata("An instance of a PortalMenuCommand is used to provide a command to be performed (in contrast to a sub-menu).", "PortalMenuCommandChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_ObjectToChange")]
    [Metadata("An instance of a PortalMenuItemCommand is used to provide a command to be performed (in contrast to a sub-menu).", "PortalMenuCommand", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PortalMenuCommandChanges_Environment_ServiceName")]
    [Metadata("Name of the CDO Definition for this instance", "", false, false, false, "String", 1049390, false, false, false, null)]
    protected Environment _ServiceName;

    public Environment QueryString
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryString), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QueryString));
      }
    }

    public Environment PageURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageURL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PageURL));
      }
    }

    public Environment PageDisplay
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageDisplay), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PageDisplay));
      }
    }

    public Environment StartPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartPage));
      }
    }

    public Environment VirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (VirtualPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VirtualPage));
      }
    }

    public Environment PageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PageFlow));
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
