// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryView_Environment
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
  public class HistoryView_Environment : NamedDataObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_HistViewHistMainlineDtl")]
    [Metadata("User Interface (UI) Preference History Mainline Detail is used to store the fields that are related to a UI Preference instance for the History Mainline.  This UI Preference is used to store the fields to be displayed for the History Mainline section in the Live History.", "HistViewHistMainlineDtl", true, true, true, "HistViewHistMainlineDtl", 1050024, false, false, false, null)]
    protected HistViewHistMainlineDtl_Environment _HistViewHistMainlineDtl;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_HistViewDtls")]
    [Metadata("User Interface (UI) Preference Detail is used to store the fields that are related to a UI Preference instance.  An example is a UI Preference that is used to store the fields to be displayed for the \"current\" information about a Container in the Live History.", "HistViewDtl", true, false, true, "HistViewDtl", 1050023, false, true, false, null)]
    protected HistViewDtl_Environment _HistViewDtls;
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_FilterTags")]
    protected new Environment _FilterTags;
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_ModelingInstanceLocks")]
    protected new Environment _ModelingInstanceLocks;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_InstanceLocked")]
    protected new Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_AssociatedPackages")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    protected new Environment _AssociatedPackages;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_Description")]
    protected new Environment _Description;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_Notes")]
    protected new Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    protected new Environment _IconId;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050065, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_IsFrozen")]
    protected new Environment _IsFrozen;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "HistoryView_Environment_ChangeHistory")]
    protected new ChangeHistory_Environment _ChangeHistory;

    public HistViewHistMainlineDtl_Environment HistViewHistMainlineDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewHistMainlineDtl), (object) value);
      }
      get
      {
        return (HistViewHistMainlineDtl_Environment) this.PropertyGet(nameof (HistViewHistMainlineDtl));
      }
    }

    public HistViewDtl_Environment HistViewDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewDtls), (object) value);
      }
      get
      {
        return (HistViewDtl_Environment) this.PropertyGet(nameof (HistViewDtls));
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
  }
}
