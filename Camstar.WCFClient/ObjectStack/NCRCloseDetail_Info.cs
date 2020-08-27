// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCloseDetail_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRCloseQualityDetail_Info))]
  [Serializable]
  public class NCRCloseDetail_Info : NCRUpdateDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseDetail_Info_NCRFailureCodes")]
    protected new Info _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseDetail_Info_NCRResolutionCode")]
    protected new Info _NCRResolutionCode;

    public new Info NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public new Info NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NCRResolutionCode));
      }
    }
  }
}
