// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DateReqMaint_Environment
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
  public class DateReqMaint_Environment : MaintenanceReqMaint_Environment
  {
    [Metadata("Defines a maintenance requirement schedule based on a date when maintenance is to be performed.", "DateReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DateReqMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Defines a maintenance requirement schedule based on a date when maintenance is to be performed.", "DateReqBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DateReqMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "DateReqMaint_Environment_ObjectListInquiry")]
    [Metadata("Defines a maintenance requirement schedule based on a date when maintenance is to be performed.", "DateReqBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "DateReqMaint_Environment_ObjectChanges")]
    [Metadata("Defines a maintenance requirement schedule based on a date when maintenance is to be performed.", "DateReqChanges", false, false, false, "DateReqChanges", 1048873, true, false, false, null)]
    protected DateReqChanges_Environment _ObjectChanges;

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

    public DateReqChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (DateReqChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
