// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_AuditTrailSecPermission_Environment
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
  public class V4_AuditTrailSecPermission_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Environment_NewValue")]
    [Metadata("Label Value.", "", false, false, true, "String", 1049735, false, false, false, null)]
    protected Environment _NewValue;
    [Metadata("Label Value.", "", false, false, true, "String", 1050789, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Environment_OldValue")]
    protected Environment _OldValue;
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Environment_Name")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, true, "String", 1048681, false, false, false, null)]
    protected Environment _Name;

    public Environment NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (NewValue));
      }
    }

    public Environment OldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OldValue));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
