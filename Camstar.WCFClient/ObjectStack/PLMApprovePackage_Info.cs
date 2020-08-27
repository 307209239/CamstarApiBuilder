// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PLMApprovePackage_Info
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
  public class PLMApprovePackage_Info : SignatureApproval_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Info_PLMApprovalURL")]
    protected Info _PLMApprovalURL;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Info_ApprovalDecision")]
    protected new Info _ApprovalDecision;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Info_PLMApprovalCode")]
    protected Info _PLMApprovalCode;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Info_TrackableObject")]
    protected new Info _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "PLMApprovePackage_Info_ApprovingFor")]
    protected new Info _ApprovingFor;

    public Info PLMApprovalURL
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalURL), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PLMApprovalURL));
      }
    }

    public new Info ApprovalDecision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalDecision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovalDecision));
      }
    }

    public Info PLMApprovalCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (PLMApprovalCode), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PLMApprovalCode));
      }
    }

    public new Info TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public new Info ApprovingFor
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovingFor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApprovingFor));
      }
    }
  }
}
