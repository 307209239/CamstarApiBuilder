// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystem_Info
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
  public class TargetSystem_Info : NamedDataObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_UserName")]
    protected Info _UserName;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_IPAddress")]
    protected Info _IPAddress;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_ProcessingFolder")]
    protected Info _ProcessingFolder;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_FolderLocation")]
    protected Info _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Password")]
    protected Info _Password;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_DeliveryOption")]
    protected Info _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_ModelingInstanceLocks")]
    protected new Info _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_FilterTags")]
    protected new Info _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_IsNotACamstarServer")]
    protected Info _IsNotACamstarServer;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_IsSourceSystem")]
    protected Info _IsSourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Administrator")]
    protected Info _Administrator;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_ServerType")]
    protected Info _ServerType;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_InstanceLocked")]
    protected new Info _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_ADDomain")]
    protected Info _ADDomain;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_AssociatedPackages")]
    protected new Info _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_MDBVersion")]
    protected Info _MDBVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Port")]
    protected Info _Port;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_CamstarVersion")]
    protected Info _CamstarVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_IconId")]
    protected new Info _IconId;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_ChangeHistory")]
    protected new ChangeHistory_Info _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_IsFrozen")]
    protected new Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Description")]
    protected new Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Info_Notes")]
    protected new Info _Notes;

    public Info UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserName));
      }
    }

    public Info IPAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (IPAddress), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IPAddress));
      }
    }

    public Info ProcessingFolder
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessingFolder), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessingFolder));
      }
    }

    public Info FolderLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FolderLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FolderLocation));
      }
    }

    public Info Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Password));
      }
    }

    public Info DeliveryOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryOption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeliveryOption));
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

    public Info IsNotACamstarServer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNotACamstarServer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsNotACamstarServer));
      }
    }

    public Info IsSourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSourceSystem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSourceSystem));
      }
    }

    public Info Administrator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Administrator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Administrator));
      }
    }

    public Info ServerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServerType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServerType));
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

    public Info ADDomain
    {
      [param: In] set
      {
        this.PropertySet(nameof (ADDomain), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ADDomain));
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

    public Info MDBVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (MDBVersion), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MDBVersion));
      }
    }

    public Info Port
    {
      [param: In] set
      {
        this.PropertySet(nameof (Port), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Port));
      }
    }

    public Info CamstarVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (CamstarVersion), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CamstarVersion));
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

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
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
