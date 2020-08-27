// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIRedirectActionChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UIPageRedirectActionChanges_Environment))]
  [KnownType(typeof (UIPageMappingActionChanges_Environment))]
  [KnownType(typeof (UIPageFlowActionChanges_Environment))]
  [Serializable]
  public class UIRedirectActionChanges_Environment : UIActionChanges_Environment
  {
    [Metadata("UI PortalTabOption enumeration", "UIPortalTabOptionEnum", false, false, false, "Integer", 1053013, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_PortalTabOption")]
    protected Environment _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_PortalTab")]
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1053064, false, false, false, null)]
    protected Environment _PortalTab;
    [Metadata("UI Redirect Action", "UIRedirectAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_DataContractMap")]
    [Metadata("UI Target Link", "UITargetLinkChanges", false, false, false, "UITargetLinkChanges", 1052806, false, true, false, null)]
    protected UITargetLinkChanges_Environment _DataContractMap;
    [Metadata("The value of a named attribute of an object.", "", false, false, false, "String", 1052796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_InitContractHandler")]
    protected Environment _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_ListItemToChange")]
    [Metadata("UI Redirect Action", "UIRedirectActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_DenyDataContract")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052795, false, false, false, "0")]
    protected Environment _DenyDataContract;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_ForceRedirect")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052794, false, false, false, "0")]
    protected Environment _ForceRedirect;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052782, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Environment_Name")]
    protected new Environment _Name;

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

    public UITargetLinkChanges_Environment DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLinkChanges_Environment) this.PropertyGet(nameof (DataContractMap));
      }
    }

    public Environment InitContractHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitContractHandler), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitContractHandler));
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

    public Environment DenyDataContract
    {
      [param: In] set
      {
        this.PropertySet(nameof (DenyDataContract), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DenyDataContract));
      }
    }

    public Environment ForceRedirect
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceRedirect), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ForceRedirect));
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
  }
}
