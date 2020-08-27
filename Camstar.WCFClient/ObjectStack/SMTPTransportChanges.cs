// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SMTPTransportChanges
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
  public class SMTPTransportChanges : DataTransportChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_UserName")]
    protected new Primitive<string> _UserName;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_URL")]
    protected new Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Password")]
    protected new EncryptedField _Password;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Port")]
    protected Primitive<int> _Port;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_UseSSL")]
    protected Primitive<bool> _UseSSL;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_TransportType")]
    protected new Primitive<string> _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SMTPTransportChanges && object.Equals((object) this._UserName, (object) ((SMTPTransportChanges) obj)._UserName) && (object.Equals((object) this._ObjectToChange, (object) ((SMTPTransportChanges) obj)._ObjectToChange) && object.Equals((object) this._URL, (object) ((SMTPTransportChanges) obj)._URL)) && (object.Equals((object) this._Password, (object) ((SMTPTransportChanges) obj)._Password) && object.Equals((object) this._Port, (object) ((SMTPTransportChanges) obj)._Port) && (object.Equals((object) this._UseSSL, (object) ((SMTPTransportChanges) obj)._UseSSL) && object.Equals((object) this._TransportType, (object) ((SMTPTransportChanges) obj)._TransportType))) && object.Equals((object) this._Name, (object) ((SMTPTransportChanges) obj)._Name) && base.Equals(obj);
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

    public Primitive<bool> UseSSL
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseSSL), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UseSSL));
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
