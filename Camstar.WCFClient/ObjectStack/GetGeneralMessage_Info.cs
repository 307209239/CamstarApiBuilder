// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetGeneralMessage_Info
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
  public class GetGeneralMessage_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "GetGeneralMessage_Info_GeneralMessage")]
    protected Info _GeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "GetGeneralMessage_Info_DisplayGeneralMessage")]
    protected Info _DisplayGeneralMessage;

    public Info GeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralMessage));
      }
    }

    public Info DisplayGeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayGeneralMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayGeneralMessage));
      }
    }
  }
}
