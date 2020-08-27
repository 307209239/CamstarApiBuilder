// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISourcePageChanges_Info
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
  public class UISourcePageChanges_Info : SubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_Links")]
    protected UITargetLinkChanges_Info _Links;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_Conditions")]
    protected UITargetConditionChanges_Info _Conditions;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_UIVirtualPage")]
    protected Info _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePageChanges_Info_IsFrozen")]
    protected Info _IsFrozen;

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
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

    public UITargetLinkChanges_Info Links
    {
      [param: In] set
      {
        this.PropertySet(nameof (Links), (object) value);
      }
      get
      {
        return (UITargetLinkChanges_Info) this.PropertyGet(nameof (Links));
      }
    }

    public UITargetConditionChanges_Info Conditions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Conditions), (object) value);
      }
      get
      {
        return (UITargetConditionChanges_Info) this.PropertyGet(nameof (Conditions));
      }
    }

    public Info UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIVirtualPage));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
