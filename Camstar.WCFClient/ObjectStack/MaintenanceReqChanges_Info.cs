// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintenanceReqChanges_Info
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
  public class MaintenanceReqChanges_Info : RevisionedObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_DataCollectionDef")]
    protected Info _DataCollectionDef;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_MaintenanceReason")]
    protected Info _MaintenanceReason;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_PendingEmailTarget")]
    protected Info _PendingEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_DueEmailTarget")]
    protected Info _DueEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_PastDueEmailTarget")]
    protected Info _PastDueEmailTarget;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_DueEmailText")]
    protected Info _DueEmailText;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_DocumentSet")]
    protected Info _DocumentSet;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_PendingEmailText")]
    protected Info _PendingEmailText;
    [DataMember(EmitDefaultValue = false, Name = "MaintenanceReqChanges_Info_PastDueEmailText")]
    protected Info _PastDueEmailText;

    public Info DataCollectionDef
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataCollectionDef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataCollectionDef));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public Info MaintenanceReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReason));
      }
    }

    public Info PendingEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (PendingEmailTarget), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PendingEmailTarget));
      }
    }

    public Info DueEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueEmailTarget), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueEmailTarget));
      }
    }

    public Info PastDueEmailTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDueEmailTarget), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PastDueEmailTarget));
      }
    }

    public Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Info DueEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueEmailText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueEmailText));
      }
    }

    public Info DocumentSet
    {
      [param: In] set
      {
        this.PropertySet(nameof (DocumentSet), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DocumentSet));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info PendingEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (PendingEmailText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PendingEmailText));
      }
    }

    public Info PastDueEmailText
    {
      [param: In] set
      {
        this.PropertySet(nameof (PastDueEmailText), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PastDueEmailText));
      }
    }
  }
}
