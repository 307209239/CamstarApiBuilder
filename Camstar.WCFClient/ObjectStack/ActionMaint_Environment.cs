// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionMaint_Environment
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
  public class ActionMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_PageFilter")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1052438, false, false, false, null)]
    protected Environment _PageFilter;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_Actions")]
    [Metadata("The Action CDO is based on an ActionRule and used to identify if this action could be performed against an object.", "ActionDef", false, false, true, "ActionDef", 1052897, false, true, false, null)]
    protected ActionDef_Environment _Actions;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_ActionSource")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1052924, false, false, false, null)]
    protected Environment _ActionSource;
    [Metadata("The Action CDO is based on an ActionRule and used to identify if this action could be performed against an object.", "ActionDef", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Enumeration for UIAction type:\r\nUICustomActionChanges = CustomAction\r\nUIFloatPageOpenActionChanges = FloatPageOpenAction\r\nUILinkActionChanges = LinkAction\r\nUIPageFlowRedirectActChanges = PageFlowRedirectAction\r\nUIPageMappingActionChanges = PageMappingAction\r\nUIPageRedirectActionChanges = PageRedirectAction\r\nUISubmitActionChanges = SubmitActionUIActionType", "UIActionTypeEnum", false, false, true, "Integer", 1052690, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_UIActionType")]
    protected Environment _UIActionType;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_ObjectListInquiry")]
    [Metadata("The Action CDO is based on an ActionRule and used to identify if this action could be performed against an object.", "ActionDef", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ActionMaint_Environment_ObjectChanges")]
    [Metadata("The Action CDO is based on an ActionRule and used to identify if this action could be performed against an object.", "ActionDefChanges", false, false, false, "ActionDefChanges", 1048873, true, false, false, null)]
    protected ActionDefChanges_Environment _ObjectChanges;

    public Environment PageFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (PageFilter), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PageFilter));
      }
    }

    public ActionDef_Environment Actions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actions), (object) value);
      }
      get
      {
        return (ActionDef_Environment) this.PropertyGet(nameof (Actions));
      }
    }

    public Environment ActionSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionSource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionSource));
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

    public Environment UIActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIActionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIActionType));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public ActionDefChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActionDefChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
