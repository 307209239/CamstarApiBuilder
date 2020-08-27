// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventFailures
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
  public class UpdateEventFailures : UpdateEventDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailures_EventFailureDetails")]
    protected EventFailureDetail[] _EventFailureDetails;

    public override bool Equals(object obj)
    {
      return obj is UpdateEventFailures && this.CompareArrays((Array) this._EventFailureDetails, (Array) ((UpdateEventFailures) obj)._EventFailureDetails) && base.Equals(obj);
    }

    public EventFailureDetail[] EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail[]) this.PropertyGet(nameof (EventFailureDetails));
      }
    }
  }
}
