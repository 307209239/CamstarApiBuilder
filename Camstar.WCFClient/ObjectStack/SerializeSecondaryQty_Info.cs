// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeSecondaryQty_Info
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
  public class SerializeSecondaryQty_Info : Serialize_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializeSecondaryQty_Info_ChildQty2")]
    protected new Info _ChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "SerializeSecondaryQty_Info_ChildUOM2")]
    protected new Info _ChildUOM2;

    public new Info ChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildQty2));
      }
    }

    public new Info ChildUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildUOM2));
      }
    }
  }
}
