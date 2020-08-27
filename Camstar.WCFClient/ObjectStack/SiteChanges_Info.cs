// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SiteChanges_Info
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
  public class SiteChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_EMailTransport")]
    protected Info _EMailTransport;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_DefaultDataTransport")]
    protected Info _DefaultDataTransport;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_URL")]
    protected Info _URL;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_Password")]
    protected Info _Password;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_User")]
    protected Info _User;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Info_Name")]
    protected new Info _Name;

    public Info EMailTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailTransport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EMailTransport));
      }
    }

    public Info DefaultDataTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultDataTransport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DefaultDataTransport));
      }
    }

    public Info URL
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

    public Info User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (User));
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
