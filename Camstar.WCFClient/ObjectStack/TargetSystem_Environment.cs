// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystem_Environment
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
  public class TargetSystem_Environment : NamedDataObject_Environment
  {
    [Metadata("User Name", "", false, false, true, "String", 1049444, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_UserName")]
    protected Environment _UserName;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_IPAddress")]
    [Metadata("URL", "", false, false, true, "String", 1053189, false, false, false, null)]
    protected Environment _IPAddress;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_ProcessingFolder")]
    [Metadata("URL", "", false, false, true, "String", 16778703, false, false, false, null)]
    protected Environment _ProcessingFolder;
    [Metadata("URL", "", false, false, true, "String", 1053220, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_FolderLocation")]
    protected Environment _FolderLocation;
    [Metadata("Password", "", false, false, true, "PasswordFieldType", 1048862, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Password")]
    protected Environment _Password;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_DeliveryOption")]
    [Metadata("TargetSystemDeliveryOption", "TargetSystemDeliveryOptionEnum", false, false, true, "Integer", 1053222, false, false, false, "Transaction::__Const.TargetSystemDeliveryOption.None")]
    protected Environment _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_ModelingInstanceLocks")]
    [Metadata("A listing of a change package where modeling instance is assigned.", "ModelingInstanceLock", false, false, true, "SubentityRef", 16777683, false, true, false, null)]
    protected new Environment _ModelingInstanceLocks;
    [Metadata("FilterTags", "", false, false, true, "String", 16778956, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_FilterTags")]
    protected new Environment _FilterTags;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16778697, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_IsNotACamstarServer")]
    protected Environment _IsNotACamstarServer;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_IsSourceSystem")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1053190, false, false, false, "0")]
    protected Environment _IsSourceSystem;
    [Metadata("Generic String", "", false, false, true, "String", 1053187, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Administrator")]
    protected Environment _Administrator;
    [Metadata("Generic String", "", false, false, true, "String", 1053193, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_ServerType")]
    protected Environment _ServerType;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_InstanceLocked")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 16777984, false, false, false, "0")]
    protected new Environment _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_ADDomain")]
    [Metadata("Generic String", "", false, false, true, "String", 16777600, false, false, false, null)]
    protected Environment _ADDomain;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 16777948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_AssociatedPackages")]
    protected new Environment _AssociatedPackages;
    [Metadata("Generic String", "", false, false, true, "String", 1053191, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_MDBVersion")]
    protected Environment _MDBVersion;
    [Metadata("Generic Integer", "", false, false, true, "Integer", 1053192, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Port")]
    protected Environment _Port;
    [Metadata("Generic String", "", false, false, true, "String", 1053188, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_CamstarVersion")]
    protected Environment _CamstarVersion;
    [Metadata("Unique identifier for an Icon. Most instances of data have an associated Icon. This is the ID used to uniquely identify the Icon within the Icon library.", "", false, false, true, "Integer", 1048679, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_IconId")]
    protected new Environment _IconId;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, true, "ChangeHistory", 1048765, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_ChangeHistory")]
    protected new ChangeHistory_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Location")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048660, false, false, false, null)]
    protected Environment _Location;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected new Environment _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048678, false, false, false, null)]
    protected new Environment _Description;
    [Metadata("Unique name for this instance", "", false, false, true, "String", 1053194, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Name")]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected new Environment _Notes;

    public Environment UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserName));
      }
    }

    public Environment IPAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (IPAddress), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IPAddress));
      }
    }

    public Environment ProcessingFolder
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessingFolder), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ProcessingFolder));
      }
    }

    public Environment FolderLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FolderLocation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FolderLocation));
      }
    }

    public Environment Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Password));
      }
    }

    public Environment DeliveryOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryOption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeliveryOption));
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

    public Environment IsNotACamstarServer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNotACamstarServer), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsNotACamstarServer));
      }
    }

    public Environment IsSourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSourceSystem), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsSourceSystem));
      }
    }

    public Environment Administrator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Administrator), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Administrator));
      }
    }

    public Environment ServerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServerType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServerType));
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

    public Environment ADDomain
    {
      [param: In] set
      {
        this.PropertySet(nameof (ADDomain), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ADDomain));
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

    public Environment MDBVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (MDBVersion), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MDBVersion));
      }
    }

    public Environment Port
    {
      [param: In] set
      {
        this.PropertySet(nameof (Port), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Port));
      }
    }

    public Environment CamstarVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (CamstarVersion), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CamstarVersion));
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

    public Environment Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Location));
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
