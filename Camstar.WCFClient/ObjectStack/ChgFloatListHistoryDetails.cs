// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatListHistoryDetails
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
  public class ChgFloatListHistoryDetails : ChangeAttributeHistoryDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListHistoryDetails_NewFloatListValue")]
    protected Primitive<double>[] _NewFloatListValue;
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatListHistoryDetails_OldFloatListValue")]
    protected Primitive<double>[] _OldFloatListValue;

    public override bool Equals(object obj)
    {
      return obj is ChgFloatListHistoryDetails && this.CompareArrays((Array) this._NewFloatListValue, (Array) ((ChgFloatListHistoryDetails) obj)._NewFloatListValue) && this.CompareArrays((Array) this._OldFloatListValue, (Array) ((ChgFloatListHistoryDetails) obj)._OldFloatListValue) && base.Equals(obj);
    }

    public Primitive<double>[] NewFloatListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewFloatListValue), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (NewFloatListValue));
      }
    }

    public Primitive<double>[] OldFloatListValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldFloatListValue), (object) value);
      }
      get
      {
        return (Primitive<double>[]) this.PropertyGet(nameof (OldFloatListValue));
      }
    }
  }
}
