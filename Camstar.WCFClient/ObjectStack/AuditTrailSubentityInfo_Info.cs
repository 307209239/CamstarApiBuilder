// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailSubentityInfo_Info
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
  public class AuditTrailSubentityInfo_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Info_ObjectDisplayName")]
    protected Info _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Info_Action")]
    protected Info _Action;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Info_HeaderId")]
    protected Info _HeaderId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;

    public Info ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public Info Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Action));
      }
    }

    public Info HeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HeaderId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HeaderId));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }
  }
}
