// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetGeneralMessage_Environment
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
  public class GetGeneralMessage_Environment : Inquiry_Environment
  {
    [Metadata("LongString", "", false, false, false, "String", 16778737, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "GetGeneralMessage_Environment_GeneralMessage")]
    protected Environment _GeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "GetGeneralMessage_Environment_DisplayGeneralMessage")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778733, false, false, false, "0")]
    protected Environment _DisplayGeneralMessage;

    public Environment GeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GeneralMessage));
      }
    }

    public Environment DisplayGeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayGeneralMessage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DisplayGeneralMessage));
      }
    }
  }
}
