// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActivityInvestigationChanges_Environment
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
  public class ActivityInvestigationChanges_Environment : ActivityChanges_Environment
  {
    [Metadata("Failure data related to a quality object.", "FailureDataChanges", false, false, false, "FailureDataChanges", 1051077, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_Environment_Failures")]
    protected FailureDataChanges_Environment _Failures;
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigationChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_Environment_ObjectToChange")]
    [Metadata("An Investigation activity collects failure information along with causes and resolutions", "ActivityInvestigation", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActivityInvestigationChanges_Environment_Name")]
    protected new Environment _Name;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
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
