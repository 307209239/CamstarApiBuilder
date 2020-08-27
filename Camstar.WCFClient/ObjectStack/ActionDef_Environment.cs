// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionDef_Environment
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
  public class ActionDef_Environment : NamedDataObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_ActionType")]
    [Metadata("Enumeration for the Action Types:\r\n1 = Container\r\n2 = QualityObject\r\n3 = ChangePackage", "ActionTypeEnum", false, false, true, "Integer", 1052690, false, false, false, null)]
    protected Environment _ActionType;
    [Metadata("UIAction is used to save Portal Studio data related to an Action", "UIAction", false, false, true, "UIAction", 1052775, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_UIAction")]
    protected UIAction_Environment _UIAction;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_FilterTags")]
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    protected new Environment _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_ModelingInstanceLocks")]
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    protected new Environment _ModelingInstanceLocks;
    [Metadata("ActionRules is used to define expressions for Actions.", "ActionRule", false, false, true, "NamedObjectRef", 1052694, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_ActionRules")]
    protected Environment _ActionRules;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_SourcePages")]
    [Metadata("UI Source Page", "UISourcePage", false, false, true, "UISourcePage", 1052841, false, true, false, null)]
    protected UISourcePage_Environment _SourcePages;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_AssociatedPackages")]
    protected new Environment _AssociatedPackages;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_InstanceLocked")]
    protected new Environment _InstanceLocked;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_ChangeHistory")]
    protected new ChangeHistory_Environment _ChangeHistory;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1052687, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_IconId")]
    protected new Environment _IconId;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "ActionDef_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected new Environment _Notes;

    public Environment ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionType));
      }
    }

    public UIAction_Environment UIAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIAction), (object) value);
      }
      get
      {
        return (UIAction_Environment) this.PropertyGet(nameof (UIAction));
      }
    }

    public new Environment FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FilterTags));
      }
    }

    public new Environment ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public Environment ActionRules
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRules), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionRules));
      }
    }

    public UISourcePage_Environment SourcePages
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourcePages), (object) value);
      }
      get
      {
        return (UISourcePage_Environment) this.PropertyGet(nameof (SourcePages));
      }
    }

    public new Environment AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public new Environment InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new ChangeHistory_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory_Environment) this.PropertyGet(nameof (ChangeHistory));
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

    public new Environment IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IconId));
      }
    }

    public new Environment IsFrozen
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

    public new Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public new Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
