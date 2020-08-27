// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.LabelDetails_Info
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
  public class LabelDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelDetails_Info_TagValue")]
    protected Info _TagValue;
    [DataMember(EmitDefaultValue = false, Name = "LabelDetails_Info_TagName")]
    protected Info _TagName;

    public Info TagValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TagValue));
      }
    }

    public Info TagName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TagName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TagName));
      }
    }
  }
}
