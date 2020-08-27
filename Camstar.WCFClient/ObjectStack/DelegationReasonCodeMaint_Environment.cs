// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationReasonCodeMaint_Environment
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
  public class DelegationReasonCodeMaint_Environment : UserCodeMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegationReasonCodeMaint_Environment_ObjectListInquiry")]
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationReasonCodeMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCodeChanges", false, false, false, "DelegationReasonCodeChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationReasonCodeMaint_Environment_ObjectChanges")]
    protected DelegationReasonCodeChanges_Environment _ObjectChanges;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public DelegationReasonCodeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DelegationReasonCodeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
