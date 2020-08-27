// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventFailureActions_Environment
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
  public class UpdateEventFailureActions_Environment : UpdateEventDetails_Environment
  {
    [Metadata("Service Details to assign the Failure information to an Event.", "EventFailureDetail", false, false, false, "EventFailureDetail", 1051072, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureActions_Environment_EventFailureDetails")]
    protected EventFailureDetail_Environment _EventFailureDetails;
    [Metadata("Identifies a failure action for an Event or Cause.", "EventFailureActionDetail", false, false, false, "EventFailureActionDetail", 1052950, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureActions_Environment_EventFailureActionDetails")]
    protected EventFailureActionDetail_Environment _EventFailureActionDetails;

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

    public EventFailureActionDetail_Environment EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail_Environment) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }
  }
}
