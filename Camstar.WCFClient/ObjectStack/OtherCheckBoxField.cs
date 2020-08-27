// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OtherCheckBoxField
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DeviceOperatorField))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (ReportSourceField))]
  [KnownType(typeof (EventTypeField))]
  [Serializable]
  public class OtherCheckBoxField : EventCheckBoxField
  {
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxField_Other")]
    protected Primitive<bool> _Other;
    [DataMember(EmitDefaultValue = false, Name = "OtherCheckBoxField_OtherText")]
    protected Primitive<string> _OtherText;

    public override bool Equals(object obj)
    {
      return obj is OtherCheckBoxField && object.Equals((object) this._Other, (object) ((OtherCheckBoxField) obj)._Other) && object.Equals((object) this._OtherText, (object) ((OtherCheckBoxField) obj)._OtherText) && base.Equals(obj);
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
  }
}
