// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FTPTransportChanges_Environment
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
  public class FTPTransportChanges_Environment : DataTransportChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_ObjectToChange")]
    [Metadata("FTP Transport", "FTPTransport", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_UserName")]
    [Metadata("User Name", "", false, false, false, "String", 1049444, false, false, false, "anonymous")]
    protected new Environment _UserName;
    [Metadata("URL", "", false, false, false, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_URL")]
    protected new Environment _URL;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_RemoteFileName")]
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1050003, false, false, false, "InSiteXMLDoc<__txnId/><__docId/>.xml")]
    protected Environment _RemoteFileName;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_TransferType")]
    [Metadata("FTP Transfer Type. Enumerators: Binary, ASCII", "FTPTransferTypeEnum", false, false, false, "String", 1050007, false, false, true, "Binary")]
    protected Environment _TransferType;
    [Metadata("Password", "", false, false, false, "EncryptedField", 1048862, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_Password")]
    protected new Environment _Password;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_RemotePath")]
    [Metadata("File directory path", "", false, false, false, "String", 1050002, false, false, false, "/")]
    protected Environment _RemotePath;
    [Metadata("FileName - used for fields that specify files.", "", false, false, false, "String", 1049996, false, false, false, "Camstar.XMLConnect.Transport.FTP.dll")]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_TransportAssembly")]
    protected new Environment _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_ConnectionTimeout")]
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050415, false, false, false, "0")]
    protected Environment _ConnectionTimeout;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1050004, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_ByteOrderMark")]
    protected Environment _ByteOrderMark;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050416, false, false, false, "10")]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_DeliveryTimeout")]
    protected Environment _DeliveryTimeout;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049995, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_IsSynchronous")]
    protected new Environment _IsSynchronous;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049999, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_OkToTerminateIfFails")]
    protected new Environment _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_TransportType")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049892, false, false, false, "FTP")]
    protected new Environment _TransportType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050057, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment UserName
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

    public new Environment URL
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

    public Environment RemoteFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteFileName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemoteFileName));
      }
    }

    public Environment TransferType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransferType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransferType));
      }
    }

    public new Environment Password
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

    public Environment RemotePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemotePath), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RemotePath));
      }
    }

    public new Environment TransportAssembly
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

    public Environment ConnectionTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConnectionTimeout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ConnectionTimeout));
      }
    }

    public Environment ByteOrderMark
    {
      [param: In] set
      {
        this.PropertySet(nameof (ByteOrderMark), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ByteOrderMark));
      }
    }

    public Environment DeliveryTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryTimeout), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DeliveryTimeout));
      }
    }

    public new Environment IsSynchronous
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

    public new Environment OkToTerminateIfFails
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

    public new Environment TransportType
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
