// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIPageFlowActionChanges_Environment
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
  public class UIPageFlowActionChanges_Environment : UIRedirectActionChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_Environment_ListItemToChange")]
    [Metadata("UI PageFlow Redirect Action", "UIPageFlowActionChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("PageFlow component for the UI Personalization Persistence Provider.", "UIPageFlow", false, false, false, "NamedObjectRef", 1052735, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_Environment_UIPageFlow")]
    protected Environment _UIPageFlow;
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_Environment_ObjectToChange")]
    [Metadata("UI PageFlow Redirect Action", "UIPageFlowAction", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1052784, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIPageFlowActionChanges_Environment_Name")]
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
