// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationListDetails_Environment
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
  public class ChgDurationListDetails_Environment : ChangeAttributeDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListDetails_Environment_NewValues")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049478, false, true, false, null)]
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
