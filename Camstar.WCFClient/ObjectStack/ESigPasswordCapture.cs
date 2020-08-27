// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigPasswordCapture
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
  public class ESigPasswordCapture : ESigCaptureDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigPasswordCapture_CosignerPassword")]
    protected PasswordFieldType _CosignerPassword;
    [DataMember(EmitDefaultValue = false, Name = "ESigPasswordCapture_SignerPassword")]
    protected PasswordFieldType _SignerPassword;

    public override bool Equals(object obj)
    {
      return obj is ESigPasswordCapture && object.Equals((object) this._CosignerPassword, (object) ((ESigPasswordCapture) obj)._CosignerPassword) && object.Equals((object) this._SignerPassword, (object) ((ESigPasswordCapture) obj)._SignerPassword) && base.Equals(obj);
    }

    public PasswordFieldType CosignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerPassword), (object) value);
      }
      get
      {
        return (PasswordFieldType) this.PropertyGet(nameof (CosignerPassword));
      }
    }

    public PasswordFieldType SignerPassword
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerPassword), (object) value);
      }
      get
      {
        return (PasswordFieldType) this.PropertyGet(nameof (SignerPassword));
      }
    }
  }
}
