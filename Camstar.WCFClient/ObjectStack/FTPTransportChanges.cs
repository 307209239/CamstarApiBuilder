// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FTPTransportChanges
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
  public class FTPTransportChanges : DataTransportChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_UserName")]
    protected new Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_URL")]
    protected new Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_RemoteFileName")]
    protected Primitive<string> _RemoteFileName;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_TransferType")]
    protected Enumeration<FTPTransferTypeEnum, string> _TransferType;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Password")]
    protected new EncryptedField _Password;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_RemotePath")]
    protected Primitive<string> _RemotePath;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_TransportAssembly")]
    protected new Primitive<string> _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_ConnectionTimeout")]
    protected Primitive<int> _ConnectionTimeout;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_ByteOrderMark")]
    protected Primitive<bool> _ByteOrderMark;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_DeliveryTimeout")]
    protected Primitive<int> _DeliveryTimeout;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_IsSynchronous")]
    protected new Primitive<bool> _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_OkToTerminateIfFails")]
    protected new Primitive<bool> _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_TransportType")]
    protected new Primitive<string> _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is FTPTransportChanges && object.Equals((object) this._ObjectToChange, (object) ((FTPTransportChanges) obj)._ObjectToChange) && (object.Equals((object) this._UserName, (object) ((FTPTransportChanges) obj)._UserName) && object.Equals((object) this._URL, (object) ((FTPTransportChanges) obj)._URL)) && (object.Equals((object) this._RemoteFileName, (object) ((FTPTransportChanges) obj)._RemoteFileName) && object.Equals((object) this._TransferType, (object) ((FTPTransportChanges) obj)._TransferType) && (object.Equals((object) this._Password, (object) ((FTPTransportChanges) obj)._Password) && object.Equals((object) this._RemotePath, (object) ((FTPTransportChanges) obj)._RemotePath))) && (object.Equals((object) this._TransportAssembly, (object) ((FTPTransportChanges) obj)._TransportAssembly) && object.Equals((object) this._ConnectionTimeout, (object) ((FTPTransportChanges) obj)._ConnectionTimeout) && (object.Equals((object) this._ByteOrderMark, (object) ((FTPTransportChanges) obj)._ByteOrderMark) && object.Equals((object) this._DeliveryTimeout, (object) ((FTPTransportChanges) obj)._DeliveryTimeout)) && (object.Equals((object) this._IsSynchronous, (object) ((FTPTransportChanges) obj)._IsSynchronous) && object.Equals((object) this._OkToTerminateIfFails, (object) ((FTPTransportChanges) obj)._OkToTerminateIfFails) && (object.Equals((object) this._TransportType, (object) ((FTPTransportChanges) obj)._TransportType) && object.Equals((object) this._Name, (object) ((FTPTransportChanges) obj)._Name)))) && base.Equals(obj);
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

    public new Primitive<string> UserName
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

    public new Primitive<string> URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (URL));
      }
    }

    public Primitive<string> RemoteFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteFileName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RemoteFileName));
      }
    }

    public Enumeration<FTPTransferTypeEnum, string> TransferType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransferType), (object) value);
      }
      get
      {
        return (Enumeration<FTPTransferTypeEnum, string>) this.PropertyGet(nameof (TransferType));
      }
    }

    public new EncryptedField Password
    {
      [param: In] set
      {
        this.PropertySet(nameof (Password), (object) value);
      }
      get
      {
        return (EncryptedField) this.PropertyGet(nameof (Password));
      }
    }

    public Primitive<string> RemotePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemotePath), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RemotePath));
      }
    }

    public new Primitive<string> TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public Primitive<int> ConnectionTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConnectionTimeout), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ConnectionTimeout));
      }
    }

    public Primitive<bool> ByteOrderMark
    {
      [param: In] set
      {
        this.PropertySet(nameof (ByteOrderMark), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ByteOrderMark));
      }
    }

    public Primitive<int> DeliveryTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryTimeout), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DeliveryTimeout));
      }
    }

    public new Primitive<bool> IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public new Primitive<bool> OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OkToTerminateIfFails));
      }
    }

    public new Primitive<string> TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TransportType));
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
