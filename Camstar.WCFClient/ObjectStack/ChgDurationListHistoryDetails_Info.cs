// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationListHistoryDetails_Info
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
  public class ChgDurationListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListHistoryDetails_Info_OldDurationListValue")]
    protected Info _OldDurationListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationListHistoryDetails_Info_NewDurationListValue")]
    protected Info _NewDurationListValue;

    public Info OldDurationListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDurationListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldDurationListValue));
      }
    }

    public Info NewDurationListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDurationListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewDurationListValue));
      }
    }
  }
}
