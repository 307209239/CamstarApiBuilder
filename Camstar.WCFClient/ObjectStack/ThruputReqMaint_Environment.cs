// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ThruputReqMaint_Environment
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
  public class ThruputReqMaint_Environment : MaintenanceReqMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqMaint_Environment_ObjectListInquiry")]
    [Metadata("Defines a maintenance requirement schedule based on maximun thruput for both Qty and Qty2. ", "ThruputReqBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqMaint_Environment_BaseToChange")]
    [Metadata("Defines a maintenance requirement schedule based on maximun thruput for both Qty and Qty2. ", "ThruputReqBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqMaint_Environment_ObjectToChange")]
    [Metadata("Defines a maintenance requirement schedule based on maximun thruput for both Qty and Qty2. ", "ThruputReq", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ThruputReqMaint_Environment_ObjectChanges")]
    [Metadata("Defines a maintenance requirement schedule based on maximun thruput for both Qty and Qty2. ", "ThruputReqChanges", false, false, false, "ThruputReqChanges", 1048873, true, false, false, null)]
    protected ThruputReqChanges_Environment _ObjectChanges;

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

    public ThruputReqChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ThruputReqChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
