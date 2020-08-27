// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_ObjectTypeSecurityMethod
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
  public class V4_ObjectTypeSecurityMethod : Method
  {
    [DataMember(EmitDefaultValue = false)]
    public V4_ObjectTypeSecurity Cdo;
    [DataMember(EmitDefaultValue = false)]
    public V4_ObjectTypeSecurityMethods ServiceMethod;
    [DataMember(EmitDefaultValue = false)]
    public V4_ObjectTypeSecurity_Parameters Parameters;

    public V4_ObjectTypeSecurityMethod(
      V4_ObjectTypeSecurity Cdo,
      V4_ObjectTypeSecurityMethods Method,
      V4_ObjectTypeSecurity_Parameters Parameters)
    {
      this.Cdo = Cdo;
      this.ServiceMethod = Method;
      this.Parameters = Parameters;
    }
  }
}
