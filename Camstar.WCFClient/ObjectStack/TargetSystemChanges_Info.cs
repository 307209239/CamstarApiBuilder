// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemChanges_Info
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
  public class TargetSystemChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_UserName")]
    protected Info _UserName;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_ProcessingFolder")]
    protected Info _ProcessingFolder;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_Password")]
    protected Info _Password;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_FolderLocation")]
    protected Info _FolderLocation;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_IPAddress")]
    protected Info _IPAddress;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_DeliveryOption")]
    protected Info _DeliveryOption;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_ADDomain")]
    protected Info _ADDomain;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_ServerType")]
    protected Info _ServerType;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_CamstarVersion")]
    protected Info _CamstarVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_MDBVersion")]
    protected Info _MDBVersion;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_Port")]
    protected Info _Port;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_IsSourceSystem")]
    protected Info _IsSourceSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_Administrator")]
    protected Info _Administrator;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_IsNotACamstarServer")]
    protected Info _IsNotACamstarServer;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_Location")]
    protected Info _Location;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemChanges_Info_Name")]
    protected new Info _Name;

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

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
