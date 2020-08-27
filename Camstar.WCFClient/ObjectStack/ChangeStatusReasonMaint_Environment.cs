// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeStatusReasonMaint_Environment
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
  public class ChangeStatusReasonMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Container status change reason", "ChangeStatusReasonChanges", false, false, false, "ChangeStatusReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusReasonMaint_Environment_ObjectChanges")]
    protected ChangeStatusReasonChanges_Environment _ObjectChanges;
    [Metadata("The user code for container status change reason.", "ChangeStatusReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("The user code for container status change reason.", "ChangeStatusReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeStatusReasonMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public ChangeStatusReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ChangeStatusReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

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
  }
}
