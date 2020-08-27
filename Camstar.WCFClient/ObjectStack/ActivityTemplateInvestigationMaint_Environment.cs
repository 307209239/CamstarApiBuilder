// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateInvestigationMaint_Environment
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
  public class ActivityTemplateInvestigationMaint_Environment : ActivityTemplateMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_Environment_ObjectChanges")]
    [Metadata("An investigation activity collects failure, cause and resulution information", "ActivityTemplateInvestigationChanges", false, false, false, "ActivityTemplateInvestigationChanges", 1048873, true, false, false, null)]
    protected ActivityTemplateInvestigationChanges_Environment _ObjectChanges;
    [Metadata("An investigation activity collects failure, cause and resulution information", "ActivityTemplateInvestigation", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("An investigation activity collects failure, cause and resulution information", "ActivityTemplateInvestigation", false, false, false, "ActivityTemplateInvestigation", 1051576, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_Environment_ProcessObjectTemplateDetails")]
    protected ActivityTemplateInvestigation_Environment _ProcessObjectTemplateDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationMaint_Environment_ObjectToChange")]
    [Metadata("An investigation activity collects failure, cause and resulution information", "ActivityTemplateInvestigation", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public ActivityTemplateInvestigationChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTemplateInvestigationChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public ActivityTemplateInvestigation_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplateInvestigation_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
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
  }
}
