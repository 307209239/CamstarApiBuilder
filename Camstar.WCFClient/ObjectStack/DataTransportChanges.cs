// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DataTransportChanges
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
  public class DataTransportChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Password")]
    protected EncryptedField _Password;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_URL")]
    protected Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_UserName")]
    protected Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_TransportAssembly")]
    protected Primitive<string> _TransportAssembly;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_IsSynchronous")]
    protected Primitive<bool> _IsSynchronous;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_OkToTerminateIfFails")]
    protected Primitive<bool> _OkToTerminateIfFails;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "DataTransportChanges_TransportType")]
    protected Primitive<string> _TransportType;

    public override bool Equals(object obj)
    {
      return obj is DataTransportChanges && object.Equals((object) this._Password, (object) ((DataTransportChanges) obj)._Password) && (object.Equals((object) this._URL, (object) ((DataTransportChanges) obj)._URL) && object.Equals((object) this._ObjectToChange, (object) ((DataTransportChanges) obj)._ObjectToChange)) && (object.Equals((object) this._UserName, (object) ((DataTransportChanges) obj)._UserName) && object.Equals((object) this._TransportAssembly, (object) ((DataTransportChanges) obj)._TransportAssembly) && (object.Equals((object) this._IsSynchronous, (object) ((DataTransportChanges) obj)._IsSynchronous) && object.Equals((object) this._OkToTerminateIfFails, (object) ((DataTransportChanges) obj)._OkToTerminateIfFails))) && (object.Equals((object) this._Name, (object) ((DataTransportChanges) obj)._Name) && object.Equals((object) this._TransportType, (object) ((DataTransportChanges) obj)._TransportType)) && base.Equals(obj);
    }

    public EncryptedField Password
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

    public Primitive<string> URL
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

    public Primitive<string> TransportAssembly
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

    public Primitive<bool> IsSynchronous
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

    public Primitive<bool> OkToTerminateIfFails
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

    public Primitive<string> TransportType
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
  }
}
