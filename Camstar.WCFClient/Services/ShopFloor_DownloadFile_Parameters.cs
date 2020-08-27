// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_DownloadFile_Parameters
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
  public class ShopFloor_DownloadFile_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "DocumentName")]
    protected string _DocumentName;
    [DataMember(EmitDefaultValue = false, Name = "Attachment")]
    protected string _Attachment;
    [DataMember(EmitDefaultValue = false, Name = "FileLocation")]
    protected string _FileLocation;

    public string DocumentName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentName), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (DocumentName));
      }
    }

    public string Attachment
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attachment), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Attachment));
      }
    }

    public string FileLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (FileLocation), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (FileLocation));
      }
    }
  }
}
