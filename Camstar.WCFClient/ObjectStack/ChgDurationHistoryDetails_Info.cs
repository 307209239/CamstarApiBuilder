// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgDurationHistoryDetails_Info
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
  public class ChgDurationHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationHistoryDetails_Info_NewDurationValue")]
    protected Info _NewDurationValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgDurationHistoryDetails_Info_OldDurationValue")]
    protected Info _OldDurationValue;

    public Info NewDurationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewDurationValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewDurationValue));
      }
    }

    public Info OldDurationValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldDurationValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldDurationValue));
      }
    }
  }
}
