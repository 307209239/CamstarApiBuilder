// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageRedirectActionChanges_Environment
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
  public class UIPageRedirectActionChanges_Environment : UIRedirectActionChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_Environment_ListItemToChange")]
    [Metadata("UI Page Redirect Action", "UIPageRedirectActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_Environment_UIVirtualPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1051633, false, false, true, null)]
    protected Environment _UIVirtualPage;
    [Metadata("UI Page Redirect Action", "UIPageRedirectAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052783, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectActionChanges_Environment_Name")]
    protected new Environment _Name;

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

    public Environment UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIVirtualPage));
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
