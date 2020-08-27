// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectChanges_Environment
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
  public class RevisionedObjectChanges_Environment : BaseObject_Environment
  {
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_FilterTags")]
    [Metadata("FilterTags", "", false, false, false, "String", 16778956, false, false, false, null)]
    protected Environment _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_AttachDocumentDetails")]
    [Metadata("The details used to display the attached documents.", "AttachDocumentDetails", false, false, true, "AttachDocumentDetails", 16777527, false, true, false, null)]
    protected AttachDocumentDetails_Environment _AttachDocumentDetails;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_ECO")]
    [Metadata("Generic String", "", false, false, false, "String", 1050862, false, false, false, null)]
    protected Environment _ECO;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777984, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_InstanceLocked")]
    protected Environment _InstanceLocked;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777528, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_IsContainer")]
    protected Environment _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_IsNDO")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777529, false, false, false, "0")]
    protected Environment _IsNDO;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_Base")]
    [Metadata("RevisionBase refers to attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.  The RevisionBase holds information common to all revisions of an object, plus information on which revision is the revision of record.", "RevisionBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_AssociatedPackages")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777948, false, false, false, null)]
    protected Environment _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_IsRDO")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777530, false, false, false, "1")]
    protected Environment _IsRDO;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049316, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_CanChangeRevOfRcd")]
    protected Environment _CanChangeRevOfRcd;
    [Metadata("Attributes that are common to all CDOs that include revision control (for instances). There are two CDO Definitions for each; a Base Entity and a Revision Entity.", "RevisionedObject", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_ObjectToChange")]
    protected Environment _ObjectToChange;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_Notes")]
    protected Environment _Notes;
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_IsRevOfRcd")]
    protected Environment _IsRevOfRcd;
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_Description")]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Revision (unique within the context of the base entity)", "", false, true, false, "String", 1048710, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_Revision")]
    protected Environment _Revision;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, false, "Integer", 1048679, false, false, false, null)]
    protected Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050234, false, false, false, null)]
    protected Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectChanges_Environment_Status")]
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, true, "1")]
    protected Environment _Status;

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
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

    public AttachDocumentDetails_Environment AttachDocumentDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachDocumentDetails), (object) value);
      }
      get
      {
        return (AttachDocumentDetails_Environment) this.PropertyGet(nameof (AttachDocumentDetails));
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

    public Environment IsContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsContainer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsContainer));
      }
    }

    public Environment IsNDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsNDO));
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

    public Environment IsRDO
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRDO), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRDO));
      }
    }

    public Environment CanChangeRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (CanChangeRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CanChangeRevOfRcd));
      }
    }

    public Environment ObjectToChange
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
  }
}
