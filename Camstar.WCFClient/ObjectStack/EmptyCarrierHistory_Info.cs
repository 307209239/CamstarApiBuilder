// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmptyCarrierHistory_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EmptyMaterialContainerHistory_Info))]
  [Serializable]
  public class EmptyCarrierHistory_Info : QtyHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "EmptyCarrierHistory_Info_Carrier")]
    protected Info _Carrier;

    public Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }
  }
}
