// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailSubentityField
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
  public class AuditTrailSubentityField : AuditTrailField
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityField_FieldValues")]
    protected AuditTrailSubentityInfo[] _FieldValues;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailSubentityField && this.CompareArrays((Array) this._FieldValues, (Array) ((AuditTrailSubentityField) obj)._FieldValues) && base.Equals(obj);
    }

    public AuditTrailSubentityInfo[] FieldValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValues), (object) value);
      }
      get
      {
        return (AuditTrailSubentityInfo[]) this.PropertyGet(nameof (FieldValues));
      }
    }
  }
}
