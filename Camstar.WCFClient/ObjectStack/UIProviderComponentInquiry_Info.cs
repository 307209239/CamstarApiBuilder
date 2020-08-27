// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIProviderComponentInquiry_Info
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
  public class UIProviderComponentInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_ActivityGUID")]
    protected Info _ActivityGUID;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_VirtualPageName")]
    protected Info _VirtualPageName;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_SharedContent")]
    protected Info _SharedContent;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_RequestedContent")]
    protected Info _RequestedContent;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_StateGUID")]
    protected Info _StateGUID;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_UIVirtualPage")]
    protected UIVirtualPage_Info _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_UIVirtualPageRef")]
    protected Info _UIVirtualPageRef;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_UserPersonalization")]
    protected UIPersonalization_Info _UserPersonalization;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_UIMode")]
    protected Info _UIMode;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_PersonalizationIndex")]
    protected Info _PersonalizationIndex;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_Owner")]
    protected Info _Owner;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_PageFlowName")]
    protected Info _PageFlowName;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Info_OwnerName")]
    protected Info _OwnerName;

    public Info ActivityGUID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityGUID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActivityGUID));
      }
    }

    public Info VirtualPageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (VirtualPageName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VirtualPageName));
      }
    }

    public Info SharedContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (SharedContent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SharedContent));
      }
    }

    public Info RequestedContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestedContent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequestedContent));
      }
    }

    public Info StateGUID
    {
      [param: In] set
      {
        this.PropertySet(nameof (StateGUID), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StateGUID));
      }
    }

    public UIVirtualPage_Info UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (UIVirtualPage_Info) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public Info UIVirtualPageRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPageRef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIVirtualPageRef));
      }
    }

    public UIPersonalization_Info UserPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalization_Info) this.PropertyGet(nameof (UserPersonalization));
      }
    }

    public Info UIMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIMode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIMode));
      }
    }

    public Info PersonalizationIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (PersonalizationIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PersonalizationIndex));
      }
    }

    public Info Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Owner));
      }
    }

    public Info PageFlowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PageFlowName));
      }
    }

    public Info OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OwnerName));
      }
    }
  }
}
