// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UIProviderComponent_Environment
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
  public class UIProviderComponent_Environment : NamedDataObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_ModelingInstanceLocks")]
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    protected new Environment _ModelingInstanceLocks;
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_FilterTags")]
    protected new Environment _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_InstanceLocked")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 0, false, false, false, "0")]
    protected new Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_AssociatedPackages")]
    [Metadata("Generic Integer", "", false, false, true, "Integer", 0, false, false, false, null)]
    protected new Environment _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_CreatedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052351, false, false, false, null)]
    protected Environment _CreatedBy;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050052, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    protected new Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_ChangeHistory")]
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    protected new ChangeHistory_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "UIProviderComponent_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected new Environment _Notes;

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

    public Environment CreatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (CreatedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CreatedBy));
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
