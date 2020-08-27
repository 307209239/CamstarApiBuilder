// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationHistoryDetails_Environment
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
  public class ChgDurationHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationHistoryDetails_Environment_NewDurationValue")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1049736, false, false, false, null)]
    protected Environment _NewDurationValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationHistoryDetails_Environment_OldDurationValue")]
    [Metadata("Time as a duration", "", false, false, true, "Float", 1049737, false, false, false, null)]
    protected Environment _OldDurationValue;

    public Environment NewDurationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDurationValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewDurationValue));
      }
    }

    public Environment OldDurationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDurationValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldDurationValue));
      }
    }
  }
}
