// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_ServiceSecurity_Environment
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
  public class V4_ServiceSecurity_Environment : V4_Security_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_ServiceSecurity_Environment_CopyFromServiceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049826, false, false, false, null)]
    protected Environment _CopyFromServiceName;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049390, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_ServiceSecurity_Environment_ServiceName")]
    protected Environment _ServiceName;

    public Environment CopyFromServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CopyFromServiceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CopyFromServiceName));
      }
    }

    public Environment ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceName));
      }
    }
  }
}
