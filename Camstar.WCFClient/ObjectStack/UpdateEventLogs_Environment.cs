// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventLogs_Environment
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
  public class UpdateEventLogs_Environment : UpdateEventDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventLogs_Environment_EventLogDetails")]
    [Metadata("Identifies a Log for an Event.", "EventLogDetail", false, false, false, "EventLogDetail", 16779189, false, true, false, null)]
    protected EventLogDetail_Environment _EventLogDetails;

    public EventLogDetail_Environment EventLogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogDetails), (object) value);
      }
      get
      {
        return (EventLogDetail_Environment) this.PropertyGet(nameof (EventLogDetails));
      }
    }
  }
}
