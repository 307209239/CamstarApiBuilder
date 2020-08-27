// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MoveStd_ValidateTaskComplete_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MoveStd_ValidateTaskComplete_Parameters : MoveStd_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "Task")]
    protected string _Task;
    [DataMember(EmitDefaultValue = false, Name = "CompletedTask")]
    protected string _CompletedTask;

    public string Task
    {
      [param: In] set
      {
        this.PropertySet(nameof (Task), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Task));
      }
    }

    public string CompletedTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletedTask), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (CompletedTask));
      }
    }
  }
}
