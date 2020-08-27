// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AQLLevelChanges_Environment
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
  public class AQLLevelChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Describes the number of Rejects allowed for a specific AQL level for a given Sample Size.  Each instance of this object represents an Acceptable Quality Level (AQL) value that is assigned to a Sample Plan (i.e. 0.25, 1.5, 4.0, etc.).", "AQLLevel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AQLLevelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AQLLevelChanges_Environment_SampleSizeDetails")]
    [Metadata("Stores the Sample Sizes and reject information for specific AQL level and Sample size Code", "SampleSizeDetailsChanges", false, true, false, "SampleSizeDetailsChanges", 1053117, false, true, false, null)]
    protected SampleSizeDetailsChanges_Environment _SampleSizeDetails;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053118, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AQLLevelChanges_Environment_Name")]
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

    public SampleSizeDetailsChanges_Environment SampleSizeDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (SampleSizeDetails), (object) value);
      }
      get
      {
        return (SampleSizeDetailsChanges_Environment) this.PropertyGet(nameof (SampleSizeDetails));
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
