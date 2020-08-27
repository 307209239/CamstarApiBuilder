// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampListHistoryDetails_Info
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
  public class ChgTimeStampListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListHistoryDetails_Info_OldTimeStampListValue")]
    protected Info _OldTimeStampListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListHistoryDetails_Info_NewTimeStampListValue")]
    protected Info _NewTimeStampListValue;

    public Info OldTimeStampListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldTimeStampListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldTimeStampListValue));
      }
    }

    public Info NewTimeStampListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewTimeStampListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewTimeStampListValue));
      }
    }
  }
}
