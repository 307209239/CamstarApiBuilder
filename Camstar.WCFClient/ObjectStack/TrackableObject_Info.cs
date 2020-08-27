// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackableObject_Info
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
  public class TrackableObject_Info : BaseObject_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_WorkflowNavigator")]
    protected Info _WorkflowNavigator;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_CurrentStatus")]
    protected TrackableObjectCurrentStatus_Info _CurrentStatus;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_LastActivityDate")]
    protected Info _LastActivityDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_LastUpdatedDateGMT")]
    protected Info _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_LastMoveDateGMT")]
    protected Info _LastMoveDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_LastMoveDate")]
    protected Info _LastMoveDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_LastActivityDateGMT")]
    protected Info _LastActivityDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_Description")]
    protected Info _Description;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_WorkflowStep")]
    protected Info _WorkflowStep;
    [DataMember(EmitDefaultValue = false, Name = "TrackableObject_Info_Name")]
    protected Info _Name;

    public Info WorkflowNavigator
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowNavigator), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowNavigator));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public TrackableObjectCurrentStatus_Info CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (TrackableObjectCurrentStatus_Info) this.PropertyGet(nameof (CurrentStatus));
      }
    }

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
      }
    }

    public Info LastActivityDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDate));
      }
    }

    public Info LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Info LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Info LastMoveDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDateGMT));
      }
    }

    public Info LastMoveDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastMoveDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastMoveDate));
      }
    }

    public Info LastActivityDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastActivityDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastActivityDateGMT));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }

    public Info WorkflowStep
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkflowStep), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WorkflowStep));
      }
    }

    public Info Name
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
  }
}
