// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailTrivialField_Environment
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
  public class AuditTrailTrivialField_Environment : AuditTrailField_Environment
  {
    [Metadata("Encapsulation for the field's instance data for all non-object type fileds and as well as object-type un-owned reference fields captured for Audit Trail", "AuditTrailTrivialFieldValue", false, false, true, "AuditTrailTrivialFieldValue", 1050793, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_Environment_FieldValues")]
    protected AuditTrailTrivialFieldValue_Environment _FieldValues;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1053057, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_Environment_FieldSubType")]
    protected Environment _FieldSubType;
    [Metadata("The Insite data type.\r\n1\tInteger\r\n2\tFloat\r\n3              Fixed\r\n4\tString\r\n5\tObject\r\n6\tTimeStamp\r\n7\tBoolean\r\n9\tDecimal\r\n", "DataTypeEnum", false, false, true, "Integer", 1050792, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialField_Environment_FieldType")]
    protected Environment _FieldType;

    public AuditTrailTrivialFieldValue_Environment FieldValues
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldValues), (object) value);
      }
      get
      {
        return (AuditTrailTrivialFieldValue_Environment) this.PropertyGet(nameof (FieldValues));
      }
    }

    public Environment FieldSubType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldSubType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldSubType));
      }
    }

    public Environment FieldType
    {
      [param: In] set
      {
        this.PropertySet(nameof (FieldType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FieldType));
      }
    }
  }
}
