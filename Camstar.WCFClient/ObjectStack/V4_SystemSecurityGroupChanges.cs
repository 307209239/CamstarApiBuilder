// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SystemSecurityGroupChanges
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
  public class V4_SystemSecurityGroupChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_FullName")]
    protected Primitive<string> _FullName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_DomainName")]
    protected Primitive<string> _DomainName;

    public override bool Equals(object obj)
    {
      return obj is V4_SystemSecurityGroupChanges && object.Equals((object) this._Name, (object) ((V4_SystemSecurityGroupChanges) obj)._Name) && (object.Equals((object) this._ObjectToChange, (object) ((V4_SystemSecurityGroupChanges) obj)._ObjectToChange) && object.Equals((object) this._FullName, (object) ((V4_SystemSecurityGroupChanges) obj)._FullName)) && object.Equals((object) this._DomainName, (object) ((V4_SystemSecurityGroupChanges) obj)._DomainName) && base.Equals(obj);
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

    public Primitive<string> FullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FullName));
      }
    }

    public Primitive<string> DomainName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DomainName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DomainName));
      }
    }
  }
}
