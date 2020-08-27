// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AttachDocument_AttachDocument_CreateDoc_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class AttachDocument_AttachDocument_CreateDoc_Parameters : AttachDocument_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "IsAttachment")]
    protected string _IsAttachment;
    [DataMember(EmitDefaultValue = false, Name = "DocumentRevision")]
    protected string _DocumentRevision;

    public string IsAttachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsAttachment), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (IsAttachment));
      }
    }

    public string DocumentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentRevision), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (DocumentRevision));
      }
    }
  }
}
