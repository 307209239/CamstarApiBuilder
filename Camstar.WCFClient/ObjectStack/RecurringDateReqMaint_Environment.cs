// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecurringDateReqMaint_Environment
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
  public class RecurringDateReqMaint_Environment : MaintenanceReqMaint_Environment
  {
    [Metadata("Defines a maintenance requirement schedule based on calendar dates comprised on one or more dates.  The maintenance event must occur on the scheduled date and each following maintenance event must be followed independently of when the previous maintenance event occured.", "RecurringDateReqBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_Environment_ObjectListInquiry")]
    [Metadata("Defines a maintenance requirement schedule based on calendar dates comprised on one or more dates.  The maintenance event must occur on the scheduled date and each following maintenance event must be followed independently of when the previous maintenance event occured.", "RecurringDateReqBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_Environment_ObjectToChange")]
    [Metadata("Defines a maintenance requirement schedule based on calendar dates comprised on one or more dates.  The maintenance event must occur on the scheduled date and each following maintenance event must be followed independently of when the previous maintenance event occured.", "RecurringDateReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Defines a maintenance requirement schedule based on calendar dates comprised on one or more dates.  The maintenance event must occur on the scheduled date and each following maintenance event must be followed independently of when the previous maintenance event occured.", "RecurringDateReqChanges", false, false, false, "RecurringDateReqChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecurringDateReqMaint_Environment_ObjectChanges")]
    protected RecurringDateReqChanges_Environment _ObjectChanges;

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
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

    public RecurringDateReqChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RecurringDateReqChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
