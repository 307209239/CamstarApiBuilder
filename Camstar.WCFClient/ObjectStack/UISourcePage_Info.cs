// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UISourcePage_Info
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
  public class UISourcePage_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Info_Links")]
    protected UITargetLink_Info _Links;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Info_Conditions")]
    protected UITargetCondition_Info _Conditions;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Info_UIVirtualPage")]
    protected Info _UIVirtualPage;
    [DataMember(EmitDefaultValue = false, Name = "UISourcePage_Info_IsFrozen")]
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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public UITargetLink_Info Links
    {
      [param: In] set
      {
        this.PropertySet(nameof (Links), (object) value);
      }
      get
      {
        return (UITargetLink_Info) this.PropertyGet(nameof (Links));
      }
    }

    public UITargetCondition_Info Conditions
    {
      [param: In] set
      {
        this.PropertySet(nameof (Conditions), (object) value);
      }
      get
      {
        return (UITargetCondition_Info) this.PropertyGet(nameof (Conditions));
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
