// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailSubentityField_Environment
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
  public class AuditTrailSubentityField_Environment : AuditTrailField_Environment
  {
    [Metadata("Encapsulation for the owned subentity field's instance data captured for Audit Trail", "AuditTrailSubentityInfo", false, false, true, "AuditTrailSubentityInfo", 1050791, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityField_Environment_FieldValues")]
    protected AuditTrailSubentityInfo_Environment _FieldValues;

    public AuditTrailSubentityInfo_Environment FieldValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValues), (object) value);
      }
      get
      {
        return (AuditTrailSubentityInfo_Environment) this.PropertyGet(nameof (FieldValues));
      }
    }
  }
}
