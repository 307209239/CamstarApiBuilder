// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISourcePageChanges_Environment
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
  public class UISourcePageChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, false, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [Metadata("UI Source Page", "UISourcePageChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_ObjectToChange")]
    [Metadata("UI Source Page", "UISourcePage", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("UI Target Link", "UITargetLinkChanges", false, false, false, "UITargetLinkChanges", 1052746, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_Links")]
    protected UITargetLinkChanges_Environment _Links;
    [Metadata("UI Target Condition", "UITargetConditionChanges", false, false, false, "UITargetConditionChanges", 1052750, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_Conditions")]
    protected UITargetConditionChanges_Environment _Conditions;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_UIVirtualPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1052438, false, false, false, null)]
    protected Environment _UIVirtualPage;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

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

    public UITargetLinkChanges_Environment Links
    {
      [param: In] set
      {
        this.PropertySet(nameof (Links), (object) value);
      }
      get
      {
        return (UITargetLinkChanges_Environment) this.PropertyGet(nameof (Links));
      }
    }

    public UITargetConditionChanges_Environment Conditions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Conditions), (object) value);
      }
      get
      {
        return (UITargetConditionChanges_Environment) this.PropertyGet(nameof (Conditions));
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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
