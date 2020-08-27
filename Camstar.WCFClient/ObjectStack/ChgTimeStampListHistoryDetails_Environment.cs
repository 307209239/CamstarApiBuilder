// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampListHistoryDetails_Environment
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
  public class ChgTimeStampListHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049763, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListHistoryDetails_Environment_OldTimeStampListValue")]
    protected Environment _OldTimeStampListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListHistoryDetails_Environment_NewTimeStampListValue")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049762, false, true, false, null)]
    protected Environment _NewTimeStampListValue;

    public Environment OldTimeStampListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldTimeStampListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldTimeStampListValue));
      }
    }

    public Environment NewTimeStampListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewTimeStampListValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewTimeStampListValue));
      }
    }
  }
}
