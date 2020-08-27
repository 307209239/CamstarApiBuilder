// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampHistoryDetails_Environment
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
  public class ChgTimeStampHistoryDetails_Environment : ChangeAttributeHistoryDetails_Environment
  {
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049760, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampHistoryDetails_Environment_NewTimeStampValue")]
    protected Environment _NewTimeStampValue;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1049761, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampHistoryDetails_Environment_OldTimeStampValue")]
    protected Environment _OldTimeStampValue;

    public Environment NewTimeStampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewTimeStampValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewTimeStampValue));
      }
    }

    public Environment OldTimeStampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldTimeStampValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldTimeStampValue));
      }
    }
  }
}
