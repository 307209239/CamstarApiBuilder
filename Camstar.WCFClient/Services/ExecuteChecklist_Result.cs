// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ExecuteChecklist_Result
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
  public class ExecuteChecklist_Result : Result
  {
    [DataMember(EmitDefaultValue = false, Name = "Value")]
    protected ExecuteChecklist _Value;
    [DataMember(EmitDefaultValue = false, Name = "Environment")]
    protected ExecuteChecklist_Environment _Environment;

    public ExecuteChecklist Value
    {
      [param: In] set
      {
        this.PropertySet(nameof (Value), (object) value);
      }
      get
      {
        return (ExecuteChecklist) this.PropertyGet(nameof (Value));
      }
    }

    public ExecuteChecklist_Environment Environment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Environment), (object) value);
      }
      get
      {
        return (ExecuteChecklist_Environment) this.PropertyGet(nameof (Environment));
      }
    }
  }
}
