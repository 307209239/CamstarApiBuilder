// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FTPTransportChanges_Info
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
  public class FTPTransportChanges_Info : DataTransportChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_UserName")]
    protected new Info _UserName;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_URL")]
    protected new Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_RemoteFileName")]
    protected Info _RemoteFileName;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_TransferType")]
    protected Info _TransferType;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_Password")]
    protected new Info _Password;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_RemotePath")]
    protected Info _RemotePath;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_TransportAssembly")]
    protected new Info _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_ConnectionTimeout")]
    protected Info _ConnectionTimeout;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_ByteOrderMark")]
    protected Info _ByteOrderMark;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_DeliveryTimeout")]
    protected Info _DeliveryTimeout;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_IsSynchronous")]
    protected new Info _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_OkToTerminateIfFails")]
    protected new Info _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_TransportType")]
    protected new Info _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "FTPTransportChanges_Info_Name")]
    protected new Info _Name;

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

    public new Info UserName
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

    public new Info URL
    {
      [param: In] set
      {
        this.PropertySet(nameof (URL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (URL));
      }
    }

    public Info RemoteFileName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemoteFileName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemoteFileName));
      }
    }

    public Info TransferType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransferType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransferType));
      }
    }

    public new Info Password
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

    public Info RemotePath
    {
      [param: In] set
      {
        this.PropertySet(nameof (RemotePath), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RemotePath));
      }
    }

    public new Info TransportAssembly
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportAssembly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransportAssembly));
      }
    }

    public Info ConnectionTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (ConnectionTimeout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ConnectionTimeout));
      }
    }

    public Info ByteOrderMark
    {
      [param: In] set
      {
        this.PropertySet(nameof (ByteOrderMark), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ByteOrderMark));
      }
    }

    public Info DeliveryTimeout
    {
      [param: In] set
      {
        this.PropertySet(nameof (DeliveryTimeout), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DeliveryTimeout));
      }
    }

    public new Info IsSynchronous
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsSynchronous), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsSynchronous));
      }
    }

    public new Info OkToTerminateIfFails
    {
      [param: In] set
      {
        this.PropertySet(nameof (OkToTerminateIfFails), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OkToTerminateIfFails));
      }
    }

    public new Info TransportType
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransportType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransportType));
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
