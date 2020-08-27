// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SMTPTransportChanges_Info
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
  public class SMTPTransportChanges_Info : DataTransportChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_UserName")]
    protected new Info _UserName;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_URL")]
    protected new Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_Password")]
    protected new Info _Password;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_Port")]
    protected Info _Port;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_UseSSL")]
    protected Info _UseSSL;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_TransportType")]
    protected new Info _TransportType;
    [DataMember(EmitDefaultValue = false, Name = "SMTPTransportChanges_Info_Name")]
    protected new Info _Name;

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

    public Info UseSSL
    {
      [param: In] set
      {
        this.PropertySet(nameof (UseSSL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UseSSL));
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
