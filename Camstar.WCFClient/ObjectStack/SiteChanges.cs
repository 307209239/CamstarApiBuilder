// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SiteChanges
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
  public class SiteChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_EMailTransport")]
    protected NamedObjectRef _EMailTransport;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_DefaultDataTransport")]
    protected NamedObjectRef _DefaultDataTransport;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_URL")]
    protected Primitive<string> _URL;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Password")]
    protected EncryptedField _Password;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_User")]
    protected NamedObjectRef _User;
    [DataMember(EmitDefaultValue = false, Name = "SiteChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is SiteChanges && object.Equals((object) this._EMailTransport, (object) ((SiteChanges) obj)._EMailTransport) && (object.Equals((object) this._DefaultDataTransport, (object) ((SiteChanges) obj)._DefaultDataTransport) && object.Equals((object) this._URL, (object) ((SiteChanges) obj)._URL)) && (object.Equals((object) this._Password, (object) ((SiteChanges) obj)._Password) && object.Equals((object) this._ObjectToChange, (object) ((SiteChanges) obj)._ObjectToChange) && (object.Equals((object) this._User, (object) ((SiteChanges) obj)._User) && object.Equals((object) this._Name, (object) ((SiteChanges) obj)._Name))) && base.Equals(obj);
    }

    public NamedObjectRef EMailTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailTransport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (EMailTransport));
      }
    }

    public NamedObjectRef DefaultDataTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultDataTransport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DefaultDataTransport));
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

    public NamedObjectRef User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (User));
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
