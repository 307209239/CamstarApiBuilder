// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskMaint
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
  public class DelegationTaskMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskMaint_ObjectChanges")]
    protected DelegationTaskChanges _ObjectChanges;

    public override bool Equals(object obj)
    {
      return obj is DelegationTaskMaint && object.Equals((object) this._ObjectToChange, (object) ((DelegationTaskMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((DelegationTaskMaint) obj)._ObjectChanges) && base.Equals(obj);
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public DelegationTaskChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DelegationTaskChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
