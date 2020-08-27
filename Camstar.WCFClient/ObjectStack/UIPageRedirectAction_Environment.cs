// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageRedirectAction_Environment
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
  public class UIPageRedirectAction_Environment : UIRedirectAction_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectAction_Environment_UIVirtualPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, true, "NamedObjectRef", 1051633, false, false, false, null)]
    protected Environment _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UIPageRedirectAction_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052783, false, false, false, null)]
    protected new Environment _Name;

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
