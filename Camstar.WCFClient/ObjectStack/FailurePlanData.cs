// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailurePlanData
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
  public class FailurePlanData : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_Plan")]
    protected NamedSubentityRef _Plan;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_PlanType")]
    protected Enumeration<FailurePlanTypeEnum, int> _PlanType;
    [DataMember(EmitDefaultValue = false, Name = "FailurePlanData_IsFrozen")]
    protected Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is FailurePlanData && object.Equals((object) this._ExportImportKey, (object) ((FailurePlanData) obj)._ExportImportKey) && (object.Equals((object) this._Plan, (object) ((FailurePlanData) obj)._Plan) && object.Equals((object) this._PlanType, (object) ((FailurePlanData) obj)._PlanType)) && object.Equals((object) this._IsFrozen, (object) ((FailurePlanData) obj)._IsFrozen) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public NamedSubentityRef Plan
    {
      [param: In] set
      {
        this.PropertySet(nameof (Plan), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Plan));
      }
    }

    public Enumeration<FailurePlanTypeEnum, int> PlanType
    {
      [param: In] set
      {
        this.PropertySet(nameof (PlanType), (object) value);
      }
      get
      {
        return (Enumeration<FailurePlanTypeEnum, int>) this.PropertyGet(nameof (PlanType));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
