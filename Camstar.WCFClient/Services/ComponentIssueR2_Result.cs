// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentIssueR2_Result
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
  public class ComponentIssueR2_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ComponentIssueR2 _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ComponentIssueR2_Environment _Environment;

    public ComponentIssueR2 Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ComponentIssueR2) this.PropertyGet(nameof (Value));
      }
    }

    public ComponentIssueR2_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ComponentIssueR2_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
