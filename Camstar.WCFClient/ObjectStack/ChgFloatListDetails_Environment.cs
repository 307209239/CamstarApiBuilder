// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatListDetails_Environment
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
  public class ChgFloatListDetails_Environment : ChangeAttributeDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListDetails_Environment_NewValues")]
    [Metadata("Generic Float", "", false, false, false, "Float", 1049132, false, true, false, null)]
    protected Environment _NewValues;

    public Environment NewValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValues), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewValues));
      }
    }
  }
}
