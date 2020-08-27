// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportFiledWithFDAHistDetail
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
  public class ReportFiledWithFDAHistDetail : UserResponseYesNoFieldHistDet
  {
    [DataMember(EmitDefaultValue = false, Name = "ReportFiledWithFDAHistDetail_Unknown")]
    protected Primitive<bool> _Unknown;

    public override bool Equals(object obj)
    {
      return obj is ReportFiledWithFDAHistDetail && object.Equals((object) this._Unknown, (object) ((ReportFiledWithFDAHistDetail) obj)._Unknown) && base.Equals(obj);
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
