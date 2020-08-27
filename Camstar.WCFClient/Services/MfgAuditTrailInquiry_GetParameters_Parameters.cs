// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MfgAuditTrailInquiry_GetParameters_Parameters
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
  public class MfgAuditTrailInquiry_GetParameters_Parameters : MfgAuditTrailInquiry_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "SizeLimit")]
    protected string _SizeLimit;
    [DataMember(EmitDefaultValue = false, Name = "StartRow")]
    protected string _StartRow;

    public string SizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (SizeLimit), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (SizeLimit));
      }
    }

    public string StartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartRow), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (StartRow));
      }
    }
  }
}
