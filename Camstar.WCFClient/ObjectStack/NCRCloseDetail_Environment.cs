// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCloseDetail_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (NCRCloseQualityDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class NCRCloseDetail_Environment : NCRUpdateDetail_Environment
  {
    [Metadata("Identifies the problem that occurred.", "NCRFailureCode", false, false, false, "NamedObjectRef", 1050449, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseDetail_Environment_NCRFailureCodes")]
    protected new Environment _NCRFailureCodes;
    [Metadata("Identifies what was done to resolve a Nonconformance.  Examples would be \"Use As Is\" or \"Scrap\".", "NCRResolutionCode", false, true, false, "NamedObjectRef", 1050494, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseDetail_Environment_NCRResolutionCode")]
    protected new Environment _NCRResolutionCode;

    public new Environment NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public new Environment NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NCRResolutionCode));
      }
    }
  }
}
