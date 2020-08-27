// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelDetails
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
  public class LabelDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelDetails_TagValue")]
    protected Primitive<string> _TagValue;
    [DataMember(EmitDefaultValue = false, Name = "LabelDetails_TagName")]
    protected Primitive<string> _TagName;

    public override bool Equals(object obj)
    {
      return obj is LabelDetails && object.Equals((object) this._TagValue, (object) ((LabelDetails) obj)._TagValue) && object.Equals((object) this._TagName, (object) ((LabelDetails) obj)._TagName) && base.Equals(obj);
    }

    public Primitive<string> TagValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TagValue));
      }
    }

    public Primitive<string> TagName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TagName));
      }
    }
  }
}
