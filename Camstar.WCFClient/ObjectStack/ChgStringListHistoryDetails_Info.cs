// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringListHistoryDetails_Info
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
  public class ChgStringListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgStringListHistoryDetails_Info_NewStringListValue")]
    protected Info _NewStringListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgStringListHistoryDetails_Info_OldStringListValue")]
    protected Info _OldStringListValue;

    public Info NewStringListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewStringListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewStringListValue));
      }
    }

    public Info OldStringListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldStringListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldStringListValue));
      }
    }
  }
}
