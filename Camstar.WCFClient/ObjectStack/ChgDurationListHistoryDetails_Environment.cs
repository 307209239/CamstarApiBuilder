// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationListHistoryDetails_Environment
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
  public class ChgDurationListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("Time as a duration", "", false, false, true, "Float", 1049739, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListHistoryDetails_Environment_OldDurationListValue")]
    protected Environment _OldDurationListValue;
    [Metadata("Time as a duration", "", false, false, true, "Float", 1049738, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListHistoryDetails_Environment_NewDurationListValue")]
    protected Environment _NewDurationListValue;

    public Environment OldDurationListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDurationListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldDurationListValue));
      }
    }

    public Environment NewDurationListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDurationListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewDurationListValue));
      }
    }
  }
}
