// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanListHistoryDetails_Info
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
  public class ChgBooleanListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListHistoryDetails_Info_OldBooleanListValue")]
    protected Info _OldBooleanListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanListHistoryDetails_Info_NewBooleanListValue")]
    protected Info _NewBooleanListValue;

    public Info OldBooleanListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldBooleanListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldBooleanListValue));
      }
    }

    public Info NewBooleanListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewBooleanListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewBooleanListValue));
      }
    }
  }
}
