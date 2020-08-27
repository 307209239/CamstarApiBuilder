// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventLogs_Info
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
  public class UpdateEventLogs_Info : UpdateEventDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventLogs_Info_EventLogDetails")]
    protected EventLogDetail_Info _EventLogDetails;

    public EventLogDetail_Info EventLogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogDetails), (object) value);
      }
      get
      {
        return (EventLogDetail_Info) this.PropertyGet(nameof (EventLogDetails));
      }
    }
  }
}
