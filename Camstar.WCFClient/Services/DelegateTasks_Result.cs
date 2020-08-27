// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DelegateTasks_Result
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
  public class DelegateTasks_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected DelegateTasks _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected DelegateTasks_Environment _Environment;

    public DelegateTasks Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (DelegateTasks) this.PropertyGet(nameof (Value));
      }
    }

    public DelegateTasks_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (DelegateTasks_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
