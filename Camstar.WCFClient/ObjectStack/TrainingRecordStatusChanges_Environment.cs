// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingRecordStatusChanges_Environment
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
  public class TrainingRecordStatusChanges_Environment : UserCodeChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordStatusChanges_Environment_ObjectToChange")]
    [Metadata("Status codes for the Employee Training Records", "TrainingRecordStatus", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Permission", "PermissionEnum", false, true, false, "Integer", 1050477, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordStatusChanges_Environment_Permission")]
    protected Environment _Permission;
    [DataMember(EmitDefaultValue = false, Name = "TrainingRecordStatusChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050478, false, false, false, null)]
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

    public Environment Permission
    {
      [param: In] set
      {
        this.PropertySet(nameof (Permission), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Permission));
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
