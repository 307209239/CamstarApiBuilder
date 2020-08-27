// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerListHistoryDetails_Info
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
  public class ChgIntegerListHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListHistoryDetails_Info_NewIntegerListValue")]
    protected Info _NewIntegerListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListHistoryDetails_Info_OldIntegerListValue")]
    protected Info _OldIntegerListValue;

    public Info NewIntegerListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewIntegerListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewIntegerListValue));
      }
    }

    public Info OldIntegerListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldIntegerListValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldIntegerListValue));
      }
    }
  }
}
