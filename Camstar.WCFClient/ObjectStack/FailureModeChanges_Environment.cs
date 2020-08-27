// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FailureModeChanges_Environment
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
  public class FailureModeChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("Identifies a FailureMode for an Event.", "FailureMode", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Environment_DefaultSeverity")]
    [Metadata("Identifies the Severity of the Failure for an Event.", "FailureSeverity", false, false, false, "NamedObjectRef", 1051354, false, false, true, null)]
    protected Environment _DefaultSeverity;
    [Metadata("Provides a means to categorize Nonconformance failures.  For example \"Repeatable\".", "NCRFailureType", false, false, false, "NamedObjectRef", 1051353, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Environment_DefaultType")]
    protected Environment _DefaultType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051028, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "FailureModeChanges_Environment_Name")]
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

    public Environment DefaultSeverity
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultSeverity), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultSeverity));
      }
    }

    public Environment DefaultType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DefaultType));
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
