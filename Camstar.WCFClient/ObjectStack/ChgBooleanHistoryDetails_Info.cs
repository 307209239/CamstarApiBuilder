// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgBooleanHistoryDetails_Info
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
  public class ChgBooleanHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanHistoryDetails_Info_NewBooleanValue")]
    protected Info _NewBooleanValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgBooleanHistoryDetails_Info_OldBooleanValue")]
    protected Info _OldBooleanValue;

    public Info NewBooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewBooleanValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewBooleanValue));
      }
    }

    public Info OldBooleanValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldBooleanValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldBooleanValue));
      }
    }
  }
}
