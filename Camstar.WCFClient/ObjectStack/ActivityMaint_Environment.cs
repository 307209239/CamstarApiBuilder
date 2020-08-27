// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityMaint_Environment
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
  public class ActivityMaint_Environment : ProcessObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Environment_RuleList")]
    [Metadata("Field Expression.", "", false, false, false, "String", 1051394, false, false, false, "onExecuteRules")]
    protected new Environment _RuleList;
    [Metadata("A template of an Activity, which is the basic unit of work used to process a Quality object.", "ActivityTemplate", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Environment_Template")]
    protected new Environment _Template;
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "ActivityChanges", false, false, false, "ActivityChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Environment_ObjectChanges")]
    protected ActivityChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Environment_ObjectListInquiry")]
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("An activity is the basic unit of work during processing of a Quality object", "Activity", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Generic String", "", false, false, false, "String", 1051377, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityMaint_Environment_ActivityType")]
    protected Environment _ActivityType;

    public new Environment RuleList
    {
      [param: In] set
      {
        this.PropertySet(nameof (RuleList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RuleList));
      }
    }

    public new Environment Template
    {
      [param: In] set
      {
        this.PropertySet(nameof (Template), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Template));
      }
    }

    public ActivityChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public Environment ActivityType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActivityType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActivityType));
      }
    }
  }
}
