// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignedMaintReqChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResourceMaintReqChanges_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MaintClassMaintReqChanges_Environment))]
  [Serializable]
  public class AssignedMaintReqChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("AssignedMaintReqChanges", "AssignedMaintReqChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_ObjectToChange")]
    [Metadata("Contains the maintenance statuses created for a requirement.  Once created, activates the requirements, and when deleted deactivates the requirement.", "AssignedMaintReq", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_MaintenanceReq")]
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, false, false, "RevisionedObjectRef", 1050704, false, false, false, null)]
    protected Environment _MaintenanceReq;
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_ChangeHistory")]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1050705, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_ActivationDate")]
    protected Environment _ActivationDate;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048825, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_Parent")]
    protected new Environment _Parent;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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

    public Environment MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReq));
      }
    }

    public ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public Environment ActivationDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivationDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivationDate));
      }
    }

    public new Environment Parent
    {
      [param: In] set
      {
        this.PropertySet(nameof (Parent), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Parent));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
