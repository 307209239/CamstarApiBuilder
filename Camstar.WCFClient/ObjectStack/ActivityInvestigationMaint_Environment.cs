// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityInvestigationMaint_Environment
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
  public class ActivityInvestigationMaint_Environment : ActivityMaint_Environment
  {
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_Environment_Template")]
    [Metadata("An investigation activity collects failure, cause and resulution information", "ActivityTemplateInvestigation", false, false, false, "NamedObjectRef", 1051395, false, false, true, null)]
    protected new Environment _Template;
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigationChanges", false, false, false, "ActivityInvestigationChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_Environment_ObjectChanges")]
    protected ActivityInvestigationChanges_Environment _ObjectChanges;
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, false, true, "NamedSubentityRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

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

    public ActivityInvestigationChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityInvestigationChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
