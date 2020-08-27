// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailTrivialFieldValue_Environment
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
  public class AuditTrailTrivialFieldValue_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialFieldValue_Environment_NewValue")]
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1049735, false, false, false, null)]
    protected Environment _NewValue;
    [Metadata("String that is able to accomodate all other string subtypes.", "", false, false, true, "String", 1050789, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialFieldValue_Environment_OldValue")]
    protected Environment _OldValue;
    [Metadata("Generic String", "", false, false, true, "String", 1048937, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailTrivialFieldValue_Environment_Action")]
    protected Environment _Action;

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

    public Environment Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Action));
      }
    }
  }
}
