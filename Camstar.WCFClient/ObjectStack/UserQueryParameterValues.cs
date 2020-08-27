// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryParameterValues
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
  public class UserQueryParameterValues : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterValues_ParameterValue")]
    protected Primitive<string> _ParameterValue;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterValues_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is UserQueryParameterValues && object.Equals((object) this._ParameterValue, (object) ((UserQueryParameterValues) obj)._ParameterValue) && object.Equals((object) this._Name, (object) ((UserQueryParameterValues) obj)._Name) && base.Equals(obj);
    }

    public Primitive<string> ParameterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParameterValue));
      }
    }

    public Primitive<string> Name
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
