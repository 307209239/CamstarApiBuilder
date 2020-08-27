// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanData_Info
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
  public class FailurePlanData_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Info_Plan")]
    protected Info _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Info_PlanType")]
    protected Info _PlanType;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Info_IsFrozen")]
    protected Info _IsFrozen;

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Plan));
      }
    }

    public Info PlanType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PlanType));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
