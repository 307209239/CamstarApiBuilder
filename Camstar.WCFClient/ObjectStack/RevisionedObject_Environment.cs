// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObject_Environment
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
  public class RevisionedObject_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_WhereUsed")]
    [Metadata("A list of this type is returned by the Where-used functionality of a maintenance service.  An instance of this CDO will specify one of the objects using the object to change.  The fields in this CDO are used to populate a tree view displayed while maintaining a modeling object.", "WhereUsed", false, false, true, "SubentityRef", 1049803, false, true, false, null)]
    protected Environment _WhereUsed;
    [Metadata("DisplayName", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_DisplayName")]
    protected Environment _DisplayName;
    [Metadata("This subentity will maintain the data for the esignatures associated with the last update to its parent object.", "ModelingESigHistoryDetail", false, false, true, "ModelingESigHistoryDetail", 1050926, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_ESigHistoryDetails")]
    protected ModelingESigHistoryDetail_Environment _ESigHistoryDetails;
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_ModelingInstanceLocks")]
    protected Environment _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_FilterTags")]
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    protected Environment _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_InstanceLocked")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    protected Environment _InstanceLocked;
    [Metadata("RevisionBase refers to attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.  The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.", "RevisionBase", false, false, true, "RevisionedObjectRef", 1048857, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_Base")]
    protected Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_ECO")]
    [Metadata("Generic String", "", false, false, true, "String", 1050862, false, false, false, null)]
    protected Environment _ECO;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_AssociatedPackages")]
    protected Environment _AssociatedPackages;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, true, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_Status")]
    protected Environment _Status;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_ChangeHistory")]
    protected ChangeHistory_Environment _ChangeHistory;
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, true, "Boolean", 1048858, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_IsRevOfRcd")]
    protected Environment _IsRevOfRcd;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1050223, false, false, false, null)]
    protected Environment _Name;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_IconId")]
    protected Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_Revision")]
    [Metadata("Revision (unique within the context of the base entity)", "", false, false, true, "String", 1048710, false, false, false, null)]
    protected Environment _Revision;
    [Metadata("Attached to an instance of a modeling entity, this contains the messages that apply to the entity.  When asked to supply its WIP Messages, a modeling entity will ask its WIPMsgDefMgr to supply a list of WIP Messages that have been filtered to include only the messages that apply to the current circumstances (step, operation and label).\r\nThe WIPMsgDefMgr will check the AllKey WIPMsgKey (which contains a message that applies to all steps) if specified, and run through the entries in the OperationKeys and LabelKeys lists and filter each message found.", "WIPMsgDefMgr", false, false, true, "WIPMsgDefMgr", 1048768, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObject_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgr_Environment _WIPMsgDefMgr;

    public Environment WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public Environment DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayName));
      }
    }

    public ModelingESigHistoryDetail_Environment ESigHistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigHistoryDetails), (object) value);
      }
      get
      {
        return (ModelingESigHistoryDetail_Environment) this.PropertyGet(nameof (ESigHistoryDetails));
      }
    }

    public Environment ModelingInstanceLocks
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

    public Environment FilterTags
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

    public Environment InstanceLocked
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

    public Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
      }
    }

    public Environment ECO
    {
      [param: In] set
      {
        this.PropertySet(nameof (ECO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ECO));
      }
    }

    public Environment AssociatedPackages
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

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public ChangeHistory_Environment ChangeHistory
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

    public Environment Notes
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

    public Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }

    public Environment Description
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

    public Environment Name
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

    public Environment IconId
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

    public Environment Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Revision));
      }
    }

    public WIPMsgDefMgr_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgr_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }
  }
}
