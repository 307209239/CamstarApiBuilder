// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampHistoryDetails_Info
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
  public class ChgTimeStampHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampHistoryDetails_Info_NewTimeStampValue")]
    protected Info _NewTimeStampValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampHistoryDetails_Info_OldTimeStampValue")]
    protected Info _OldTimeStampValue;

    public Info NewTimeStampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewTimeStampValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewTimeStampValue));
      }
    }

    public Info OldTimeStampValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldTimeStampValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldTimeStampValue));
      }
    }
  }
}
