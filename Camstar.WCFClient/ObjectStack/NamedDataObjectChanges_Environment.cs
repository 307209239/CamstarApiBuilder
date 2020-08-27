// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObjectChanges_Environment
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
  public class NamedDataObjectChanges_Environment : BaseObject_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [Metadata("The details used to display the attached documents.", "AttachDocumentDetails", false, false, true, "AttachDocumentDetails", 16777527, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_AttachDocumentDetails")]
    protected AttachDocumentDetails_Environment _AttachDocumentDetails;
    [Metadata("FilterTags", "", false, false, false, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_FilterTags")]
    protected Environment _FilterTags;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 16777948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_AssociatedPackages")]
    protected Environment _AssociatedPackages;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777533, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_UseRORProxy")]
    protected Environment _UseRORProxy;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777528, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_IsContainer")]
    protected Environment _IsContainer;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_AttachAsRORProxy")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777531, false, true, false, "0")]
    protected Environment _AttachAsRORProxy;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777532, false, true, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_UseROR")]
    protected Environment _UseROR;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777529, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_IsNDO")]
    protected Environment _IsNDO;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777984, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_InstanceLocked")]
    protected Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_IsRDO")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777530, false, false, false, "0")]
    protected Environment _IsRDO;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_ObjectToChange")]
    [Metadata("Factory modeling objects that can be uniquely identified by name.", "NamedDataObject", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_IconId")]
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, false, "Integer", 1048679, false, false, false, null)]
    protected Environment _IconId;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050131, false, false, false, null)]
    protected Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public Environment UseRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseRORProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseRORProxy));
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

    public Environment AttachAsRORProxy
    {
      [param: In] set
      {
        this.PropertySet(nameof (AttachAsRORProxy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AttachAsRORProxy));
      }
    }

    public Environment UseROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseROR), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseROR));
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
  }
}
