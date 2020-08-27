// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerHistoryDetails_Info
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
  public class ChgIntegerHistoryDetails_Info : ChangeAttributeHistoryDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerHistoryDetails_Info_OldIntegerValue")]
    protected Info _OldIntegerValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerHistoryDetails_Info_NewIntegerValue")]
    protected Info _NewIntegerValue;

    public Info OldIntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldIntegerValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OldIntegerValue));
      }
    }

    public Info NewIntegerValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewIntegerValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NewIntegerValue));
      }
    }
  }
}
