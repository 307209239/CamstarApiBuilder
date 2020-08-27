// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRecordStatusChanges
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
  public class TrainingRecordStatusChanges : UserCodeChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordStatusChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordStatusChanges_Permission")]
    protected Enumeration<PermissionEnum, int> _Permission;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordStatusChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TrainingRecordStatusChanges && object.Equals((object) this._ObjectToChange, (object) ((TrainingRecordStatusChanges) obj)._ObjectToChange) && (object.Equals((object) this._Permission, (object) ((TrainingRecordStatusChanges) obj)._Permission) && object.Equals((object) this._Name, (object) ((TrainingRecordStatusChanges) obj)._Name)) && base.Equals(obj);
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

    public Enumeration<PermissionEnum, int> Permission
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permission), (object) value);
      }
      get
      {
        return (Enumeration<PermissionEnum, int>) this.PropertyGet(nameof (Permission));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
