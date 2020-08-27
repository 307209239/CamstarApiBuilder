// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ContainerInfoInquiry_Result
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ContainerInfoInquiry_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ContainerInfoInquiry _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ContainerInfoInquiry_Environment _Environment;

    public ContainerInfoInquiry Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ContainerInfoInquiry) this.PropertyGet(nameof (Value));
      }
    }

    public ContainerInfoInquiry_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ContainerInfoInquiry_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
