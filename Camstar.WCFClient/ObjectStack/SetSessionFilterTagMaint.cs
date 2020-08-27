// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SetSessionFilterTagMaint
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
  public class SetSessionFilterTagMaint : EmployeeMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_ObjectChanges")]
    protected SetSessionFilterTagChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_SyncName")]
    protected new Primitive<string> _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "SetSessionFilterTagMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is SetSessionFilterTagMaint && object.Equals((object) this._ObjectChanges, (object) ((SetSessionFilterTagMaint) obj)._ObjectChanges) && (object.Equals((object) this._SyncName, (object) ((SetSessionFilterTagMaint) obj)._SyncName) && object.Equals((object) this._ObjectToChange, (object) ((SetSessionFilterTagMaint) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public SetSessionFilterTagChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (SetSessionFilterTagChanges) this.PropertyGet(nameof (ObjectChanges));
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
