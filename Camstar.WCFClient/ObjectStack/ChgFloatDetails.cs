// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgFloatDetails
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
  public class ChgFloatDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgFloatDetails_NewValue")]
    protected Primitive<double> _NewValue;

    public override bool Equals(object obj)
    {
      return obj is ChgFloatDetails && object.Equals((object) this._NewValue, (object) ((ChgFloatDetails) obj)._NewValue) && base.Equals(obj);
    }

    public Primitive<double> NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NewValue));
      }
    }
  }
}
