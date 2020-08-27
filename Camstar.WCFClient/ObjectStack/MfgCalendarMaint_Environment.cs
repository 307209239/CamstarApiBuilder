// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MfgCalendarMaint_Environment
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
  public class MfgCalendarMaint_Environment : NamedDataObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarMaint_Environment_ObjectChanges")]
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendarChanges", false, false, false, "MfgCalendarChanges", 1048873, true, false, false, null)]
    protected MfgCalendarChanges_Environment _ObjectChanges;
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MfgCalendarMaint_Environment_ObjectListInquiry")]
    [Metadata("Calendar that is used to translate the timestamp of when a transaction was performed into a specific manufacturing date and shift.", "MfgCalendar", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;

    public MfgCalendarChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MfgCalendarChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
