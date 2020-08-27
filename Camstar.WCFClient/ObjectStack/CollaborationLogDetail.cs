// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CollaborationLogDetail
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
  public class CollaborationLogDetail : ProcessLogDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_ToRole")]
    protected NamedObjectRef _ToRole;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_FromRole")]
    protected NamedObjectRef _FromRole;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_CollaborationDate")]
    protected Primitive<DateTime> _CollaborationDate;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_ToUser")]
    protected NamedObjectRef _ToUser;
    [DataMember(EmitDefaultValue = false, Name = "CollaborationLogDetail_FromUser")]
    protected NamedObjectRef _FromUser;

    public override bool Equals(object obj)
    {
      return obj is CollaborationLogDetail && object.Equals((object) this._ToRole, (object) ((CollaborationLogDetail) obj)._ToRole) && (object.Equals((object) this._FromRole, (object) ((CollaborationLogDetail) obj)._FromRole) && object.Equals((object) this._CollaborationDate, (object) ((CollaborationLogDetail) obj)._CollaborationDate)) && (object.Equals((object) this._ToUser, (object) ((CollaborationLogDetail) obj)._ToUser) && object.Equals((object) this._FromUser, (object) ((CollaborationLogDetail) obj)._FromUser)) && base.Equals(obj);
    }

    public NamedObjectRef ToRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToRole));
      }
    }

    public NamedObjectRef FromRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromRole));
      }
    }

    public Primitive<DateTime> CollaborationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollaborationDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (CollaborationDate));
      }
    }

    public NamedObjectRef ToUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToUser), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ToUser));
      }
    }

    public NamedObjectRef FromUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromUser), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FromUser));
      }
    }
  }
}
