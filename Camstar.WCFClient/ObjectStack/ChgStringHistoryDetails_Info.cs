// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringHistoryDetails_Info
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
  public class ChgStringHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgStringHistoryDetails_Info_NewStringValue")]
    protected Info _NewStringValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgStringHistoryDetails_Info_OldStringValue")]
    protected Info _OldStringValue;

    public Info NewStringValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewStringValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewStringValue));
      }
    }

    public Info OldStringValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldStringValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldStringValue));
      }
    }
  }
}
