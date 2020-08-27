// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NCRCloseDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (NCRCloseQualityDetail))]
  [Serializable]
  public class NCRCloseDetail : NCRUpdateDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseDetail_NCRFailureCodes")]
    protected new NamedObjectRef[] _NCRFailureCodes;
    [DataMember(EmitDefaultValue = false, Name = "NCRCloseDetail_NCRResolutionCode")]
    protected new NamedObjectRef _NCRResolutionCode;

    public override bool Equals(object obj)
    {
      return obj is NCRCloseDetail && this.CompareArrays((Array) this._NCRFailureCodes, (Array) ((NCRCloseDetail) obj)._NCRFailureCodes) && object.Equals((object) this._NCRResolutionCode, (object) ((NCRCloseDetail) obj)._NCRResolutionCode) && base.Equals(obj);
    }

    public new NamedObjectRef[] NCRFailureCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRFailureCodes), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (NCRFailureCodes));
      }
    }

    public new NamedObjectRef NCRResolutionCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRResolutionCode), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NCRResolutionCode));
      }
    }
  }
}
