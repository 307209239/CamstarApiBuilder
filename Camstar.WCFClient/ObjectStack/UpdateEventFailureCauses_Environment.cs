// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventFailureCauses_Environment
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
  public class UpdateEventFailureCauses_Environment : UpdateEventDetails_Environment
  {
    [Metadata("Service Details to assign the Failure information to an Event.", "EventFailureDetail", false, false, false, "EventFailureDetail", 1051072, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureCauses_Environment_EventFailureDetails")]
    protected EventFailureDetail_Environment _EventFailureDetails;

    public EventFailureDetail_Environment EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail_Environment) this.PropertyGet(nameof (EventFailureDetails));
      }
    }
  }
}
