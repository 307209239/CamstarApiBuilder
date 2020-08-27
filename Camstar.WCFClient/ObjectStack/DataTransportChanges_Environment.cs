// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataTransportChanges_Environment
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
  public class DataTransportChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Password", "", false, true, false, "EncryptedField", 1048862, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_Password")]
    protected Environment _Password;
    [Metadata("URL", "", false, false, false, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_URL")]
    protected Environment _URL;
    [Metadata("Describes the transport mechanism by which to send the outbound XML document", "DataTransport", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_UserName")]
    [Metadata("User Name", "", false, true, false, "String", 1049444, false, false, false, null)]
    protected Environment _UserName;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_TransportAssembly")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049996, false, false, false, null)]
    protected Environment _TransportAssembly;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049995, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_IsSynchronous")]
    protected Environment _IsSynchronous;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049999, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_OkToTerminateIfFails")]
    protected Environment _OkToTerminateIfFails;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050056, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049892, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Environment_TransportType")]
    protected Environment _TransportType;

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

    public Environment URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (URL));
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

    public Environment TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public Environment IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public Environment OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OkToTerminateIfFails));
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

    public Environment TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransportType));
      }
    }
  }
}
