// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateEvent_Info
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
  public class CreateEvent_Info : QualityTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_ServiceDetail")]
    protected EventDetail_Info _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_QualityObject")]
    protected new Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_SubClassification")]
    protected Info _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_Organization")]
    protected new Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_Classification")]
    protected Info _Classification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_Submit")]
    protected Info _Submit;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Info_EventName")]
    protected Info _EventName;

    public EventDetail_Info ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail_Info) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Info SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SubClassification));
      }
    }

    public new Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Classification));
      }
    }

    public Info Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Submit));
      }
    }

    public Info EventName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EventName));
      }
    }
  }
}
