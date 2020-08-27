// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIRedirectActionChanges_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (UIPageRedirectActionChanges_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (UIPageFlowActionChanges_Info))]
  [KnownType(typeof (UIPageMappingActionChanges_Info))]
  [Serializable]
  public class UIRedirectActionChanges_Info : UIActionChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_PortalTabOption")]
    protected Info _PortalTabOption;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_PortalTab")]
    protected Info _PortalTab;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_DataContractMap")]
    protected UITargetLinkChanges_Info _DataContractMap;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_InitContractHandler")]
    protected Info _InitContractHandler;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_DenyDataContract")]
    protected Info _DenyDataContract;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_ForceRedirect")]
    protected Info _ForceRedirect;
    [DataMember(EmitDefaultValue = false, Name = "UIRedirectActionChanges_Info_Name")]
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

    public UITargetLinkChanges_Info DataContractMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataContractMap), (object) value);
      }
      get
      {
        return (UITargetLinkChanges_Info) this.PropertyGet(nameof (DataContractMap));
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
