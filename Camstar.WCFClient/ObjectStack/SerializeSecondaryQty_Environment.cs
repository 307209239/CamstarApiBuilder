// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializeSecondaryQty_Environment
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
  public class SerializeSecondaryQty_Environment : Serialize_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049880, false, false, false, "1")]
    [DataMember(EmitDefaultValue = false, Name = "SerializeSecondaryQty_Environment_ChildQty2")]
    protected new Environment _ChildQty2;
    [DataMember(EmitDefaultValue = false, Name = "SerializeSecondaryQty_Environment_ChildUOM2")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1049882, false, false, true, null)]
    protected new Environment _ChildUOM2;

    public new Environment ChildQty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildQty2));
      }
    }

    public new Environment ChildUOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM2), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildUOM2));
      }
    }
  }
}
