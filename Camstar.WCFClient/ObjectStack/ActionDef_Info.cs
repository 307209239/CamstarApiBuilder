// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDef_Info
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
  public class ActionDef_Info : NamedDataObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_ActionType")]
    protected Info _ActionType;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_UIAction")]
    protected UIAction_Info _UIAction;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_ActionRules")]
    protected Info _ActionRules;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_SourcePages")]
    protected UISourcePage_Info _SourcePages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Info_Notes")]
    protected new Info _Notes;

    public Info ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionType));
      }
    }

    public UIAction_Info UIAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIAction), (object) value);
      }
      get
      {
        return (UIAction_Info) this.PropertyGet(nameof (UIAction));
      }
    }

    public new Info FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Info ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public Info ActionRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRules), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActionRules));
      }
    }

    public UISourcePage_Info SourcePages
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourcePages), (object) value);
      }
      get
      {
        return (UISourcePage_Info) this.PropertyGet(nameof (SourcePages));
      }
    }

    public new Info AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Info InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new ChangeHistory_Info ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Info) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public new Info IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IconId));
      }
    }

    public new Info IsFrozen
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

    public new Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public new Info Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
