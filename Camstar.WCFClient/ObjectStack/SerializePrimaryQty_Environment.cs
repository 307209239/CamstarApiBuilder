// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SerializePrimaryQty_Environment
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
  public class SerializePrimaryQty_Environment : Serialize_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SerializePrimaryQty_Environment_ChildUOM")]
    [Metadata("The user code for unit of material.", "UOM", false, false, true, "NamedObjectRef", 1049881, false, false, true, null)]
    protected new Environment _ChildUOM;
    [DataMember(EmitDefaultValue = false, Name = "SerializePrimaryQty_Environment_ChildQty")]
    [Metadata("Material quantity (individual)", "", false, false, true, "Fixed", 1049879, false, false, false, "1")]
    protected new Environment _ChildQty;

    public new Environment ChildUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildUOM), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildUOM));
      }
    }

    public new Environment ChildQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildQty));
      }
    }
  }
}
