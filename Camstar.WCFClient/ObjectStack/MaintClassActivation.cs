// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintClassActivation
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
  public class MaintClassActivation : MaintenanceReqTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintClassActivation_ServiceDetails")]
    protected MaintClassActivationDetails[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is MaintClassActivation && this.CompareArrays((Array) this._ServiceDetails, (Array) ((MaintClassActivation) obj)._ServiceDetails) && base.Equals(obj);
    }

    public MaintClassActivationDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (MaintClassActivationDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
