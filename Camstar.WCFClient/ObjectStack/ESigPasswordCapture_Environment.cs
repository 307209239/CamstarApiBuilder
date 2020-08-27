// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigPasswordCapture_Environment
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
  public class ESigPasswordCapture_Environment : ESigCaptureDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigPasswordCapture_Environment_CosignerPassword")]
    [Metadata("Password", "", false, false, false, "PasswordFieldType", 1050359, false, false, false, null)]
    protected Environment _CosignerPassword;
    [Metadata("Password", "", false, false, false, "PasswordFieldType", 1050362, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigPasswordCapture_Environment_SignerPassword")]
    protected Environment _SignerPassword;

    public Environment CosignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerPassword), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CosignerPassword));
      }
    }

    public Environment SignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerPassword), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SignerPassword));
      }
    }
  }
}
