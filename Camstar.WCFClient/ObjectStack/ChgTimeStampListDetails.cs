// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgTimeStampListDetails
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
  public class ChgTimeStampListDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgTimeStampListDetails_NewValues")]
    protected Primitive<DateTime>[] _NewValues;

    public override bool Equals(object obj)
    {
      return obj is ChgTimeStampListDetails && this.CompareArrays((Array) this._NewValues, (Array) ((ChgTimeStampListDetails) obj)._NewValues) && base.Equals(obj);
    }

    public Primitive<DateTime>[] NewValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValues), (object) value);
      }
      get
      {
        return (Primitive<DateTime>[]) this.PropertyGet(nameof (NewValues));
      }
    }
  }
}
