﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PlanMaint_Environment
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
  public class PlanMaint_Environment : ProcessObjectMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_Environment_ObjectChanges")]
    [Metadata("A plan is a list of activities used during the processing of a Quality object", "PlanChanges", false, false, false, "PlanChanges", 1048873, true, false, false, null)]
    protected PlanChanges_Environment _ObjectChanges;
    [Metadata("A template of Plan, which is a list of acivities used to process the Quality object.", "PlanTemplate", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_Environment_Template")]
    protected new Environment _Template;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_Environment_ObjectToChange")]
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_Environment_ObjectListInquiry")]
    [Metadata("A plan is a list of Activities used during processing of a Quality object", "Plan", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "PlanMaint_Environment_ValidChildTypes")]
    [Metadata("Generic String", "", false, false, true, "String", 1052018, false, false, true, null)]
    protected new Environment _ValidChildTypes;

    public PlanChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (PlanChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public new Environment ValidChildTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ValidChildTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ValidChildTypes));
      }
    }
  }
}
