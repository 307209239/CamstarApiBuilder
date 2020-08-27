// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CreateEvent_Environment
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
  public class CreateEvent_Environment : QualityTxn_Environment
  {
    [Metadata("The EventDetail service detail is used for creating and updating events", "EventDetail", false, false, false, "EventDetail", 1051158, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_ServiceDetail")]
    protected EventDetail_Environment _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_QualityObject")]
    [Metadata("An Event identifies something suspect for which more investigation must be done.  Events may be escalated to an NCR or attached to CAPAs.", "Event", false, false, false, "NamedObjectRef", 1051057, false, false, true, null)]
    protected new Environment _QualityObject;
    [Metadata("Used to subclassify QualityObjects", "SubClassification", false, true, false, "NamedObjectRef", 1051146, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_SubClassification")]
    protected Environment _SubClassification;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_Organization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, true, false, "NamedObjectRef", 1051060, false, false, true, null)]
    protected new Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_Classification")]
    [Metadata("Used to classify QualityObjects", "Classification", false, true, false, "NamedObjectRef", 1051055, false, false, true, null)]
    protected Environment _Classification;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051062, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_Submit")]
    protected Environment _Submit;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1051057, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "CreateEvent_Environment_EventName")]
    protected Environment _EventName;

    public EventDetail_Environment ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (EventDetail_Environment) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public new Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public Environment SubClassification
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubClassification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SubClassification));
      }
    }

    public new Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public Environment Classification
    {
      [param: In] set
      {
        this.PropertySet(nameof (Classification), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Classification));
      }
    }

    public Environment Submit
    {
      [param: In] set
      {
        this.PropertySet(nameof (Submit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Submit));
      }
    }

    public Environment EventName
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventName));
      }
    }
  }
}
