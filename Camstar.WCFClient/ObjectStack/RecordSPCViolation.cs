// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecordSPCViolation
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
  public class RecordSPCViolation : SPCTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "RecordSPCViolation_ServiceDetails")]
    protected RecordSPCViolationDetail[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is RecordSPCViolation && this.CompareArrays((Array) this._ServiceDetails, (Array) ((RecordSPCViolation) obj)._ServiceDetails) && base.Equals(obj);
    }

    public RecordSPCViolationDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (RecordSPCViolationDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
