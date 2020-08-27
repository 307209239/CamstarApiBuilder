// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedListHistoryDetails_Info
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
  public class ChgFixedListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListHistoryDetails_Info_NewFixedListValue")]
    protected Info _NewFixedListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListHistoryDetails_Info_OldFixedList")]
    protected Info _OldFixedList;

    public Info NewFixedListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFixedListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewFixedListValue));
      }
    }

    public Info OldFixedList
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFixedList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldFixedList));
      }
    }
  }
}
