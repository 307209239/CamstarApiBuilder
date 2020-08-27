// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatListHistoryDetails_Info
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
  public class ChgFloatListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListHistoryDetails_Info_NewFloatListValue")]
    protected Info _NewFloatListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListHistoryDetails_Info_OldFloatListValue")]
    protected Info _OldFloatListValue;

    public Info NewFloatListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFloatListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewFloatListValue));
      }
    }

    public Info OldFloatListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFloatListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldFloatListValue));
      }
    }
  }
}
