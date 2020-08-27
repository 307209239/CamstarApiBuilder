// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemChanges
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
  public class TargetSystemChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_UserName")]
    protected Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_ProcessingFolder")]
    protected Primitive<string> _ProcessingFolder;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Password")]
    protected PasswordFieldType _Password;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_FolderLocation")]
    protected Primitive<string> _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_IPAddress")]
    protected Primitive<string> _IPAddress;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_DeliveryOption")]
    protected Enumeration<TargetSystemDeliveryOptionEnum, int> _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_ADDomain")]
    protected Primitive<string> _ADDomain;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_ServerType")]
    protected Primitive<string> _ServerType;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_CamstarVersion")]
    protected Primitive<string> _CamstarVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_MDBVersion")]
    protected Primitive<string> _MDBVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Port")]
    protected Primitive<int> _Port;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_IsSourceSystem")]
    protected Primitive<bool> _IsSourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Administrator")]
    protected Primitive<string> _Administrator;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_IsNotACamstarServer")]
    protected Primitive<bool> _IsNotACamstarServer;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Location")]
    protected Primitive<string> _Location;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TargetSystemChanges && object.Equals((object) this._UserName, (object) ((TargetSystemChanges) obj)._UserName) && (object.Equals((object) this._ProcessingFolder, (object) ((TargetSystemChanges) obj)._ProcessingFolder) && object.Equals((object) this._Password, (object) ((TargetSystemChanges) obj)._Password)) && (object.Equals((object) this._FolderLocation, (object) ((TargetSystemChanges) obj)._FolderLocation) && object.Equals((object) this._IPAddress, (object) ((TargetSystemChanges) obj)._IPAddress) && (object.Equals((object) this._ObjectToChange, (object) ((TargetSystemChanges) obj)._ObjectToChange) && object.Equals((object) this._DeliveryOption, (object) ((TargetSystemChanges) obj)._DeliveryOption))) && (object.Equals((object) this._ADDomain, (object) ((TargetSystemChanges) obj)._ADDomain) && object.Equals((object) this._ServerType, (object) ((TargetSystemChanges) obj)._ServerType) && (object.Equals((object) this._CamstarVersion, (object) ((TargetSystemChanges) obj)._CamstarVersion) && object.Equals((object) this._MDBVersion, (object) ((TargetSystemChanges) obj)._MDBVersion)) && (object.Equals((object) this._Port, (object) ((TargetSystemChanges) obj)._Port) && object.Equals((object) this._IsSourceSystem, (object) ((TargetSystemChanges) obj)._IsSourceSystem) && (object.Equals((object) this._Administrator, (object) ((TargetSystemChanges) obj)._Administrator) && object.Equals((object) this._IsNotACamstarServer, (object) ((TargetSystemChanges) obj)._IsNotACamstarServer)))) && (object.Equals((object) this._Location, (object) ((TargetSystemChanges) obj)._Location) && object.Equals((object) this._Name, (object) ((TargetSystemChanges) obj)._Name)) && base.Equals(obj);
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

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
