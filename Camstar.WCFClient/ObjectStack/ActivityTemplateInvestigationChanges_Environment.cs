// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityTemplateInvestigationChanges_Environment
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
  public class ActivityTemplateInvestigationChanges_Environment : ActivityTemplateChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationChanges_Environment_ObjectToChange")]
    [Metadata("An investigation activity collects failure, cause and resulution information", "ActivityTemplateInvestigation", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Failure data related to a quality object.", "FailureDataChanges", false, false, false, "FailureDataChanges", 1050449, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationChanges_Environment_Failures")]
    protected FailureDataChanges_Environment _Failures;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityTemplateInvestigationChanges_Environment_Name")]
    protected new Environment _Name;

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

    public FailureDataChanges_Environment Failures
    {
      [param: In] set
      {
        this.PropertySet(nameof (Failures), (object) value);
      }
      get
      {
        return (FailureDataChanges_Environment) this.PropertyGet(nameof (Failures));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
