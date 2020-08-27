// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UnitStart_Environment
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
  public class UnitStart_Environment : Start_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UnitStart_Environment_Details")]
    [Metadata("Unit start details", "UnitStartDetails", false, true, false, "UnitStartDetails", 1049090, true, false, false, null)]
    protected UnitStartDetails_Environment _Details;
    [Metadata("V3_CurrentStatusUnitStartDetails are subclassed from CurrentStatusStartDetails for compatibility only and should be used in GroupStart and UnitStart as CurrentStatusDetails field type.", "V3_CurrentStatusStartDetails", false, false, false, "V3_CurrentStatusStartDetails", 1049869, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UnitStart_Environment_CurrentStatusDetails")]
    protected V3_CurrentStatusStartDetails_Environment _CurrentStatusDetails;

    public UnitStartDetails_Environment Details
    {
      [param: In] set
      {
        this.PropertySet(nameof (Details), (object) value);
      }
      get
      {
        return (UnitStartDetails_Environment) this.PropertyGet(nameof (Details));
      }
    }

    public V3_CurrentStatusStartDetails_Environment CurrentStatusDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatusDetails), (object) value);
      }
      get
      {
        return (V3_CurrentStatusStartDetails_Environment) this.PropertyGet(nameof (CurrentStatusDetails));
      }
    }
  }
}
