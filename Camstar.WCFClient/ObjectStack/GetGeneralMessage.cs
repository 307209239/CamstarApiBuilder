// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetGeneralMessage
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
  public class GetGeneralMessage : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetGeneralMessage_GeneralMessage")]
    protected Primitive<string> _GeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "GetGeneralMessage_DisplayGeneralMessage")]
    protected Primitive<bool> _DisplayGeneralMessage;

    public override bool Equals(object obj)
    {
      return obj is GetGeneralMessage && object.Equals((object) this._GeneralMessage, (object) ((GetGeneralMessage) obj)._GeneralMessage) && object.Equals((object) this._DisplayGeneralMessage, (object) ((GetGeneralMessage) obj)._DisplayGeneralMessage) && base.Equals(obj);
    }

    public Primitive<string> GeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralMessage));
      }
    }

    public Primitive<bool> DisplayGeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayGeneralMessage), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayGeneralMessage));
      }
    }
  }
}
