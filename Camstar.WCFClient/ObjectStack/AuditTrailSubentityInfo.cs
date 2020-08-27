// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailSubentityInfo
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
  public class AuditTrailSubentityInfo : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_ObjectDisplayName")]
    protected Primitive<string> _ObjectDisplayName;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_Action")]
    protected Primitive<string> _Action;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_HeaderId")]
    protected Primitive<string> _HeaderId;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailSubentityInfo_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailSubentityInfo && object.Equals((object) this._ObjectDisplayName, (object) ((AuditTrailSubentityInfo) obj)._ObjectDisplayName) && (object.Equals((object) this._Action, (object) ((AuditTrailSubentityInfo) obj)._Action) && object.Equals((object) this._HeaderId, (object) ((AuditTrailSubentityInfo) obj)._HeaderId)) && object.Equals((object) this._ObjectInstanceId, (object) ((AuditTrailSubentityInfo) obj)._ObjectInstanceId) && base.Equals(obj);
    }

    public Primitive<string> ObjectDisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectDisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectDisplayName));
      }
    }

    public Primitive<string> Action
    {
      [param: In] set
      {
        this.PropertySet(nameof (Action), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Action));
      }
    }

    public Primitive<string> HeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HeaderId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HeaderId));
      }
    }

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }
  }
}
