// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UpdateEventFailureActions_Info
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
  public class UpdateEventFailureActions_Info : UpdateEventDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureActions_Info_EventFailureDetails")]
    protected EventFailureDetail_Info _EventFailureDetails;
    [DataMember(EmitDefaultValue = false, Name = "UpdateEventFailureActions_Info_EventFailureActionDetails")]
    protected EventFailureActionDetail_Info _EventFailureActionDetails;

    public EventFailureDetail_Info EventFailureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureDetails), (object) value);
      }
      get
      {
        return (EventFailureDetail_Info) this.PropertyGet(nameof (EventFailureDetails));
      }
    }

    public EventFailureActionDetail_Info EventFailureActionDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureActionDetails), (object) value);
      }
      get
      {
        return (EventFailureActionDetail_Info) this.PropertyGet(nameof (EventFailureActionDetails));
      }
    }
  }
}
