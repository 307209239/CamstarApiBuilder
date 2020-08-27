// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailSubentityInfo_Environment
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
  public class AuditTrailSubentityInfo_Environment : ServiceData_Environment
  {
    [Metadata("Fully Qualified Name", "", false, false, true, "String", 1049720, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Environment_ObjectDisplayName")]
    protected Environment _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Environment_Action")]
    [Metadata("Generic String", "", false, false, true, "String", 1048937, false, false, false, null)]
    protected Environment _Action;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Environment_HeaderId")]
    [Metadata("Generic String", "", false, false, true, "String", 1050790, false, false, false, null)]
    protected Environment _HeaderId;
    [Metadata("Generic String", "", false, false, true, "String", 1050773, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;

    public Environment ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectDisplayName));
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

    public Environment HeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HeaderId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HeaderId));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }
  }
}
