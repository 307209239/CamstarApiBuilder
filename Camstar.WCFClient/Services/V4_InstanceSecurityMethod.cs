// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_InstanceSecurityMethod
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class V4_InstanceSecurityMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public V4_InstanceSecurity Cdo;
    [DataMember(EmitDefaultValue = false)]
    public V4_InstanceSecurityMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public V4_InstanceSecurity_Parameters Parameters;

    public V4_InstanceSecurityMethod(
      V4_InstanceSecurity Cdo,
      V4_InstanceSecurityMethods Method,
      V4_InstanceSecurity_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
