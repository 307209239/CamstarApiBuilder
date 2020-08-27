// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeLoginInfoMaint
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
  public class EmployeeLoginInfoMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoMaint_ObjectChanges")]
    protected EmployeeLoginInfoChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoMaint_ParentDataObject")]
    protected NamedObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is EmployeeLoginInfoMaint && object.Equals((object) this._ObjectChanges, (object) ((EmployeeLoginInfoMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((EmployeeLoginInfoMaint) obj)._ObjectToChange) && object.Equals((object) this._ParentDataObject, (object) ((EmployeeLoginInfoMaint) obj)._ParentDataObject)) && base.Equals(obj);
    }

    public EmployeeLoginInfoChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EmployeeLoginInfoChanges) this.PropertyGet(nameof (ObjectChanges));
      }
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

    public NamedObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
