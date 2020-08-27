// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatListHistoryDetails_Environment
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
  public class ChgFloatListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("Generic Float", "", false, false, true, "Float", 1049746, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListHistoryDetails_Environment_NewFloatListValue")]
    protected Environment _NewFloatListValue;
    [Metadata("Generic Float", "", false, false, true, "Float", 1049747, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListHistoryDetails_Environment_OldFloatListValue")]
    protected Environment _OldFloatListValue;

    public Environment NewFloatListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFloatListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewFloatListValue));
      }
    }

    public Environment OldFloatListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFloatListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldFloatListValue));
      }
    }
  }
}
