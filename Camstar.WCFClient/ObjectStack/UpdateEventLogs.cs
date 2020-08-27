// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventLogs
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
  public class UpdateEventLogs : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventLogs_EventLogDetails")]
    protected EventLogDetail[] _EventLogDetails;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventLogs && this.CompareArrays((Array) this._EventLogDetails, (Array) ((UpdateEventLogs) obj)._EventLogDetails) && base.Equals(obj);
    }

    public EventLogDetail[] EventLogDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventLogDetails), (object) value);
      }
      get
      {
        return (EventLogDetail[]) this.PropertyGet(nameof (EventLogDetails));
      }
    }
  }
}
