// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIRedirectAction_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIPageRedirectAction_Environment))]
  [KnownType(typeof (UIPageFlowAction_Environment))]
  [KnownType(typeof (UIPageMappingAction_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UIRedirectAction_Environment : UIAction_Environment
  {
    [Metadata("UI PortalTabOption enumeration", "UIPortalTabOptionEnum", false, false, true, "Integer", 1053013, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_PortalTabOption")]
    protected Environment _PortalTabOption;
    [Metadata("Tab defs for use in menus.", "PortalTab", false, false, false, "NamedObjectRef", 1053064, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_PortalTab")]
    protected Environment _PortalTab;
    [Metadata("The value of a named attribute of an object.", "", false, false, true, "String", 1052796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_InitContractHandler")]
    protected Environment _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_DataContractMap")]
    [Metadata("Storages Links definition for UITarget", "UITargetLink", false, false, false, "UITargetLink", 1052806, false, true, false, null)]
    protected UITargetLink_Environment _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_DenyDataContract")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052795, false, false, false, "0")]
    protected Environment _DenyDataContract;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_ForceRedirect")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052794, false, false, false, "0")]
    protected Environment _ForceRedirect;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052782, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Environment_Name")]
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

    public UITargetLink_Environment DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLink_Environment) this.PropertyGet(nameof (DataContractMap));
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
