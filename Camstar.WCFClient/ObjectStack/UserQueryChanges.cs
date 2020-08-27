// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryChanges
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
  public class UserQueryChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_UserQueryParameters")]
    protected UserQueryParameterChanges[] _UserQueryParameters;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_QueryText")]
    protected Primitive<string> _QueryText;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UserQueryChanges && this.CompareArrays((Array) this._UserQueryParameters, (Array) ((UserQueryChanges) obj)._UserQueryParameters) && (object.Equals((object) this._ObjectToChange, (object) ((UserQueryChanges) obj)._ObjectToChange) && object.Equals((object) this._QueryText, (object) ((UserQueryChanges) obj)._QueryText)) && object.Equals((object) this._Name, (object) ((UserQueryChanges) obj)._Name) && base.Equals(obj);
    }

    public UserQueryParameterChanges[] UserQueryParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserQueryParameters), (object) value);
      }
      get
      {
        return (UserQueryParameterChanges[]) this.PropertyGet(nameof (UserQueryParameters));
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

    public Primitive<string> QueryText
    {
      [param: In] set
      {
        this.PropertySet(nameof (QueryText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QueryText));
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
