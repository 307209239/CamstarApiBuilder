// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFixedListHistoryDetails
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
  public class ChgFixedListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListHistoryDetails_NewFixedListValue")]
    protected Primitive<double>[] _NewFixedListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFixedListHistoryDetails_OldFixedList")]
    protected Primitive<double>[] _OldFixedList;

    public override bool Equals(object obj)
    {
      return obj is ChgFixedListHistoryDetails && this.CompareArrays((Array) this._NewFixedListValue, (Array) ((ChgFixedListHistoryDetails) obj)._NewFixedListValue) && this.CompareArrays((Array) this._OldFixedList, (Array) ((ChgFixedListHistoryDetails) obj)._OldFixedList) && base.Equals(obj);
    }

    public Primitive<double>[] NewFixedListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFixedListValue), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (NewFixedListValue));
      }
    }

    public Primitive<double>[] OldFixedList
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFixedList), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (OldFixedList));
      }
    }
  }
}
