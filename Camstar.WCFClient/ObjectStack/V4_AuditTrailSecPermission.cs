// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_AuditTrailSecPermission
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
  public class V4_AuditTrailSecPermission : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_NewValue")]
    protected Primitive<string> _NewValue;
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_OldValue")]
    protected Primitive<string> _OldValue;
    [DataMember(EmitDefaultValue = false, Name = "V4_AuditTrailSecPermission_Name")]
    protected Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is V4_AuditTrailSecPermission && object.Equals((object) this._NewValue, (object) ((V4_AuditTrailSecPermission) obj)._NewValue) && (object.Equals((object) this._OldValue, (object) ((V4_AuditTrailSecPermission) obj)._OldValue) && object.Equals((object) this._Name, (object) ((V4_AuditTrailSecPermission) obj)._Name)) && base.Equals(obj);
    }

    public Primitive<string> NewValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (NewValue));
      }
    }

    public Primitive<string> OldValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (OldValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OldValue));
      }
    }

    public Primitive<string> Name
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
