// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigPasswordCapture_Info
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
  public class ESigPasswordCapture_Info : ESigCaptureDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigPasswordCapture_Info_CosignerPassword")]
    protected Info _CosignerPassword;
    [DataMember(EmitDefaultValue = false, Name = "ESigPasswordCapture_Info_SignerPassword")]
    protected Info _SignerPassword;

    public Info CosignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerPassword), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignerPassword));
      }
    }

    public Info SignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerPassword), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignerPassword));
      }
    }
  }
}
