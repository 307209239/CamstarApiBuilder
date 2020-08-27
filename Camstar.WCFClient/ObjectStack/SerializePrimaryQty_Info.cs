// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializePrimaryQty_Info
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
  public class SerializePrimaryQty_Info : Serialize_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializePrimaryQty_Info_ChildUOM")]
    protected new Info _ChildUOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializePrimaryQty_Info_ChildQty")]
    protected new Info _ChildQty;

    public new Info ChildUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildUOM));
      }
    }

    public new Info ChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildQty));
      }
    }
  }
}
