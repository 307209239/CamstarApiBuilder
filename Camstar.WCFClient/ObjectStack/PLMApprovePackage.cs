// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PLMApprovePackage
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
  public class PLMApprovePackage : SignatureApproval
  {
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_PLMApprovalURL")]
    protected Primitive<string> _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_ApprovalDecision")]
    protected new NamedSubentityRef _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_PLMApprovalCode")]
    protected Primitive<string> _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_TrackableObject")]
    protected new BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_ApprovingFor")]
    protected new NamedObjectRef _ApprovingFor;

    public override bool Equals(object obj)
    {
      return obj is PLMApprovePackage && object.Equals((object) this._PLMApprovalURL, (object) ((PLMApprovePackage) obj)._PLMApprovalURL) && (object.Equals((object) this._ApprovalDecision, (object) ((PLMApprovePackage) obj)._ApprovalDecision) && object.Equals((object) this._PLMApprovalCode, (object) ((PLMApprovePackage) obj)._PLMApprovalCode)) && (object.Equals((object) this._TrackableObject, (object) ((PLMApprovePackage) obj)._TrackableObject) && object.Equals((object) this._ApprovingFor, (object) ((PLMApprovePackage) obj)._ApprovingFor)) && base.Equals(obj);
    }

    public Primitive<string> PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public new NamedSubentityRef ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Primitive<string> PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public new BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new NamedObjectRef ApprovingFor
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingFor), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ApprovingFor));
      }
    }
  }
}
