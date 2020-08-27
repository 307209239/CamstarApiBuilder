// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportFiledWithFDAField
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
  public class ReportFiledWithFDAField : UserResponseYesNoField
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportFiledWithFDAField_Unknown")]
    protected Primitive<bool> _Unknown;

    public override bool Equals(object obj)
    {
      return obj is ReportFiledWithFDAField && object.Equals((object) this._Unknown, (object) ((ReportFiledWithFDAField) obj)._Unknown) && base.Equals(obj);
    }

    public Primitive<bool> Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Unknown));
      }
    }
  }
}
