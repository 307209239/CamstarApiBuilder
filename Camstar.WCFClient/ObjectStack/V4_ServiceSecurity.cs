// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ServiceSecurity
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
  public class V4_ServiceSecurity : V4_Security
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_ServiceSecurity_CopyFromServiceName")]
    protected Primitive<string> _CopyFromServiceName;
    [DataMember(EmitDefaultValue = false, Name = "V4_ServiceSecurity_ServiceName")]
    protected Primitive<string> _ServiceName;

    public override bool Equals(object obj)
    {
      return obj is V4_ServiceSecurity && object.Equals((object) this._CopyFromServiceName, (object) ((V4_ServiceSecurity) obj)._CopyFromServiceName) && object.Equals((object) this._ServiceName, (object) ((V4_ServiceSecurity) obj)._ServiceName) && base.Equals(obj);
    }

    public Primitive<string> CopyFromServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CopyFromServiceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CopyFromServiceName));
      }
    }

    public Primitive<string> ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
