// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystem
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
  public class TargetSystem : NamedDataObject
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_UserName")]
    protected Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_IPAddress")]
    protected Primitive<string> _IPAddress;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_ProcessingFolder")]
    protected Primitive<string> _ProcessingFolder;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_FolderLocation")]
    protected Primitive<string> _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Password")]
    protected PasswordFieldType _Password;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_DeliveryOption")]
    protected Enumeration<TargetSystemDeliveryOptionEnum, int> _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_IsNotACamstarServer")]
    protected Primitive<bool> _IsNotACamstarServer;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_IsSourceSystem")]
    protected Primitive<bool> _IsSourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Administrator")]
    protected Primitive<string> _Administrator;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_ServerType")]
    protected Primitive<string> _ServerType;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_ADDomain")]
    protected Primitive<string> _ADDomain;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_MDBVersion")]
    protected Primitive<string> _MDBVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Port")]
    protected Primitive<int> _Port;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_CamstarVersion")]
    protected Primitive<string> _CamstarVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Location")]
    protected Primitive<string> _Location;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystem_Notes")]
    protected new Primitive<string> _Notes;

    public override bool Equals(object obj)
    {
      return obj is TargetSystem && object.Equals((object) this._UserName, (object) ((TargetSystem) obj)._UserName) && (object.Equals((object) this._IPAddress, (object) ((TargetSystem) obj)._IPAddress) && object.Equals((object) this._ProcessingFolder, (object) ((TargetSystem) obj)._ProcessingFolder)) && (object.Equals((object) this._FolderLocation, (object) ((TargetSystem) obj)._FolderLocation) && object.Equals((object) this._Password, (object) ((TargetSystem) obj)._Password) && (object.Equals((object) this._DeliveryOption, (object) ((TargetSystem) obj)._DeliveryOption) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((TargetSystem) obj)._ModelingInstanceLocks))) && (object.Equals((object) this._FilterTags, (object) ((TargetSystem) obj)._FilterTags) && object.Equals((object) this._IsNotACamstarServer, (object) ((TargetSystem) obj)._IsNotACamstarServer) && (object.Equals((object) this._IsSourceSystem, (object) ((TargetSystem) obj)._IsSourceSystem) && object.Equals((object) this._Administrator, (object) ((TargetSystem) obj)._Administrator)) && (object.Equals((object) this._ServerType, (object) ((TargetSystem) obj)._ServerType) && object.Equals((object) this._InstanceLocked, (object) ((TargetSystem) obj)._InstanceLocked) && (object.Equals((object) this._ADDomain, (object) ((TargetSystem) obj)._ADDomain) && object.Equals((object) this._AssociatedPackages, (object) ((TargetSystem) obj)._AssociatedPackages)))) && (object.Equals((object) this._MDBVersion, (object) ((TargetSystem) obj)._MDBVersion) && object.Equals((object) this._Port, (object) ((TargetSystem) obj)._Port) && (object.Equals((object) this._CamstarVersion, (object) ((TargetSystem) obj)._CamstarVersion) && object.Equals((object) this._IconId, (object) ((TargetSystem) obj)._IconId)) && (object.Equals((object) this._ChangeHistory, (object) ((TargetSystem) obj)._ChangeHistory) && object.Equals((object) this._Location, (object) ((TargetSystem) obj)._Location) && (object.Equals((object) this._IsFrozen, (object) ((TargetSystem) obj)._IsFrozen) && object.Equals((object) this._Description, (object) ((TargetSystem) obj)._Description))) && (object.Equals((object) this._Name, (object) ((TargetSystem) obj)._Name) && object.Equals((object) this._Notes, (object) ((TargetSystem) obj)._Notes))) && base.Equals(obj);
    }

    public Primitive<string> UserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UserName));
      }
    }

    public Primitive<string> IPAddress
    {
      [param: In] set
      {
        this.PropertySet(nameof (IPAddress), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IPAddress));
      }
    }

    public Primitive<string> ProcessingFolder
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessingFolder), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProcessingFolder));
      }
    }

    public Primitive<string> FolderLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FolderLocation), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FolderLocation));
      }
    }

    public PasswordFieldType Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (PasswordFieldType) this.PropertyGet(nameof (Password));
      }
    }

    public Enumeration<TargetSystemDeliveryOptionEnum, int> DeliveryOption
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryOption), (object) value);
      }
      get
      {
        return (Enumeration<TargetSystemDeliveryOptionEnum, int>) this.PropertyGet(nameof (DeliveryOption));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public Primitive<bool> IsNotACamstarServer
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNotACamstarServer), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsNotACamstarServer));
      }
    }

    public Primitive<bool> IsSourceSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSourceSystem), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsSourceSystem));
      }
    }

    public Primitive<string> Administrator
    {
      [param: In] set
      {
        this.PropertySet(nameof (Administrator), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Administrator));
      }
    }

    public Primitive<string> ServerType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServerType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServerType));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public Primitive<string> ADDomain
    {
      [param: In] set
      {
        this.PropertySet(nameof (ADDomain), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ADDomain));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public Primitive<string> MDBVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (MDBVersion), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MDBVersion));
      }
    }

    public Primitive<int> Port
    {
      [param: In] set
      {
        this.PropertySet(nameof (Port), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Port));
      }
    }

    public Primitive<string> CamstarVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (CamstarVersion), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CamstarVersion));
      }
    }

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Primitive<string> Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Location));
      }
    }

    public new Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public new Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
