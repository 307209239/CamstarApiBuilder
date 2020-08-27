// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowAction_Environment
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
  public class UIPageFlowAction_Environment : UIRedirectAction_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowAction_Environment_UIPageFlow")]
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, true, "NamedObjectRef", 1052735, false, false, false, null)]
    protected Environment _UIPageFlow;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052784, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowAction_Environment_Name")]
    protected new Environment _Name;

    public Environment UIPageFlow
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPageFlow), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIPageFlow));
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
