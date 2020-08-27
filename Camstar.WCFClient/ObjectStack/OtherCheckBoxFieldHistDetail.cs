// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OtherCheckBoxFieldHistDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ReportSourceHistoryDetail))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DeviceOperatorHistoryDetail))]
  [KnownType(typeof (EventTypeHistoryDetail))]
  [Serializable]
  public class OtherCheckBoxFieldHistDetail : EventCheckBoxFieldHistDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxFieldHistDetail_OtherText")]
    protected Primitive<string> _OtherText;
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxFieldHistDetail_Other")]
    protected Primitive<bool> _Other;

    public override bool Equals(object obj)
    {
      return obj is OtherCheckBoxFieldHistDetail && object.Equals((object) this._OtherText, (object) ((OtherCheckBoxFieldHistDetail) obj)._OtherText) && object.Equals((object) this._Other, (object) ((OtherCheckBoxFieldHistDetail) obj)._Other) && base.Equals(obj);
    }

    public Primitive<string> OtherText
    {
      [param: In] set
      {
        this.PropertySet(nameof (OtherText), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OtherText));
      }
    }

    public Primitive<bool> Other
    {
      [param: In] set
      {
        this.PropertySet(nameof (Other), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Other));
      }
    }
  }
}
