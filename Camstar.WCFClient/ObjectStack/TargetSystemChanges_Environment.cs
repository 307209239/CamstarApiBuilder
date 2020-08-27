// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemChanges_Environment
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
  public class TargetSystemChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_UserName")]
    [Metadata("User Name", "", false, true, false, "String", 1049444, false, false, false, null)]
    protected Environment _UserName;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_ProcessingFolder")]
    [Metadata("URL", "", false, false, false, "String", 16778703, false, false, false, null)]
    protected Environment _ProcessingFolder;
    [Metadata("Password", "", false, false, false, "PasswordFieldType", 1048862, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_Password")]
    protected Environment _Password;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_FolderLocation")]
    [Metadata("URL", "", false, false, false, "String", 1053220, false, false, false, null)]
    protected Environment _FolderLocation;
    [Metadata("URL", "", false, true, false, "String", 1053189, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_IPAddress")]
    protected Environment _IPAddress;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_ObjectToChange")]
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_DeliveryOption")]
    [Metadata("TargetSystemDeliveryOption", "TargetSystemDeliveryOptionEnum", false, false, false, "Integer", 1053222, false, false, true, null)]
    protected Environment _DeliveryOption;
    [Metadata("Generic String", "", false, false, false, "String", 16777600, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_ADDomain")]
    protected Environment _ADDomain;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_ServerType")]
    [Metadata("Generic String", "", false, false, false, "String", 1053193, false, false, false, null)]
    protected Environment _ServerType;
    [Metadata("Generic String", "", false, true, false, "String", 1053188, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_CamstarVersion")]
    protected Environment _CamstarVersion;
    [Metadata("Generic String", "", false, true, false, "String", 1053191, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_MDBVersion")]
    protected Environment _MDBVersion;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053192, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_Port")]
    protected Environment _Port;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_IsSourceSystem")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1053190, false, false, false, "0")]
    protected Environment _IsSourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_Administrator")]
    [Metadata("Generic String", "", false, false, false, "String", 1053187, false, false, false, null)]
    protected Environment _Administrator;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_IsNotACamstarServer")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778697, false, false, false, "0")]
    protected Environment _IsNotACamstarServer;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_Location")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048660, false, false, false, null)]
    protected Environment _Location;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053194, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment ObjectToChange
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
  }
}
