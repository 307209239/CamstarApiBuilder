// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringListHistoryDetails
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
  public class ChgStringListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgStringListHistoryDetails_NewStringListValue")]
    protected Primitive<string>[] _NewStringListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgStringListHistoryDetails_OldStringListValue")]
    protected Primitive<string>[] _OldStringListValue;

    public override bool Equals(object obj)
    {
      return obj is ChgStringListHistoryDetails && this.CompareArrays((Array) this._NewStringListValue, (Array) ((ChgStringListHistoryDetails) obj)._NewStringListValue) && this.CompareArrays((Array) this._OldStringListValue, (Array) ((ChgStringListHistoryDetails) obj)._OldStringListValue) && base.Equals(obj);
    }

    public Primitive<string>[] NewStringListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewStringListValue), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (NewStringListValue));
      }
    }

    public Primitive<string>[] OldStringListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldStringListValue), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (OldStringListValue));
      }
    }
  }
}
