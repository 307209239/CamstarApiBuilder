// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedHistoryDetails_Info
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
  public class ChgFixedHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedHistoryDetails_Info_OldFixedValue")]
    protected Info _OldFixedValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedHistoryDetails_Info_NewFixedValue")]
    protected Info _NewFixedValue;

    public Info OldFixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFixedValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldFixedValue));
      }
    }

    public Info NewFixedValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFixedValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewFixedValue));
      }
    }
  }
}
