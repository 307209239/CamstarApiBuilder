// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.MfgAuditTrailInquiry_GMTToLocal_Parameters
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
  public class MfgAuditTrailInquiry_GMTToLocal_Parameters : MfgAuditTrailInquiry_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "NotConvetedDate")]
    protected string _NotConvetedDate;
    [DataMember(EmitDefaultValue = false, Name = "Expression")]
    protected string _Expression;

    public string NotConvetedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotConvetedDate), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (NotConvetedDate));
      }
    }

    public string Expression
    {
      [param: In] set
      {
        this.PropertySet(nameof (Expression), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Expression));
      }
    }
  }
}
