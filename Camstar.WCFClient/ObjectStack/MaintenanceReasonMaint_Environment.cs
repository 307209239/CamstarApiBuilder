// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintenanceReasonMaint_Environment
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
  public class MaintenanceReasonMaint_Environment : UserCodeMaint_Environment
  {
    [Metadata("Reason for maintence on a Resource.", "MaintenanceReason", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReasonMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReasonMaint_Environment_ObjectToChange")]
    [Metadata("Reason for maintence on a Resource.", "MaintenanceReason", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Reason for maintence on a Resource.", "MaintenanceReasonChanges", false, false, false, "MaintenanceReasonChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReasonMaint_Environment_ObjectChanges")]
    protected MaintenanceReasonChanges_Environment _ObjectChanges;

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

    public MaintenanceReasonChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MaintenanceReasonChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
