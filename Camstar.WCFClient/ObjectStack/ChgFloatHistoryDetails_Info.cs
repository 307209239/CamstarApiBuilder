// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatHistoryDetails_Info
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
  public class ChgFloatHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatHistoryDetails_Info_OldFloatValue")]
    protected Info _OldFloatValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatHistoryDetails_Info_NewFloatValue")]
    protected Info _NewFloatValue;

    public Info OldFloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFloatValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldFloatValue));
      }
    }

    public Info NewFloatValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFloatValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewFloatValue));
      }
    }
  }
}
