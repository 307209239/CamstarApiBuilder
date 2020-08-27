// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgStringDetails
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
  public class ChgStringDetails : ChangeAttributeDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgStringDetails_NewValue")]
    protected Primitive<string> _NewValue;

    public override bool Equals(object obj)
    {
      return obj is ChgStringDetails && object.Equals((object) this._NewValue, (object) ((ChgStringDetails) obj)._NewValue) && base.Equals(obj);
    }

    public Primitive<string> NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NewValue));
      }
    }
  }
}
