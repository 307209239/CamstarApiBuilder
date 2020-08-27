// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ServiceSecurity_Info
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
  public class V4_ServiceSecurity_Info : V4_Security_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_ServiceSecurity_Info_CopyFromServiceName")]
    protected Info _CopyFromServiceName;
    [DataMember(EmitDefaultValue = false, Name = "V4_ServiceSecurity_Info_ServiceName")]
    protected Info _ServiceName;

    public Info CopyFromServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CopyFromServiceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CopyFromServiceName));
      }
    }

    public Info ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
