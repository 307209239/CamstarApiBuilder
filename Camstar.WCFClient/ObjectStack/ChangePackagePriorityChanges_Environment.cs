// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangePackagePriorityChanges_Environment
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
  public class ChangePackagePriorityChanges_Environment : UserCodeChanges_Environment
  {
    [Metadata("Various priorities for a change package", "ChangePackagePriority", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangePackagePriorityChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackagePriorityChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1053242, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "ChangePackagePriorityChanges_Environment_RelativePriority")]
    [Metadata("Numeric value to allow user defined sorting. The reason for sorting is to provide a Dispatch List (list what container to work on next)", "", false, false, false, "Integer", 1048705, false, false, false, null)]
    protected Environment _RelativePriority;

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

    public Environment RelativePriority
    {
      [param: In] set
      {
        this.PropertySet(nameof (RelativePriority), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RelativePriority));
      }
    }
  }
}
