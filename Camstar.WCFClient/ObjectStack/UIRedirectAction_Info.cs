// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIRedirectAction_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIPageMappingAction_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UIPageRedirectAction_Info))]
  [KnownType(typeof (UIPageFlowAction_Info))]
  [Serializable]
  public class UIRedirectAction_Info : UIAction_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_PortalTabOption")]
    protected Info _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_PortalTab")]
    protected Info _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_InitContractHandler")]
    protected Info _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_DataContractMap")]
    protected UITargetLink_Info _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_DenyDataContract")]
    protected Info _DenyDataContract;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_ForceRedirect")]
    protected Info _ForceRedirect;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectAction_Info_Name")]
    protected new Info _Name;

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

    public Info InitContractHandler
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitContractHandler), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InitContractHandler));
      }
    }

    public UITargetLink_Info DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLink_Info) this.PropertyGet(nameof (DataContractMap));
      }
    }

    public Info DenyDataContract
    {
      [param: In] set
      {
        this.PropertySet(nameof (DenyDataContract), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DenyDataContract));
      }
    }

    public Info ForceRedirect
    {
      [param: In] set
      {
        this.PropertySet(nameof (ForceRedirect), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ForceRedirect));
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
  }
}
