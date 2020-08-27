// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgIntegerListDetails
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
  public class ChgIntegerListDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgIntegerListDetails_NewValues")]
    protected Primitive<int>[] _NewValues;

    public override bool Equals(object obj)
    {
      return obj is ChgIntegerListDetails && this.CompareArrays((Array) this._NewValues, (Array) ((ChgIntegerListDetails) obj)._NewValues) && base.Equals(obj);
    }

    public Primitive<int>[] NewValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValues), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (NewValues));
      }
    }
  }
}
