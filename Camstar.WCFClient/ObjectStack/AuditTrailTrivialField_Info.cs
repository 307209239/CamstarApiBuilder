// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailTrivialField_Info
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
  public class AuditTrailTrivialField_Info : AuditTrailField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_Info_FieldValues")]
    protected AuditTrailTrivialFieldValue_Info _FieldValues;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_Info_FieldSubType")]
    protected Info _FieldSubType;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_Info_FieldType")]
    protected Info _FieldType;

    public AuditTrailTrivialFieldValue_Info FieldValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValues), (object) value);
      }
      get
      {
        return (AuditTrailTrivialFieldValue_Info) this.PropertyGet(nameof (FieldValues));
      }
    }

    public Info FieldSubType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSubType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldSubType));
      }
    }

    public Info FieldType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FieldType));
      }
    }
  }
}
