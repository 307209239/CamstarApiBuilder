// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateEventFailureActions_GetFailures_Parameters
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
  public class UpdateEventFailureActions_GetFailures_Parameters : UpdateEventFailureActions_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "EventData")]
    protected string _EventData;

    public string EventData
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventData), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (EventData));
      }
    }
  }
}
