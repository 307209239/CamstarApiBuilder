// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIVirtualPageMaint_Environment
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
  public class UIVirtualPageMaint_Environment : UIProviderComponentMaint_Environment
  {
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("These are the actions that are performed to simulate a Content Management System", "ContentActionEnum", false, false, false, "Integer", 1052339, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_Environment_ContentAction")]
    protected Environment _ContentAction;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPageChanges", false, false, false, "UIVirtualPageChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIVirtualPageMaint_Environment_ObjectChanges")]
    protected UIVirtualPageChanges_Environment _ObjectChanges;

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

    public Environment ContentAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContentAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContentAction));
      }
    }

    public UIVirtualPageChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (UIVirtualPageChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
