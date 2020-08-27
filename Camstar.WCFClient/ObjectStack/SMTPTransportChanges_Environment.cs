// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SMTPTransportChanges_Environment
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
  public class SMTPTransportChanges_Environment : DataTransportChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_UserName")]
    [Metadata("User Name", "", false, false, false, "String", 1049444, false, false, false, null)]
    protected new Environment _UserName;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_ObjectToChange")]
    [Metadata("SMTP Transport", "SMTPTransport", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("URL", "", false, false, false, "String", 1049620, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_URL")]
    protected new Environment _URL;
    [Metadata("Password", "", false, false, false, "EncryptedField", 1048862, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_Password")]
    protected new Environment _Password;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1053192, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_Port")]
    protected Environment _Port;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_UseSSL")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051168, false, false, false, "0")]
    protected Environment _UseSSL;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1049892, false, false, false, "SMTP")]
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_TransportType")]
    protected new Environment _TransportType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050059, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Environment_Name")]
    protected new Environment _Name;

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

    public Environment UseSSL
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseSSL), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UseSSL));
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
