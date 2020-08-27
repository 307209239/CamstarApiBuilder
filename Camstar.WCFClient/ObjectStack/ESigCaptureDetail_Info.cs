// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigCaptureDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ESigPasswordCapture_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigCaptureDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Info_CosignReason")]
    protected Info _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Info_Cosigner")]
    protected Info _Cosigner;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Info_Signer")]
    protected Info _Signer;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Info_SignerFullName")]
    protected Info _SignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Info_CosignerFullName")]
    protected Info _CosignerFullName;

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

    public Info CosignReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignReason));
      }
    }

    public Info Cosigner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cosigner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Cosigner));
      }
    }

    public Info Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Signer));
      }
    }

    public Info SignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerFullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignerFullName));
      }
    }

    public Info CosignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerFullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignerFullName));
      }
    }
  }
}
