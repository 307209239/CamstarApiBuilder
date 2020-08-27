// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeMaint
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
  public class EmployeeMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_ObjectChanges")]
    protected EmployeeChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_SyncName")]
    protected new Primitive<string> _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is EmployeeMaint && object.Equals((object) this._ObjectChanges, (object) ((EmployeeMaint) obj)._ObjectChanges) && (object.Equals((object) this._SyncName, (object) ((EmployeeMaint) obj)._SyncName) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((EmployeeMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ObjectToChange, (object) ((EmployeeMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public EmployeeChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (EmployeeChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Primitive<string> SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SyncName));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
