// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTmpltDispMaint_Environment
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
  public class ActivityTmpltDispMaint_Environment : ActivityTemplateMaint_Environment
  {
    [Metadata("Activity Template Disposition", "ActivityTmpltDispChanges", false, false, false, "ActivityTmpltDispChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Environment_ObjectChanges")]
    protected ActivityTmpltDispChanges_Environment _ObjectChanges;
    [Metadata("The template for disposition activities which record the disposition of material associated with QualityObject records.", "ActivityTemplateDisposition", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("The template for disposition activities which record the disposition of material associated with QualityObject records.", "ActivityTemplateDisposition", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityTmpltDispMaint_Environment_ProcessObjectTemplateDetails")]
    [Metadata("The template for disposition activities which record the disposition of material associated with QualityObject records.", "ActivityTemplateDisposition", false, false, false, "ActivityTemplateDisposition", 1051576, false, false, false, null)]
    protected ActivityTemplateDisposition_Environment _ProcessObjectTemplateDetails;

    public ActivityTmpltDispChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ActivityTmpltDispChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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

    public ActivityTemplateDisposition_Environment ProcessObjectTemplateDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessObjectTemplateDetails), (object) value);
      }
      get
      {
        return (ActivityTemplateDisposition_Environment) this.PropertyGet(nameof (ProcessObjectTemplateDetails));
      }
    }
  }
}
