// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIProviderComponentInquiry_Environment
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
  public class UIProviderComponentInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_ActivityGUID")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, false, "String", 1051515, false, false, false, null)]
    protected Environment _ActivityGUID;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_VirtualPageName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1051518, false, false, false, null)]
    protected Environment _VirtualPageName;
    [Metadata("LongString", "", false, false, false, "String", 1051540, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_SharedContent")]
    protected Environment _SharedContent;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_RequestedContent")]
    [Metadata("LongString", "", false, false, true, "String", 1051516, false, false, false, null)]
    protected Environment _RequestedContent;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_StateGUID")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, false, "String", 1051517, false, false, false, null)]
    protected Environment _StateGUID;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "UIVirtualPage", 1052357, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_UIVirtualPage")]
    protected UIVirtualPage_Environment _UIVirtualPage;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, true, false, "NamedObjectRef", 1052358, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_UIVirtualPageRef")]
    protected Environment _UIVirtualPageRef;
    [Metadata("UI Personalization data", "UIPersonalization", false, false, false, "UIPersonalization", 1052359, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_UserPersonalization")]
    protected UIPersonalization_Environment _UserPersonalization;
    [Metadata("Indicates the mode for which the UI is running.", "UIModeEnum", false, false, false, "Integer", 1052356, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_UIMode")]
    protected Environment _UIMode;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_PersonalizationIndex")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1051539, false, false, false, null)]
    protected Environment _PersonalizationIndex;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1048824, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_Owner")]
    protected Environment _Owner;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051529, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_PageFlowName")]
    protected Environment _PageFlowName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050120, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponentInquiry_Environment_OwnerName")]
    protected Environment _OwnerName;

    public Environment ActivityGUID
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityGUID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivityGUID));
      }
    }

    public Environment VirtualPageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (VirtualPageName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (VirtualPageName));
      }
    }

    public Environment SharedContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (SharedContent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SharedContent));
      }
    }

    public Environment RequestedContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequestedContent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RequestedContent));
      }
    }

    public Environment StateGUID
    {
      [param: In] set
      {
        this.PropertySet(nameof (StateGUID), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StateGUID));
      }
    }

    public UIVirtualPage_Environment UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (UIVirtualPage_Environment) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public Environment UIVirtualPageRef
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPageRef), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIVirtualPageRef));
      }
    }

    public UIPersonalization_Environment UserPersonalization
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserPersonalization), (object) value);
      }
      get
      {
        return (UIPersonalization_Environment) this.PropertyGet(nameof (UserPersonalization));
      }
    }

    public Environment UIMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIMode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIMode));
      }
    }

    public Environment PersonalizationIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (PersonalizationIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PersonalizationIndex));
      }
    }

    public Environment Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Owner));
      }
    }

    public Environment PageFlowName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFlowName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PageFlowName));
      }
    }

    public Environment OwnerName
    {
      [param: In] set
      {
        this.PropertySet(nameof (OwnerName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OwnerName));
      }
    }
  }
}
