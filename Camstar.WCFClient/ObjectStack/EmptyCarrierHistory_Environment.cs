// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrierHistory_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (EmptyMaterialContainerHistory_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class EmptyCarrierHistory_Environment : QtyHistory_Environment
  {
    [Metadata("A carrier is a physical entity that holds material which is used in batch processing.  Carriers are resources like: Vessels, Vats, drums, trays etc. \r\n\r\n", "Carrier", false, false, true, "NamedObjectRef", 1051807, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierHistory_Environment_Carrier")]
    protected Environment _Carrier;

    public Environment Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Carrier));
      }
    }
  }
}
