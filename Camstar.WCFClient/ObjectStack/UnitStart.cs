// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UnitStart
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
  public class UnitStart : Start
  {
    [DataMember(EmitDefaultValue = false, Name = "UnitStart_Details")]
    protected UnitStartDetails _Details;
    [DataMember(EmitDefaultValue = false, Name = "UnitStart_CurrentStatusDetails")]
    protected V3_CurrentStatusStartDetails _CurrentStatusDetails;

    public override bool Equals(object obj)
    {
      return obj is UnitStart && object.Equals((object) this._Details, (object) ((UnitStart) obj)._Details) && object.Equals((object) this._CurrentStatusDetails, (object) ((UnitStart) obj)._CurrentStatusDetails) && base.Equals(obj);
    }

    public UnitStartDetails Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (UnitStartDetails) this.PropertyGet(nameof (Details));
      }
    }

    public V3_CurrentStatusStartDetails CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (V3_CurrentStatusStartDetails) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }
  }
}
